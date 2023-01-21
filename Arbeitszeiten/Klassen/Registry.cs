using Microsoft.Win32;

namespace Arbeitszeiten.Klassen
{
    internal class Registry
    {
        public static string GetValue(string Schluessel)
        {
            RegistryKey _key;
            string Ausgabe = string.Empty;
            _key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"software\" + Application.CompanyName + @"\" + Application.ProductName);

            if (_key != null)
                return Ausgabe = _key.GetValue(Schluessel).ToString();
            else
                return "Kein Eintrag gefunden";
        }

        public static void SetValue(string Schluessel, string Wert)
        {
            RegistryKey _key;
            _key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"software\" + Application.CompanyName + @"\" + Application.ProductName);

            _key.SetValue(Schluessel, Wert);
        }

        public static bool RegistryKeyExists(string path)
        {
            return Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path) != null;
        }

        public static void DeleteSubKeyTree(string keyName, string Löschen)
        {
            using (RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key == null)
                {
                    // Key doesn't exist. Do whatever you want to handle
                    // this case
                }
                else
                {
                    key.DeleteSubKey(Löschen);
                }
            }
        }
    }
}
