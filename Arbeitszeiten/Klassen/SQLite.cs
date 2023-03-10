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

        public static List<string> select_Tage_stats(string Monatszahl, string Jahreszahl)
        {
            List<string> list = new();

            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (SQLiteCommand command = new(connection))
            {
                command.CommandText = "select Datum from Zeiten where Datum like '" + Jahreszahl + "-" + Monatszahl + "-%' group by Datum";
                IDataReader reader = command.ExecuteReader();

                while (reader.Read() != false)
                {
                    int i = 0;
                    while (i < 1)
                    {
                        list.Add(item: reader[i].ToString());
                        i++;
                    }
                }
            }
            connection.Close();

            return list;
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
    }
}
