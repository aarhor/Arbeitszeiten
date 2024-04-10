using System.Data;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Arbeitszeiten.Klassen
{
    internal class SQLite
    {
        static string Connectionstring()
        {
            string DB_Pwd = Registry.GetValue("DB_Pwd");
            SqliteConnectionStringBuilder conString = new()
            {
                DataSource = Registry.GetValue("Dateipfad"),
                Password = Crypto_137.Text_Decrypt(DB_Pwd, string.Empty)
            };

            return conString.ConnectionString;
        }

        public static void Neues_DB_Passwort(string Neues_Passwort)
        {
            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT quote($newPassword);";
                command.Parameters.AddWithValue("$newPassword", Neues_Passwort);
                var quotedNewPassword = (string)command.ExecuteScalar();

                command.CommandText = "PRAGMA rekey = " + quotedNewPassword;
                command.Parameters.Clear();
                command.ExecuteNonQuery();
            }
        }

        public static void Erstes_DB_Passwort(string Passwort)
        {

        }

        public static void Insert_table(string Datum, string Start, bool Nach_Ende)
        {
            string Metadaten = "[ { \"Ausserhalb\": " + Nach_Ende.ToString().ToLower() + " } ]";
            string SQL_Befehl = string.Format("INSERT INTO Zeiten (Datum, Start, Metadaten) VALUES ('{0}', '{1}', '{2}')", Datum, Start, Metadaten);

            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
                    {
                        command.CommandText = SQL_Befehl;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(new Form { TopMost = true }, ex.Message);
                    connection.Close();
                }
            }
        }

        public static bool Insert_table_Taetigkeit(string Datum, string Uhrzeit, string Tätigkeit)
        {
            string SQL_Befehl = string.Format("INSERT INTO Taetigkeiten (Datum, Uhrzeit, Tätigkeit) VALUES ('{0}','{1}','{2}')", Datum, Uhrzeit, Tätigkeit);
            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
                    {
                        command.CommandText = SQL_Befehl;
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(new Form { TopMost = true }, e.Message);
                    return false;
                }
            }
        }

        public static bool Update_table(string Heute, string Ende, decimal Differenz, decimal MehrMinder_Stunden, string? Bemerkung, int _id)
        {
            if (Bemerkung == "null")
                Bemerkung = "null";
            else
                Bemerkung = string.Format("'{0}'", Bemerkung);

            string SQL_Befehl = string.Format("UPDATE Zeiten SET Ende = '{0}', Differenz = {1}, MehrMinder_Stunden = {2}, Bemerkung = {3} where _id = {4}", Ende, Differenz.ToString().Replace(",", "."), MehrMinder_Stunden.ToString().Replace(",", "."), Bemerkung, _id);

            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
                    {
                        command.CommandText = SQL_Befehl;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(new Form { TopMost = true }, e.Message);
                    return false;
                }
                return true;
            }
        }

        public static string Select_table(string id)
        {
            DateTime dateTime;
            string Uhrzeit, SQL_Befehl = "SELECT Start from Zeiten where _id = " + id;

            dateTime = Convert.ToDateTime(Bestimmter_wert(SQL_Befehl));
            Uhrzeit = dateTime.TimeOfDay.ToString();

            return Uhrzeit;
        }

        /// <summary>
        /// Gibt die Heutige Startzeit als DateTime zurück
        /// </summary>
        /// <param name="heute">Den Heutigen Tag bereits als passendes DateTime formatiert (yyyy-MM-dd)</param>
        /// <returns></returns>
        public static DateTime Startzeit_heute(string heute)
        {
            DateTime startzeit;

            string SQL_Befehl = "";

            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                using (SqliteCommand command = new(SQL_Befehl, connection))
                {
                    command.CommandText = "select Start from Zeiten where Datum = '" + heute + "' and Ende ISNULL";
                    startzeit = Convert.ToDateTime(command.ExecuteScalar());
                }
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
            string? Rückgabe = string.Empty;

            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
                    {
                        command.CommandText = SQL_Befehl;
                        command.ExecuteNonQuery();

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() != false)
                                Rückgabe = reader[0].ToString();
                        }
                    }
                    connection.Close();
                    return Rückgabe;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(new Form { TopMost = true }, ex.Message.ToString());
                    connection.Close();
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gibt einen bestimmten Wert aus der Datenbank zurück.
        /// </summary>
        /// <param name="SQL_Befehl"></param>
        /// <returns>Keine Art von Rückgabe.</returns>
        public static bool Nur_Befehl(string SQL_Befehl)
        {
            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
                    {
                        command.CommandText = SQL_Befehl;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    connection.Close();
                    return false;
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

            using (SqliteConnection connection = new(Connectionstring()))
            {
                connection.Open();
                try
                {
                    using (SqliteCommand command = new(SQL_Befehl, connection))
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
                    connection.Close();

                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(new Form { TopMost = true }, ex.Message.ToString());
                    connection.Close();

                    list.Clear();
                    list.Add("# Leer #");
                    return list;
                }
            }
        }
    }
}
