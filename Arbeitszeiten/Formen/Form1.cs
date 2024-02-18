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

            if (chkBox_Au�erhalb.Checked)
            {
                if (chkBox_Manuell.Checked) { Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(mskdtxtBox_Ende.Text), true, Rechnerisch, Bemerkung, Pause, _id); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), true, Rechnerisch, Bemerkung, Pause, _id);

                    mskdtxtBox_Ende.Text = dateTime.ToString();
                }
            }
            else
            {
                if (chkBox_Manuell.Checked)
                {
                    try
                    {
                        Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(mskdtxtBox_Ende.Text), false, Rechnerisch, Bemerkung, Pause, _id);
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
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), false, Rechnerisch, Bemerkung, Pause, _id);

                    mskdtxtBox_Ende.Text = dateTime.ToString();
                }
            }

            if (Differenz_dezimal >= 10)
            {
                MessageBox.Show(new Form { TopMost = true }, "Die Arbeitszeit betr�gt �ber 10 Stunden!! Sieh zu das du Land gewinnst und nicht mehr arbeitest!!");
            }

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Mehrstunden", Differenz_dezimal); }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Minderstunden", Differenz_dezimal); }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Differenz:     Punktlandung!"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
            double abzug = 0;
            List<string> list = SQLite.Auflistung_Eintr�ge("select _id, Datum, Start, Ende from Zeiten order by _id DESC LIMIT 1", 4);
            string Datum = Convert.ToDateTime(list[1]).ToString("d");
            string Beginn = Convert.ToDateTime(list[2]).ToString("t");

            if (Zeit_abziehen)
                abzug = (Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60) * (-1);

            if (list.Count > 0)
            {
                string Datum_id = string.Format("ID:\t{0}\n" +
                                              "Datum:\t{1}\n" +
                                              "Beginn:\t{2}", list[0], Datum, Beginn);

                if (string.IsNullOrEmpty(list[3]))
                {
                    MessageBox.Show("Der letzte Eintrag wurde noch nicht angeschlossen. �ber die Statistiken muss erst ein Ende eingetragen werden damit ein neuer Eintrag angelegt werden kann.\n\n" + Datum_id, "Ende fehlt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(mskdtxtBox_Start.Text), abzug); }
                    else
                    {
                        DateTime dateTime = DateTime.Now;
                        dateTime = dateTime.AddMinutes(Convert.ToDouble(abzug));
                        Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue), abzug);
                        mskdtxtBox_Start.Text = dateTime.ToString();
                        dateTime = dateTime.AddHours(8).AddMinutes(30);
                        lbl_Endzeit.Text = string.Format("Ende:    {0}", dateTime.ToString());
                    }
                }
            }
            else
            {
                if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(mskdtxtBox_Start.Text), abzug); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.AddMinutes(Convert.ToDouble(abzug));
                    Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue), abzug);
                    mskdtxtBox_Start.Text = dateTime.ToString();
                    dateTime = dateTime.AddHours(8).AddMinutes(30);
                    lbl_Endzeit.Text = string.Format("Ende:    {0}", dateTime.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Berechnen();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einstellungen Form_Einstellungen = new Einstellungen();
            Form_Einstellungen.ShowDialog();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Statistiken Form_statistiken = new Statistiken();
            Form_statistiken.ShowDialog();
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
            string Wochentag = dateTime.ToString("dddd");

            if (Wochentag == "Freitag")
                chkBox_Pause.Checked = false;
            else
                chkBox_Pause.Checked = true;

            DateTime startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd"));

            if (startzeit.ToString() != DateTime.MinValue.ToString())
            {
                mskdtxtBox_Start.Text = startzeit.ToString();
                _id = int.Parse(SQLite.Bestimmter_wert("select _id from Zeiten where Datum = '" + startzeit.ToString("yyyy-MM-dd") + "' and Ende ISNULL"));

                if (Wochentag == "Montag" || Wochentag == "Dienstag" || Wochentag == "Mittwoch" || Wochentag == "Donnerstag")
                    startzeit = startzeit.AddHours(8).AddMinutes(30);
                else if (Wochentag == "Freitag")
                    startzeit = startzeit.AddHours(5);

                lbl_Endzeit.Text = string.Format("Ende:    {0}", startzeit.ToString());
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBox_Pause.Checked)
                Pause = true;
            else
                Pause = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            T�tigkeiten Form_Taetigkeiten = new T�tigkeiten();
            Form_Taetigkeiten.ShowDialog();
        }
    }
}