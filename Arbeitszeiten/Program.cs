using Arbeitszeiten.Klassen;
using Arbeitszeiten.Formen;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Arbeitszeiten
{
    internal static class Program
    {
        public static class CommandLineArguments
        {
            public static string[] Args { get; private set; }

            static CommandLineArguments()
            {
                Args = CheckCMDArgs(Environment.GetCommandLineArgs());
            }
        }

        public static string[] CheckCMDArgs(string[] Argumente)
        {
            string[] allowedArguments = ["/Dienstbeginn", "/Dienstende", "/Rechnerisch", "/Tätigkeiten", "/Außerhalb", "/Workshop"];

            List<string> validArguments = [];
            foreach (string arg in Argumente)
            {
                if (allowedArguments.Contains(arg))
                {
                    validArguments.Add(arg);
                }
            }

            return validArguments.ToArray();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            bool vorhanden = Registry.RegistryKeyExists(@"software\" + Application.CompanyName + @"\" + Application.ProductName);
            if (!vorhanden)
                Application.Run(new Einstellungen());
            else
            {
                string firstArgument;
                int id;
                bool Nach_Ende = false;
                DateTime dateTime = DateTime.Now;

                if (CommandLineArguments.Args.Length == 0)
                    Application.Run(new Form1());

                if (CommandLineArguments.Args.Length >= 1)
                {
                    firstArgument = CommandLineArguments.Args[0];

                    bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
                    double abzug = 0;

                    if (Zeit_abziehen)
                        abzug = (Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60) * (-1);

                    DateTime Startzeit;
                    if (firstArgument == "/Dienstbeginn")
                    {
                        if (CommandLineArguments.Args.Contains("/Außerhalb") && CommandLineArguments.Args.Contains("/Workshop"))
                        {
                            MessageBox.Show(new Form { TopMost = true }, string.Format("Es wurden die beiden Schalter \"/Außerhalb\" und \"/Workshop\" angegeben.\n" +
                                "Diese schließen sich beide jedoch aus. Einer der beiden muss entfernt werden."));
                            Application.Run(new Form1());
                        }
                        else
                        {
                            list.Clear();
                            list = SQLite.Auflistung_Einträge("select _id, Datum, Start, Ende from Zeiten order by _id DESC LIMIT 1", 4);
                            string Datum = Convert.ToDateTime(list[1]).ToString("d");
                            string Beginn = Convert.ToDateTime(list[2]).ToString("t");

                            if (list.Count > 0)
                            {
                                string Datum_id = Diverses.Datum_Start_Ende(list[0], Datum, Beginn, "- Nicht vorhanden -");
                                List<string> Optionen = [
                                    "Ausserhalb",
                                    CommandLineArguments.Args.Contains("/Außerhalb").ToString(),
                                    "Bool",
                                    "Workshop",
                                    CommandLineArguments.Args.Contains("/Workshop").ToString(),
                                    "Bool"
                                ];

                                if (string.IsNullOrEmpty(list[3]))
                                {
                                    MessageBox.Show("Der letzte Eintrag wurde noch nicht angeschlossen. Über die Statistiken oder die Hauptform muss erst ein Ende eingetragen werden damit ein neuer Eintrag angelegt werden kann.\n\n" + Datum_id, "Ende fehlt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    Application.Run(new Form1());
                                }
                                else
                                {
                                    string Wochentag = dateTime.ToString("dddd");
                                    if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                                        Nach_Ende = true;
                                    else if ((Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag") && (dateTime.Hour >= 15 || dateTime.Hour <= 6))
                                        Nach_Ende = true;

                                    Kommandozeile.Anmelden(Convert.ToDateTime(null), abzug, Optionen);

                                    Startzeit = SQLite.Startzeit_heute(dateTime.ToString("yyyy-MM-dd"));
                                    string id_Start = SQLite.Bestimmter_wert("select _id from Zeiten order by _id DESC LIMIT 1");
                                    string Daten = Diverses.Datum_Start_Ende(id_Start, Startzeit.ToString("d"), Startzeit.ToString("t"), "");

                                    MessageBox.Show(new Form { TopMost = true }, string.Format("Der Beginn wurde erfolgreich eingetragen.\n" +
                                        Daten));
                                    Application.Exit();
                                }
                            }
                        }
                    }
                    else if (firstArgument == "/Dienstende")
                    {
                        if (CommandLineArguments.Args.Contains("/Außerhalb"))
                            Nach_Ende = true;

                        DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "Möchtest du eine Bemerkung mit angeben?", "Bemerkung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd"));
                            id = int.Parse(SQLite.Bestimmter_wert(string.Format("select _id from Zeiten where Datum = '{0}' and Ende ISNULL", Startzeit.ToString("yyyy-MM-dd"))));

                            Bemerkung Form_Bemerkung = new Bemerkung(id, Nach_Ende);
                            Form_Bemerkung.ShowDialog();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd"));
                            id = int.Parse(SQLite.Bestimmter_wert(string.Format("select _id from Zeiten where Datum = '{0}' and Ende ISNULL", Startzeit.ToString("yyyy-MM-dd"))));

                            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, "null", true, id);

                            DateTime Endzeit = Convert.ToDateTime(SQLite.Bestimmter_wert("select Ende from Zeiten where _id = " + id.ToString()));
                            string Daten = Diverses.Datum_Start_Ende(id.ToString(), Startzeit.ToString("d"), Startzeit.ToString("t"), Endzeit.ToString("t"));

                            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
                                Daten));
                            Application.Exit();
                        }
                        else if (dialogResult == DialogResult.Cancel)
                            MessageBox.Show(new Form { TopMost = true }, "Es wurden keine Änderungen durchgeführt");
                    }
                    else if (firstArgument == "/Tätigkeiten")
                    {
                        Application.Run(new Tätigkeiten { TopMost = true });
                    }
                }
            }
        }
    }
}