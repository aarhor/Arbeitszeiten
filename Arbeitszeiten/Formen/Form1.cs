using Arbeitszeiten.Formen;
using Arbeitszeiten.Klassen;

namespace Arbeitszeiten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Pause = true;
        int _id = 0;

        private void Berechnen()
        {
            decimal Differenz_dezimal;
            bool Rechnerisch = chkBox_Rechnerisch.Checked;
            string Bemerkung = "null";

            if (txtBox_Bemerkung.TextLength >= 1)
                Bemerkung = txtBox_Bemerkung.Text;

            if (chkBox_Außerhalb.Checked)
            {
                if (chkBox_Manuell.Checked) { Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(mskdtxtBox_Ende.Text), Rechnerisch, Bemerkung, Pause, _id); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), Rechnerisch, Bemerkung, Pause, _id);

                    mskdtxtBox_Ende.Text = dateTime.ToString();
                }
            }
            else
            {
                if (chkBox_Manuell.Checked)
                {
                    try
                    {
                        Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(mskdtxtBox_Ende.Text), Rechnerisch, Bemerkung, Pause, _id);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Es wurde ein Fehler festegestellt:\n" + ex.Message.ToString());
                        throw;
                    }
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), Rechnerisch, Bemerkung, Pause, _id);

                    mskdtxtBox_Ende.Text = dateTime.ToString();
                }
            }

            if (Differenz_dezimal >= 10)
            {
                MessageBox.Show(new Form { TopMost = true }, "Die Arbeitszeit beträgt über 10 Stunden!! Sieh zu das du Land gewinnst und nicht mehr arbeitest!!");
            }

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Mehrstunden", Differenz_dezimal); }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Minderstunden", Differenz_dezimal); }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Differenz:     Punktlandung!"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
            double abzug = 0;
            List<string> list = SQLite.Auflistung_Einträge("select _id, Datum, Start, Ende from Zeiten order by _id DESC LIMIT 1", 4);
            List<string> Optionen = [
                        "Ausserhalb",
                        chkBox_Außerhalb.Checked.ToString(),
                        "Bool",
                        "Workshop",
                        chkBox_Workshop.Checked.ToString(),
                        "Bool"
            ];

            if (Zeit_abziehen)
                abzug = (Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60) * (-1);

            if (list.Count > 0)
            {
                string Datum = Convert.ToDateTime(list[1]).ToString("d");
                string Beginn = Convert.ToDateTime(list[2]).ToString("t");
                string Datum_id = Diverses.Datum_Start_Ende(list[0], Datum, Beginn, "");

                if (string.IsNullOrEmpty(list[3]))
                {
                    MessageBox.Show("Der letzte Eintrag wurde noch nicht angeschlossen. Über die Statistiken muss erst ein Ende eingetragen werden damit ein neuer Eintrag angelegt werden kann.\n" + Datum_id, "Ende fehlt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(mskdtxtBox_Start.Text), abzug, Optionen); }
                    else
                    {
                        DateTime dateTime = DateTime.Now;
                        dateTime = dateTime.AddMinutes(Convert.ToDouble(abzug));
                        Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue), abzug, Optionen);
                        mskdtxtBox_Start.Text = dateTime.ToString();
                        dateTime = dateTime.AddHours(8).AddMinutes(30);
                        lbl_Endzeit.Text = string.Format("Ende:    {0}", dateTime.ToString());
                    }

                    btn_Ende.Enabled = true;
                    btn_Start.Enabled = false;
                }
            }
            else
            {
                if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(mskdtxtBox_Start.Text), abzug, Optionen); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.AddMinutes(Convert.ToDouble(abzug));
                    Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue), abzug, Optionen);
                    mskdtxtBox_Start.Text = dateTime.ToString();
                    dateTime = dateTime.AddHours(8).AddMinutes(30);
                    lbl_Endzeit.Text = string.Format("Ende:    {0}", dateTime.ToString());
                }

                btn_Ende.Enabled = true;
                btn_Start.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Das Programm muss einmal neugestartet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Berechnen();

                if (!chkBox_Rechnerisch.Checked)
                {
                    btn_Ende.Enabled = false;
                    btn_Start.Enabled = true;
                    chkBox_Workshop.Enabled = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Manuell.Checked)
            {
                mskdtxtBox_Start.ReadOnly = false;

                mskdtxtBox_Ende.ReadOnly = false;
            }
            else
            {
                mskdtxtBox_Start.ReadOnly = true;

                mskdtxtBox_Ende.ReadOnly = true;
            }
        }

        private void chkBox_Rechnerisch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Rechnerisch.Checked)
                lbl_Meldung.Visible = true;
            else
                lbl_Meldung.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            List<string> list = SQLite.Auflistung_Einträge("select _id, Datum, Start, Ende from Zeiten order by _id DESC LIMIT 1", 4);
            string Wochentag = dateTime.ToString("dddd");

            if (list.Count > 0 && !string.IsNullOrEmpty(list[0]) && string.IsNullOrEmpty(list[3]))
            {

                if (Wochentag == "Freitag")
                    chkBox_Pause.Checked = false;
                else
                    chkBox_Pause.Checked = true;

                DateTime startzeit = SQLite.Startzeit_heute(Convert.ToDateTime(list[1]).ToString("yyyy-MM-dd"));
                list.Clear();
                list = SQLite.Auflistung_Einträge("select _id, Metadaten from Zeiten where Datum = '" + startzeit.ToString("yyyy-MM-dd") + "' and Ende ISNULL", 2);
                mskdtxtBox_Start.Text = startzeit.ToString();

                _id = int.Parse(list[0]);
                List<string> Metadaten = Klassen.Metadaten.Auslesen(list[1]);

                DateTime ende_Gelaende = DateTime.Now;
                if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                    ende_Gelaende = startzeit.AddHours(8).AddMinutes(30);
                else if (Wochentag == "Freitag")
                    ende_Gelaende = startzeit.AddHours(5);

                chkBox_Außerhalb.Checked = Convert.ToBoolean(Metadaten[1]);
                chkBox_Workshop.Checked = Convert.ToBoolean(Metadaten[3]);
                chkBox_Workshop.Enabled = false;

                if (chkBox_Workshop.Checked)
                    txtBox_Bemerkung.Text = "Thema: ";

                lbl_Endzeit.Text = string.Format("Ende:    {0}", ende_Gelaende.ToString());

                btn_Ende.Enabled = true;
                btn_Start.Enabled = false;
            }
            else
            {
                if (Wochentag == "Samstag" || Wochentag == "Sonntag")
                {
                    chkBox_Außerhalb.Checked = true;
                    chkBox_Pause.Checked = false;
                }
                else if ((Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag") && (dateTime.Hour >= 15 || dateTime.Hour <= 6))
                    chkBox_Außerhalb.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBox_Pause.Checked)
                Pause = true;
            else
                Pause = false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Tätigkeiten Form_Taetigkeiten = new();
            Form_Taetigkeiten.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Statistiken Form_statistiken = new();
            Form_statistiken.ShowDialog();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Einstellungen Form_Einstellungen = new();
            Form_Einstellungen.ShowDialog();
        }
    }
}