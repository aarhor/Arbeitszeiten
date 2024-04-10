namespace Arbeitszeiten.Klassen
{
    internal class Kommandozeile
    {
        public static void Anmelden(DateTime dateTime, double abzug_minuten, bool Ausserhalb)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now.AddMinutes(abzug_minuten); }

            string heute = dateTime.ToString("yyyy-MM-dd");
            string Startzeit = dateTime.ToString("HH:mm:ss");

            SQLite.insert_table(heute, Startzeit, Ausserhalb);
        }

        public static decimal Abmelden(DateTime dateTime, bool Außerhalb, bool Rechnerisch, string Bemerkung, bool Pause, int _id, bool Bearbeiten = false)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now; }

            string heute = dateTime.ToString("yyyy-MM-dd");

            DateTime Startzeit = Convert.ToDateTime(heute + " " + SQLite.select_table(heute, _id.ToString()));
            TimeSpan Differenz = dateTime - Startzeit;

            decimal Differenz_dezimal = Convert.ToDecimal(Math.Round(Differenz.TotalHours, 2));
            string Ende_Gelände = dateTime.ToString("HH:mm:ss");
            string Wochentag = dateTime.ToString("dddd");
            decimal Ueberzeit = 0;
            decimal Pausenzeit = 0;

            if (!Außerhalb)
            {
                if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                {
                    if (Pause) { Pausenzeit = Convert.ToDecimal(0.5); }

                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(8 + Pausenzeit);
                }
                else if (Wochentag == "Freitag")
                {
                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(5 + Pausenzeit);
                }
                else if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                {
                    if (Pause) { Pausenzeit = Convert.ToDecimal(0.5); }

                    Ueberzeit = Differenz_dezimal - Convert.ToDecimal(5 + Pausenzeit);
                }
            }
            else
                Ueberzeit = Differenz_dezimal - 0;

            if (!Rechnerisch)
            {
                bool Ergebnis = SQLite.update_table(heute, Ende_Gelände, Differenz_dezimal, Ueberzeit, Bemerkung, _id);

                if (Ergebnis && Bearbeiten)
                    MessageBox.Show("Das Bearbeiten war erfolgreich und die Daten wurden angepasst");
            }

            if (Differenz_dezimal >= 10 && Bearbeiten == false)
            {
                MessageBox.Show(new Form { TopMost = true }, "Die Arbeitszeit beträgt mehr als 10 Stunden!!\nSieh zu das du Land gewinnst und nicht mehr arbeitest!!");
            }

            return Ueberzeit;
        }
    }
}
