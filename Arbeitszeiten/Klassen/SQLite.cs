using System.Data;
using System.Data.SQLite;

namespace Arbeitszeiten.Klassen
{
    internal class SQLite
    {
        static string Connectionstring()
        {
            string Pfad = Registry.GetValue("Dateipfad");
            string Version = "3";
            string Connectionstring = "DataSource=" + Pfad + "; Version=" + Version;

            return Connectionstring;
        }

        public static void create_table()
        {
            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (SQLiteCommand command = new(connection))
            {
                command.CommandText = Properties.Resources.Erstellen;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public static void insert_table(string Datum, string Start)
        {
            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (SQLiteCommand command = new(connection))
                    {
                        command.CommandText = "INSERT INTO Zeiten (Datum, Start) VALUES (@Datum, @Start)";
                        command.Parameters.AddWithValue("@Datum", Datum);
                        command.Parameters.AddWithValue("@Start", Start);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    transaction.Rollback();
                }
            }
            connection.Close();
        }

        public static bool insert_table_Taetigkeit(string Datum, string Uhrzeit,string Tätigkeit)
        {
            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (SQLiteCommand command = new(connection))
                    {
                        command.CommandText = "INSERT INTO Taetigkeiten (Datum, Uhrzeit, Tätigkeit) VALUES (@Datum, @Uhrzeit, @Tätigkeit)";
                        command.Parameters.AddWithValue("@Datum", Datum);
                        command.Parameters.AddWithValue("@Uhrzeit", Uhrzeit);
                        command.Parameters.AddWithValue("@Tätigkeit", Tätigkeit);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    transaction.Rollback();
                    return false;
                }
            }
            connection.Close();
            return true;
        }

        public static void update_table(string Heute, string Ende, decimal Differenz, decimal MehrMinder_Stunden, string? Bemerkung)
        {
            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (SQLiteCommand command = new(connection))
                    {
                        if (Bemerkung == "null")
                            Bemerkung = null;

                        command.CommandText = "UPDATE Zeiten SET Ende = @Ende, Differenz = @Differenz, MehrMinder_Stunden = @MehrMinder_Stunden, Bemerkung = @Bemerkung where Datum = \"" + Heute + "\" and Ende IS NULL order by Start DESC LIMIT 1";
                        command.Parameters.AddWithValue("@Ende", Ende);
                        command.Parameters.AddWithValue("@Differenz", Differenz);
                        command.Parameters.AddWithValue("@MehrMinder_Stunden", MehrMinder_Stunden);
                        command.Parameters.AddWithValue("@Bemerkung", Bemerkung);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    transaction.Rollback();
                }
            }
            connection.Close();
        }

        public static string select_table(string Heute)
        {
            DateTime dateTime;
            string Uhrzeit;

            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (SQLiteCommand command = new(connection))
            {
                command.CommandText = "SELECT Start from Zeiten where Datum = \"" + Heute + "\" and Ende IS NULL order by Start DESC LIMIT 1";
                dateTime = Convert.ToDateTime(command.ExecuteScalar());
                Uhrzeit = dateTime.TimeOfDay.ToString();
            }
            connection.Close();

            return Uhrzeit;
        }

        /// <summary>
        /// Gibt die Heutige Startzeit als DateTime zurück
        /// </summary>
        /// <param name="heute">Den Heutigen Tag bereits als passendes DateTime formatiert (YYYY-MM-DD)</param>
        /// <returns></returns>
        public static DateTime startzeit_heute(string heute)
        {
            DateTime startzeit;

            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (SQLiteCommand command = new(connection))
            {
                command.CommandText = "select Start from Zeiten where Datum = '" + heute + "' and Ende ISNULL";
                startzeit = Convert.ToDateTime(command.ExecuteScalar());
            }

            return startzeit;
        }

        /// <summary>
        /// Gibt einen bestimmten Wert aus der Datenbank zurück.
        /// </summary>
        /// <param name="SQL_Befehl">Der SQL-Befehl wo der Wert ermittelt wird. Es darf nur einen Rückgabewert geben.</param>
        /// <returns>Gibt den gewünschten Wert als String zurück.</returns>
        public static string Bestimmter_wert(string SQL_Befehl)
        {
            string Rückgabe = string.Empty;

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        using (SQLiteCommand command = new(connection))
                        {
                            command.CommandText = SQL_Befehl;
                            command.ExecuteNonQuery();

                            using (IDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read() != false)
                                    Rückgabe = reader[0].ToString();
                            }
                        }
                        transaction.Commit();
                        connection.Close();
                        return Rückgabe;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        transaction.Rollback();
                        connection.Close();
                        return string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Erzeugt eine Liste mit Daten aus der Datenbank zum darstellen von einträgen.
        /// </summary>
        /// <param name="SQL_Befehl">Der SQL Befehl der genutzt werden soll.</param>
        /// <param name="Anzahl_spalten">Die Anzahl der Spalten die abgefragt werden sollen. Maximal 14.</param>
        /// <returns>Gibt eine Liste mit den gewünschten Daten zurück.</returns>
        public static List<string> Auflistung_Einträge(string SQL_Befehl, int Anzahl_spalten)
        {
            List<string> list = new();

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        using (SQLiteCommand command = new(connection))
                        {
                            command.CommandText = SQL_Befehl;
                            command.ExecuteNonQuery();

                            using (IDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read() != false)
                                {
                                    int i = 0;
                                    while (i < Anzahl_spalten)
                                    {
                                        list.Add(reader[i].ToString());
                                        i++;
                                    }
                                }
                            }
                        }
                        transaction.Commit();
                        connection.Close();

                        return list;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        transaction.Rollback();
                        connection.Close();

                        list.Clear();
                        list.Add("# Leer #");
                        return list;
                    }
                }
            }
        }
    }
}
