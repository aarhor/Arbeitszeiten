using Arbeitszeiten.Klassen;
using Arbeitszeiten.Formen;

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
            string[] allowedArguments = new string[] { "/Dienstbeginn", "/Dienstende", "/Außerhalb", "/Rechnerisch", "/Tätigkeiten" };

            List<string> validArguments = new List<string>();
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
                if (CommandLineArguments.Args.Length == 1)
                {
                    firstArgument = CommandLineArguments.Args[0];

                    bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
                    double abzug = 0;
                    DateTime dateTime = DateTime.Now;
                    string Startzeit, Endzeit;

                    if (Zeit_abziehen)
                        abzug = (Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60) * (-1);

                    if (firstArgument == "/Dienstbeginn")
                    {
                        Kommandozeile.Anmelden(Convert.ToDateTime(null), abzug);

                        Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd")).ToString();

                        MessageBox.Show(new Form { TopMost = true }, string.Format("Der Beginn wurde erfolgreich eingetragen.\n" +
                            "Beginn: {0}\n" +
                            "Ende: ", Startzeit));
                        Application.Exit();
                    }
                    else if (firstArgument == "/Dienstende")
                    {
                        DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "Möchtest du eine Bemerkung mit angeben?", "Bemerkung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Bemerkung Form_Bemerkung = new Bemerkung();
                            Form_Bemerkung.ShowDialog();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd")).ToString();

                            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, false, "null", true);

                            Endzeit = SQLite.Bestimmter_wert("select Ende from Zeiten order by _id DESC LIMIT 1");

                            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
                            "Beginn: {0}\n" +
                            "Ende: {1}", Startzeit, Endzeit));
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
                else if (CommandLineArguments.Args.Length == 2)
                {
                    firstArgument = CommandLineArguments.Args[0];
                    string secondArgument = CommandLineArguments.Args[1];
                    if (firstArgument == "/Dienstende" && secondArgument == "/Außerhalb")
                    {
                        Kommandozeile.Abmelden(Convert.ToDateTime(null), true, false, "null", true);
                        MessageBox.Show(new Form { TopMost = true }, "Das Ende wurde erfolgreich eingetragen.");
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}