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
