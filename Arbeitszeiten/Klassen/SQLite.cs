using System.Data;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                command.CommandText = "CREATE TABLE Zeiten (ID_Erfassung INTEGER PRIMARY KEY, Datum DATE, Start DATETIME, Ende DATETIME, Differenz DOUBLE, MehrMinder_Stunden DOUBLE)";
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

        public static void update_table(string Heute, string Ende, decimal Differenz, decimal MehrMinder_Stunden)
        {
            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (SQLiteCommand command = new(connection))
                    {
                        command.CommandText = "UPDATE Zeiten SET Ende = @Ende, Differenz = @Differenz, MehrMinder_Stunden = @MehrMinder_Stunden where Datum = \"" + Heute + "\" and Ende IS NULL order by Start DESC LIMIT 1";
                        command.Parameters.AddWithValue("@Ende", Ende);
                        command.Parameters.AddWithValue("@Differenz", Differenz);
                        command.Parameters.AddWithValue("@MehrMinder_Stunden", MehrMinder_Stunden);
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

        public static int count_table(string Heute)
        {
            int Anzahl;

            using SQLiteConnection connection = new(Connectionstring());
            connection.Open();
            using (SQLiteCommand command = new(connection))
            {
                command.CommandText = "SELECT count(Datum) from Zeiten where Datum = \"" + Heute + "\"";
                Anzahl = Convert.ToInt32(command.ExecuteScalar());
                command.ExecuteNonQuery();
            }
            connection.Close();

            return Anzahl;
        }
    }
}
