using Arbeitszeiten.Klassen;
using System.Diagnostics;

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
            string[] allowedArguments = new string[] { "/Dienstbeginn", "/Dienstende", "/Auﬂerhalb", "/Rechnerisch", "/?" };

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
                string thirdargument = "";

                if (CommandLineArguments.Args.Length == 1)
                {
                    firstArgument = CommandLineArguments.Args[0];

                    if (firstArgument == "/Dienstbeginn")
                    {
                        Kommandozeile.Anmelden(Convert.ToDateTime(null));
                        MessageBox.Show("Der Beginn wurde erfolgreich eingetragen.");
                        Application.Exit();
                    }
                    else if (firstArgument == "/Dienstende")
                    {
                        Kommandozeile.Abmelden(Convert.ToDateTime(null), false, false, "null");
                        MessageBox.Show("Das Ende wurde erfolgreich eingetragen.");
                        Application.Exit();
                    }
                    else if (firstArgument == "/?")
                    {
                        Console.WriteLine("Test");
                        MessageBox.Show("Test");
                        //string Pfad = Path.GetTempPath() + @"Aarhor\" + Application.ProductName + @"\Argumente.txt";

                        //if (!Directory.Exists(Pfad.Replace(@"\Argumente.txt", string.Empty))) { Directory.CreateDirectory(Pfad.Replace(@"\Argumente.txt", string.Empty)); }

                        //using (FileStream fileStream = new FileStream(Pfad, FileMode.Create, FileAccess.Write))
                        //{
                        //    using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                        //    {
                        //        binaryWriter.Write(Properties.Resources.Argumente);
                        //    }
                        //}
                        //Process.Start(Pfad);
                    }
                }
                else if (CommandLineArguments.Args.Length == 2)
                {
                    firstArgument = CommandLineArguments.Args[0];
                    secondArgument = CommandLineArguments.Args[1];

                    if (firstArgument == "/Dienstende" && secondArgument == "/Auﬂerhalb")
                    {
                        Kommandozeile.Abmelden(Convert.ToDateTime(null), true, false, "null");
                        MessageBox.Show("Das Ende wurde erfolgreich eingetragen.");
                        Application.Exit();
                    }
                }
                else if (CommandLineArguments.Args.Length == 3)
                {
                    firstArgument = CommandLineArguments.Args[0];
                    secondArgument = CommandLineArguments.Args[1];
                    thirdargument = CommandLineArguments.Args[2];

                }
                else
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}