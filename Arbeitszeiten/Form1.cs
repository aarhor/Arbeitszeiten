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
            DateTime dateTime = DateTime.Now;
            Kommandozeile.Anmelden();

            txtBox_Start.Text = dateTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            decimal Differenz_dezimal = Kommandozeile.Abmelden();

            if (Differenz_dezimal > 0) { lbl_Differenz.Text = Differenz_dezimal.ToString("#0.00") + " Mehrstunden"; }
            else if (Differenz_dezimal < 0) { lbl_Differenz.Text = Differenz_dezimal.ToString("#0.00") + " Minderstunden"; }
            else if (Differenz_dezimal == 0) { lbl_Differenz.Text = "Punktlandung!"; }

            txtBox_Ende.Text = dateTime.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einstellungen Form_Einstellungen = new Einstellungen();
            Form_Einstellungen.ShowDialog();
        }
    }
}