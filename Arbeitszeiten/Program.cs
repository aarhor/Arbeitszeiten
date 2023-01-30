using Arbeitszeiten.Klassen;

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
            //string Pfad = Application.ExecutablePath;
            string[] allowedArguments = new string[] { "/Dienstbeginn", "/Dienstende", "/Au�erhalb", "/Rechnerisch" };

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
                string firstArgument = "";
                string secondArgument = "";
                if (CommandLineArguments.Args.Length == 1)
                {
                    firstArgument = CommandLineArguments.Args[0];

                    if (firstArgument == "/Dienstbeginn")
                    {
                        Kommandozeile.Anmelden(Convert.ToDateTime(null));
                        MessageBox.Show("Der Beginn wurde erfolgreich eingetragen.\nDas Programm wird nun direkt wieder geschlossen.");
                        Application.Exit();
                    }
                    else if (firstArgument == "/Dienstende")
                    {
                        Kommandozeile.Abmelden(Convert.ToDateTime(null), false);
                        MessageBox.Show("Der Ende wurde erfolgreich eingetragen.\nDas Programm wird nun direkt wieder geschlossen.");
                        Application.Exit();
                    }
                }
                else if (CommandLineArguments.Args.Length == 2)
                {
                    firstArgument = CommandLineArguments.Args[0];
                    secondArgument = CommandLineArguments.Args[1];

                    if (firstArgument == "/Dienstende" && secondArgument == "/Au�erhalb")
                    {
                        Kommandozeile.Abmelden(Convert.ToDateTime(null), true);
                        MessageBox.Show("Der Ende wurde erfolgreich eingetragen.\nDas Programm wird nun direkt wieder geschlossen.");
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