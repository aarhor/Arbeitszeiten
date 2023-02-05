using System;

namespace Arbeitszeiten.Klassen
{
    internal class Kommandozeile
    {
        public static void Anmelden(DateTime dateTime)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now; }

            string heute = dateTime.ToString("yyyy-MM-dd");
            string Startzeit = dateTime.ToString("HH:mm:ss");

            SQLite.insert_table(heute, Startzeit);
        }

        public static decimal Abmelden(DateTime dateTime, bool Außerhalb, bool Rechnerisch, string Bemerkung, bool Pause)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now; }

            string heute = dateTime.ToString("yyyy-MM-dd");

            DateTime Startzeit = Convert.ToDateTime(heute + " " + SQLite.select_table(heute));
            TimeSpan Differenz = dateTime - Startzeit;

            decimal Differenz_dezimal = Convert.ToDecimal(Math.Round(Differenz.TotalHours, 2));
            string Ende_Gelände = dateTime.ToString("HH:mm:ss");
            string Wochentag = dateTime.ToString("dddd");
            decimal Ueberzeit = 0;
            decimal Pausenzeit = 0;

            if (Pause) { Pausenzeit = Convert.ToDecimal(0.5); }

            if (!Außerhalb)
            {
                if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(8 + Pausenzeit);
                else if (Wochentag == "Freitag")
                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(5 + Pausenzeit);
                else if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(0 + Pausenzeit);
            }
            else
                Ueberzeit = Differenz_dezimal - 0;

            if (!Rechnerisch)
                SQLite.update_table(heute, Ende_Gelände, Differenz_dezimal, Ueberzeit, Bemerkung);

            return Ueberzeit;
        }
    }
}
