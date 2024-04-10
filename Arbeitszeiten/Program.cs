using Arbeitszeiten.Klassen;
using Arbeitszeiten.Formen;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

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
            string[] allowedArguments = ["/Dienstbeginn", "/Dienstende", "/Rechnerisch", "/Tätigkeiten"];

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
                List<string> list = [];
                List<string> Metadaten = [];
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
                        list.Clear();
                        list = SQLite.Auflistung_Einträge("select _id, Datum, Start, Ende from Zeiten order by _id DESC LIMIT 1", 4);
                        string Datum = Convert.ToDateTime(list[1]).ToString("d");
                        string Beginn = Convert.ToDateTime(list[2]).ToString("t");

                        if (list.Count > 0)
                        {
                            string Datum_id = string.Format("ID:\t{0}\n" +
                                                            "Datum:\t{1}\n" +
                                                            "Beginn:\t{2}", list[0], Datum, Beginn);

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

                                Kommandozeile.Anmelden(Convert.ToDateTime(null), abzug, Nach_Ende);

                                Startzeit = SQLite.Startzeit_heute(dateTime.ToString("yyyy-MM-dd"));

                                MessageBox.Show(new Form { TopMost = true }, string.Format("Der Beginn wurde erfolgreich eingetragen.\n" +
                                    "Datum:\t{0}\n" +
                                    "Beginn:\t{1}\n" +
                                    "Ende:\t", Startzeit.ToString("d"), Startzeit.ToString("T")));
                                Application.Exit();
                            }
                        }
                    }
                    else if (firstArgument == "/Dienstende")
                    {
                        list.Clear();
                        list = SQLite.Auflistung_Einträge("select _id, Datum, Start, Ende, Metadaten from Zeiten order by _id DESC LIMIT 1", 5);
                        Metadaten = Klassen.Metadaten.Auslesen(list[4], false, "Ausserhalb");

                        Nach_Ende = Convert.ToBoolean(Metadaten[1]);
                        id = int.Parse(list[0]);

                        DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "Möchtest du eine Bemerkung mit angeben?", "Bemerkung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Bemerkung Form_Bemerkung = new Bemerkung(id, Nach_Ende);
                            Form_Bemerkung.ShowDialog();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Startzeit = SQLite.Startzeit_heute(dateTime.ToString("yyyy-MM-dd"));

                            Kommandozeile.Abmelden(Convert.ToDateTime(null), Nach_Ende, false, "null", true, id);

                            DateTime Endzeit = Convert.ToDateTime(SQLite.Bestimmter_wert("select Ende from Zeiten where _id = " + id.ToString()));
                            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
                                "Datum:\t{0}\n" +
                                "Beginn:\t{1}\n" +
                                "Ende:\t{2}", Startzeit.ToString("d"), Startzeit.ToString("T"), Endzeit.ToString("T")));
                            Application.Exit();
                        }
                        else if (dialogResult == DialogResult.Cancel)
                            MessageBox.Show("Es wurden keine Änderungen durchgeführt");
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