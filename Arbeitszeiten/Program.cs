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
            string[] allowedArguments = new string[] { "/Dienstbeginn", "/Dienstende" };

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

            bool vorhanden = Klassen.Registry.RegistryKeyExists(@"software\" + Application.CompanyName + @"\" + Application.ProductName);
            if (!vorhanden)
                Application.Run(new Einstellungen());
            else
                Application.Run(new Form1());
        }
    }
}