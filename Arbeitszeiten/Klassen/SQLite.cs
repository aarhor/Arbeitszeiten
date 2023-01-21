using System.Data.SQLite;

namespace Arbeitszeiten.Klassen
{
    internal class SQLite
    {

        static string Connectionstring()
        {
            string Pfad = Registry.GetValue("Dateipfad");
            string Connectionstring = "DataSource=" + Pfad;

            return Connectionstring;
        }

        public static void create_table()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "CREATE TABLE Zeiten (ID_Erfassung INTEGER PRIMARY KEY, Datum DATE, Start DATETIME, Ende DATETTIME, Differenz DOUBLE, MehrMinder_Stunden DOUBLE)";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void insert_table(string Datum, string Start)
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Zeiten (Datum, Start) VALUES (@Datum, @Start)";
                    command.Parameters.AddWithValue("@Datum", Datum);
                    command.Parameters.AddWithValue("@Start", Start);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void update_table(string Heute, string Ende, decimal Differenz, decimal MehrMinder_Stunden)
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE Zeiten SET Ende = @Ende, Differenz = @Differenz, MehrMinder_Stunden = @MehrMinder_Stunden where Datum = \"" + Heute + "\" and Ende IS NULL order by Start DESC LIMIT 1";
                    command.Parameters.AddWithValue("@Ende", Ende);
                    command.Parameters.AddWithValue("@Differenz", Differenz);
                    command.Parameters.AddWithValue("@MehrMinder_Stunden", MehrMinder_Stunden);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static string select_table(string Heute)
        {
            string Pfad = Registry.GetValue("Dateipfad");
            DateTime dateTime;
            string Uhrzeit;

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT Start from Zeiten where Datum = \"" + Heute + "\" and Ende IS NULL";
                    dateTime = Convert.ToDateTime(command.ExecuteScalar());
                    Uhrzeit = dateTime.TimeOfDay.ToString();
                }
                connection.Close();

                return Uhrzeit;
            }
        }

        public static int count_table(string Heute)
        {
            string Pfad = Registry.GetValue("Dateipfad");
            int Anzahl;

            using (SQLiteConnection connection = new SQLiteConnection(Connectionstring()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
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
}
