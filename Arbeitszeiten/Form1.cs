using Arbeitszeiten.Klassen;

namespace Arbeitszeiten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { Kommandozeile.Anmelden(Convert.ToDateTime(txtBox_Start.Text)); }
            else
            {
                DateTime dateTime = DateTime.Now;
                Kommandozeile.Anmelden(Convert.ToDateTime(DateTime.MinValue));
                txtBox_Start.Text = dateTime.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Differenz_dezimal;

            if (checkBox1.Checked) { Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(txtBox_Ende.Text)); }
            else
            {
                DateTime dateTime = DateTime.Now;
                Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(DateTime.MinValue));

                txtBox_Ende.Text = dateTime.ToString();
            }

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = Differenz_dezimal.ToString("#0.00") + " Mehrstunden"; }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = Differenz_dezimal.ToString("#0.00") + " Minderstunden"; }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Punktlandung!"; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einstellungen Form_Einstellungen = new Einstellungen();
            Form_Einstellungen.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
    }
}