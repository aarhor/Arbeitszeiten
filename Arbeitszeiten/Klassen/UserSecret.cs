using Microsoft.Extensions.Configuration;

namespace Arbeitszeiten.Klassen
{
    internal class UserSecret
    {
        public static string Schluessel()
        {
            string Passwort;
            var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .AddUserSecrets<UserSecret>()
            .Build();

            Passwort = $"{config["AppSettings:Crypto_137"]}";

            return Passwort;
        }
    }
}
