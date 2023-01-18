using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    command.CommandText = "CREATE TABLE Zeiten (ID INTEGER PRIMARY KEY, Start DATETIME, Ende DATETTIME, Differenz DOUBLE)";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void insert_table(string Start, string Ende, double Differenz)
        {
            string Pfad = Registry.GetValue("Dateipfad");

            using (var connection = new SqliteConnection(@"DataSource=" + Pfad))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Zeiten (Start, Ende, Differenz) VALUES (@start, @ende, @differenz)";
                    command.Parameters.AddWithValue("@start", "John Doe");
                    command.Parameters.AddWithValue("@ende", 30);
                    command.Parameters.AddWithValue("@differenz", 3.58);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
