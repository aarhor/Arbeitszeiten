using Arbeitszeiten.Klassen;
using Microsoft.Data.Sqlite;
using System.Data;

namespace Arbeitszeiten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string firstArgument = CommandLineArguments.Args[0];

        private void btn_Speichern_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string heute = dateTime.ToString("yyyy-MM-dd");
            string Startzeit = dateTime.ToString("HH:mm:ss");

            SQLite.insert_table(heute, Startzeit);

            txtBox_Start.Text = dateTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //heute ende Diff Ueberzeit
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

            lbl_Differenz.Text = Differenz_dezimal.ToString("#.00");
            txtBox_Ende.Text = dateTime.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einstellungen Form_Einstellungen = new Einstellungen();
            Form_Einstellungen.ShowDialog();
        }
    }
}