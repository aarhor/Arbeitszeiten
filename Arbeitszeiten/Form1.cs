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

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = "Differenz:  " + Differenz_dezimal.ToString("#0.00") + " Mehrstunden"; }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = "Differenz:  " + Differenz_dezimal.ToString("#0.00") + " Minderstunden"; }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Differenz:  Punktlandung!"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkBox_Manuell.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(txtBox_Start.Text)); }
            else
            {
                DateTime dateTime = DateTime.Now;
                Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue));
                txtBox_Start.Text = dateTime.ToString();
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
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBox_Pause.Checked)
                Pause = true;
            else
                Pause = false;
        }
    }
}