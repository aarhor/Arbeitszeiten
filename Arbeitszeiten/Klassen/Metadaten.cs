using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeiten.Klassen
{
    internal class Metadaten
    {
        /// <summary>
        /// Erstellt einen JSON string mit den gewünschten Metadaten / Tags
        /// </summary>
        /// <param name="Daten">Die Auflistung der Daten die übergeben werden. [Name] [Inhalt] [Datentyp(Text, Zahl, Bool)]</param>
        /// <returns>Gibt einen fertigen JSON mit den angegebenen Metadaten zurück.</returns>
        public static string Generator(List<string> Daten)
        {
            string Datentyp, Inhalt;
            string Rückgabe = "[\n" +
                       "{\n";

            if (Daten.Count > 0)
            {
                Inhalt = "";
                for (int i = 0; i < Daten.Count; i += 3)
                {
                    Datentyp = Daten[i + 2];

                    switch (Datentyp)
                    {
                        case "Text":
                            Inhalt = string.Format("\"{0}\"", Daten[i + 1]);
                            break;
                        case "Zahl":
                            Inhalt = string.Format("{0}", Daten[i + 1]);
                            break;
                        case "Bool":
                            Inhalt = string.Format("{0}", Daten[i + 1].ToLower());
                            break;
                        default:
                            MessageBox.Show(new Form { TopMost = true }, string.Format("Es wurde kein Datentyp für {0} angegeben!", Daten[i + 1]));
                            break;
                    }
                    Rückgabe += string.Format("\"{0}\": {1},\n", Daten[i], Inhalt);
                }
                Rückgabe = Rückgabe.Remove(Rückgabe.Length - 2, 2);

                Rückgabe += "\n}\n]";
            }
            else
                Rückgabe += "}\n]";

            return Rückgabe.Replace("\n", " ");
        }

        /// <summary>
        /// Gibt alle oder ein gewünschten Werte als List zurück.
        /// </summary>
        /// <param name="Metadaten">Die auszulesenden Metadaten.</param>
        /// <param name="Alle_Tags">Ob alles zurückgegeben werden soll.</param>
        /// <param name="Bestimmter_Wert">Welcher Wert zurückgegeben wird</param>
        /// <returns>Alle oder ein gewünschten Wert als List. Es wird immer der Name sowie dessen, ggfs. mit den anderen, zurückgegeben.</returns>
        public static List<string> Auslesen(string Metadaten, bool Alle_Tags = true, string Bestimmter_Wert = "")
        {
            List<string> Rueckgabe = [];

            if (!string.IsNullOrEmpty(Metadaten))
            {
                List<string> Werte = [.. Metadaten.Split(", ")];
                string Inhalt = "";
                string[] Aufgeteilt = new string[2];

                Werte[0] = Werte[0].Replace("[ { ", "");
                Werte[^1] = Werte[^1].Replace(" } ]", "");

                if (Alle_Tags)
                {
                    for (int i = 0; i < Werte.Count; i++)
                    {
                        Inhalt = Werte[i].Replace("\"", "").Replace("{ ", "").Replace("}", "");
                        Aufgeteilt = Inhalt.Split(": ");

                        if (Aufgeteilt.Length == 2)
                        {
                            Rueckgabe.Add(Aufgeteilt[0]);
                            Rueckgabe.Add(Aufgeteilt[1]);
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Bestimmter_Wert))
                    {
                        for (int i = 0; i < Werte.Count; i++)
                        {
                            Inhalt = Werte[i].Replace("\"", "").Replace("{ ", "").Replace("}", "");
                            Aufgeteilt = Inhalt.Split(": ");

                            if (Aufgeteilt[0] == Bestimmter_Wert)
                            {
                                Rueckgabe.Add(Aufgeteilt[0]);
                                Rueckgabe.Add(Aufgeteilt[1]);
                                break;
                            }
                        }
                    }
                }

                return Rueckgabe;
            }
            else
            {
                Rueckgabe.Add("Wat soll ich sagen");
                Rueckgabe.Add("# Leer #");
                return Rueckgabe;
            }
        }
    }
}
