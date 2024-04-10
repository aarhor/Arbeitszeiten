using Arbeitszeiten.Klassen;
using System.Security.Cryptography;
using System.Text;

namespace Arbeitszeiten.Klassen
{
    internal class Crypto_137
    {
        /// <summary>
        /// Methode zum Verschlüsseln von Texten
        /// </summary>
        /// <param name="clearText">Der zu verschlüsselnde Text.</param>
        /// <param name="Passwort">Das Passwort was zum verschlüsseln genutzt wird. Wenn nichts angegeben, dann wird der Standard wert genutzt.</param>
        /// <returns>Der Verschlüsselte Text.</returns>
        public static string Text_Encrypt(string clearText, string Passwort)
        {
            if (string.IsNullOrEmpty(Passwort))
                Passwort = UserSecret.Schluessel();

            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new(Passwort, [0x7E, 0x87, 0x2F, 0x68, 0xE6, 0xBC, 0xDE, 0xE7, 0x9E, 0x2D, 0x5B, 0x4D, 0xE8, 0x4A, 0xA3, 0xB3, 0x93, 0xB3, 0x6F, 0xB1, 0x48, 0x12]);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                MemoryStream ms = new();

                CryptoStream cs = new(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(clearBytes, 0, clearBytes.Length);
                cs.Close();
                clearText = Convert.ToBase64String(ms.ToArray());
            }
            return clearText;
        }

        /// <summary>
        /// Methode zum Entschlüsseln von Texten
        /// </summary>
        /// <param name="cipherText">Der Text der entschlüsselt werden soll.</param>
        /// <param name="Passwort">Das Passwort was zum verschlüsseln genutzt wird. Wenn nichts angegeben, dann wird der Standard wert genutzt.</param>
        /// <returns>Den entschlüsselten Text.</returns>
        public static string Text_Decrypt(string cipherText, string Passwort)
        {
            if (string.IsNullOrEmpty(cipherText) == false)
            {
                if (string.IsNullOrEmpty(Passwort))
                    Passwort = UserSecret.Schluessel();

                cipherText = cipherText.Replace(" ", "+");
                int mod4 = cipherText.Length % 4;

                if (mod4 > 0)
                    cipherText += new string('=', 4 - mod4);

                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new(Passwort, [0x7E, 0x87, 0x2F, 0x68, 0xE6, 0xBC, 0xDE, 0xE7, 0x9E, 0x2D, 0x5B, 0x4D, 0xE8, 0x4A, 0xA3, 0xB3, 0x93, 0xB3, 0x6F, 0xB1, 0x48, 0x12]);
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    MemoryStream ms = new();

                    CryptoStream cs = new(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write);

                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();

                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }

                return cipherText;
            }
            else
                return "";
        }
    }
}
