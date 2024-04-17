namespace Arbeitszeiten.Klassen
{
    internal class Kommandozeile
    {
        public static void Anmelden(DateTime dateTime, double abzug_minuten, List<string> Optionen)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now.AddMinutes(abzug_minuten); }

            string heute = dateTime.ToString("yyyy-MM-dd");
            string Startzeit = dateTime.ToString("HH:mm:ss");

            SQLite.Insert_table(heute, Startzeit, Optionen);
        }

        public static decimal Abmelden(DateTime dateTime, bool Rechnerisch, string Bemerkung, bool Pause, int _id, bool Bearbeiten = false)
        {
            if (dateTime == DateTime.MinValue) { dateTime = DateTime.Now; }

            string heute = dateTime.ToString("yyyy-MM-dd");
            string Metadaten = SQLite.Bestimmter_wert(string.Format("select Metadaten from Zeiten where _id = {0}", _id));

            bool Außerhalb_neu = Convert.ToBoolean(Klassen.Metadaten.Auslesen(Metadaten, false, "Ausserhalb")[1]);
            bool Workshop = Convert.ToBoolean(Klassen.Metadaten.Auslesen(Metadaten, false, "Workshop")[1]);


            DateTime Startzeit = Convert.ToDateTime(heute + " " + SQLite.Select_table(_id.ToString()));
            TimeSpan Start_Ende_Differenz = dateTime - Startzeit;

            decimal Start_Ende_Differenz_Dezimal = Convert.ToDecimal(Math.Round(Start_Ende_Differenz.TotalHours, 2));
            string Ende_Gelände = dateTime.ToString("HH:mm:ss");
            string Wochentag = dateTime.ToString("dddd");
            decimal Mehr_Minder_Stunden = 0;
            decimal Pausenzeit = 0;

            if (!Außerhalb_neu)
            {
                if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                {
                    if (Pause) { Pausenzeit = Convert.ToDecimal(0.5); }

                    Mehr_Minder_Stunden = Start_Ende_Differenz_Dezimal - Convert.ToDecimal(8 + Pausenzeit);
                }
                else if (Wochentag == "Freitag")
                {
                    Mehr_Minder_Stunden = Start_Ende_Differenz_Dezimal - Convert.ToDecimal(5 + Pausenzeit);
                }
                else if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                {
                    if (Pause) { Pausenzeit = Convert.ToDecimal(0.5); }

                    Mehr_Minder_Stunden = Start_Ende_Differenz_Dezimal - Convert.ToDecimal(5 + Pausenzeit);
                }
            }
            else
                Mehr_Minder_Stunden = Start_Ende_Differenz_Dezimal - 0;

            if (((Start_Ende_Differenz_Dezimal > 0 && Start_Ende_Differenz_Dezimal <= (2 / 60)) || (Start_Ende_Differenz_Dezimal < 0 && Start_Ende_Differenz_Dezimal >= (2 / 60))) && !Außerhalb_neu)
                Mehr_Minder_Stunden = 0;  // 2 Minuten drüber und drunter wird noch als 0 gewertet

            if (Workshop)
                Mehr_Minder_Stunden = 0;

            if (!Rechnerisch)
            {
                bool Ergebnis = SQLite.Update_table(Ende_Gelände, Start_Ende_Differenz_Dezimal, Mehr_Minder_Stunden, Bemerkung, _id);

                if (Ergebnis && Bearbeiten)
                    MessageBox.Show("Das Bearbeiten war erfolgreich und die Daten wurden angepasst");
            }

            if (Start_Ende_Differenz_Dezimal >= 10 && Bearbeiten == false)
            {
                MessageBox.Show(new Form { TopMost = true }, "Die Arbeitszeit beträgt mehr als 10 Stunden!!\nSieh zu das du Land gewinnst und nicht mehr arbeitest!!");
            }

            return Mehr_Minder_Stunden;
        }
    }
}
