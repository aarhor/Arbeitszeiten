using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arbeitszeiten.Klassen
{
    internal class SQLite
    {
        public static void create_table()
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (var connection = new SqliteConnection(@"DataSource=" + Pfad))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "CREATE TABLE Zeiten (ID_Erfassung INTEGER PRIMARY KEY, Datum DATE, Start DATETIME, Ende DATETTIME, Differenz DOUBLE, Ueberzeit DOUBLE)";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void insert_table(string Datum, string Start)
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (var connection = new SqliteConnection(@"DataSource=" + Pfad))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Zeiten (Datum, Start) VALUES (@Datum, @Start)";
                    command.Parameters.AddWithValue("@Datum", Datum);
                    command.Parameters.AddWithValue("@Start", Start);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void update_table(string Heute, string Ende, decimal Differenz, decimal Überzeit)
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (var connection = new SqliteConnection(@"DataSource=" + Pfad))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Zeiten SET ENDE = @Ende, Differenz = @Differenz, Ueberzeit = @Ueberzeit where Datum = \"" + Heute + "\"";
                    command.Parameters.AddWithValue("@Ende", Ende);
                    command.Parameters.AddWithValue("@Differenz", Differenz);
                    command.Parameters.AddWithValue("@Ueberzeit", Überzeit);
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

            using (var connection = new SqliteConnection(@"DataSource=" + Pfad))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Start from Zeiten where Datum = \"" + Heute + "\"";
                    dateTime = Convert.ToDateTime(command.ExecuteScalar());
                    Uhrzeit = dateTime.TimeOfDay.ToString();
                }
                connection.Close();

                return Uhrzeit;
            }
        }
    }
}
