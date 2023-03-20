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

        private void Berechnen()
        {
            decimal Differenz_dezimal;
            bool Rechnerisch = chkBox_Rechnerisch.Checked;
            string Bemerkung = "null";

            if (txtBox_Bemerkung.TextLength >= 1)
                Bemerkung = txtBox_Bemerkung.Text;

            if (chkBox_Außerhalb.Checked)
            {
                if (chkBox_Manuell.Checked) { Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(txtBox_Ende.Text), true, Rechnerisch, Bemerkung, Pause); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), true, Rechnerisch, Bemerkung, Pause);

                    txtBox_Ende.Text = dateTime.ToString();
                }
            }
            else
            {
                if (chkBox_Manuell.Checked) { Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(txtBox_Ende.Text), false, Rechnerisch, Bemerkung, Pause); }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue), false, Rechnerisch, Bemerkung, Pause);

                    txtBox_Ende.Text = dateTime.ToString();
                }
            }

            if (Differenz_dezimal >= 10)
            {
                MessageBox.Show("Die Arbeitszeit beträgt über 10 Stunden!! Sieh zu das du Land gewinnst und nicht mehr arbeitest!!");
            }

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Mehrstunden", Differenz_dezimal.ToString("#0.00")); }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = string.Format("Differenz:    {0} Minderstunden", Differenz_dezimal.ToString("#0.00")); }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Differenz:     Punktlandung!"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
            double abzug = 0;

            if (Zeit_abziehen)
                abzug = (Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60) * (-1);

            if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(txtBox_Start.Text), abzug); }
            else
            {
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddMinutes(Convert.ToDouble(abzug));
                Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue), abzug);
                txtBox_Start.Text = dateTime.ToString();
                dateTime = dateTime.AddHours(8).AddMinutes(30);
                lbl_Endzeit.Text = string.Format("Ende:    {0}", dateTime.ToString());
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
                txtBox_Start.ReadOnly = false;
                txtBox_Start.PlaceholderText = "05.11.1998 00:00:01";

                txtBox_Ende.ReadOnly = false;
                txtBox_Ende.PlaceholderText = "05.11.1998 00:00:01";
            }
            else
            {
                txtBox_Start.ReadOnly = true;
                txtBox_Start.PlaceholderText = string.Empty;


                txtBox_Ende.ReadOnly = true;
                txtBox_Ende.PlaceholderText = string.Empty;
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
                txtBox_Start.Text = startzeit.ToString();

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
            Tätigkeiten Form_Taetigkeiten = new Tätigkeiten();
            Form_Taetigkeiten.ShowDialog();
        }
    }
}