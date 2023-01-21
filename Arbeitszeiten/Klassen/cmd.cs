﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeiten.Klassen
{
    internal class Kommandozeile
    {
        public static void Anmelden()
        {
            DateTime dateTime = DateTime.Now;
            string heute = dateTime.ToString("yyyy-MM-dd");
            string Startzeit = dateTime.ToString("HH:mm:ss");

            SQLite.insert_table(heute, Startzeit);
        }

        public static decimal Abmelden()
        {
            DateTime dateTime = DateTime.Now;
            string heute = dateTime.ToString("yyyy-MM-dd");

            DateTime Startzeit = Convert.ToDateTime(SQLite.select_table(heute));
            TimeSpan Differenz = dateTime - Startzeit;

            decimal Differenz_dezimal = Convert.ToDecimal(Math.Round(Differenz.TotalHours, 2));
            string Ende_Gelände = dateTime.ToString("HH:mm:ss");
            string Wochentag = dateTime.ToString("dddd");
            decimal Ueberzeit = 0;

            if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                Ueberzeit = Differenz_dezimal - 8;
            else if (Wochentag == "Freitag")
                Ueberzeit = Differenz_dezimal - 5;
            else if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                Ueberzeit = Differenz_dezimal - 0;

            SQLite.update_table(heute, Ende_Gelände, Differenz_dezimal, Ueberzeit);

            return Differenz_dezimal;
        }
    }
}
