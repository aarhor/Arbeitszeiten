using Arbeitszeiten.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitszeiten.Formen
{
    public partial class Bearbeiten : Form
    {
        public Bearbeiten(string _id)
        {
            InitializeComponent();
            Eintragen(_id: _id);
        }

        void Eintragen(string _id)
        {
            txtBox_ID.Text = _id;

            string SQL_Befehl = string.Format("select Datum, Start, Ende, Bemerkung from Zeiten where _id = '{0}'", _id);
            List<string> list_Daten = SQLite.Auflistung_Einträge(SQL_Befehl, 4);

            mskdtxtBox_Datum.Text = Convert.ToDateTime(list_Daten[0]).ToString("dd.MM.yyyy");
            mskdtxtBox_Start.Text = Convert.ToDateTime(list_Daten[1]).ToString("HH:mm:ss");

            if (!string.IsNullOrEmpty(list_Daten[2]))
            {
                mskdtxtBox_Ende.Text = Convert.ToDateTime(list_Daten[2]).ToString("HH:mm:ss");
                richTextBox_Bemerkung.Text = list_Daten[3];
            }
        }

        private void btn_Jetzt_Ende_Click(object sender, EventArgs e)
        {
            mskdtxtBox_Ende.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Jetzt_Start_Click(object sender, EventArgs e)
        {
            mskdtxtBox_Start.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Heute_Datum_Click(object sender, EventArgs e)
        {
            mskdtxtBox_Datum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            var Null_wenn_leer = (string s) => s.Length == 0 ? "null" : string.Format("'{0}'", s);
            string id, Startzeit, Endzeit, Datum, Bemerkung, SQL_Befehl = "";
            DateTime dateTime = Convert.ToDateTime(mskdtxtBox_Datum.Text);

            id = txtBox_ID.Text;
            Datum = Null_wenn_leer(dateTime.ToString("yyyy-MM-dd"));
            Startzeit = Null_wenn_leer(mskdtxtBox_Start.Text);
            Endzeit = Null_wenn_leer(mskdtxtBox_Ende.Text);
            Bemerkung = Null_wenn_leer(richTextBox_Bemerkung.Text);

            if (Bemerkung != "null")    //Ende wurde bearbeitet
            {
                DateTime Beginn = Convert.ToDateTime(Datum + " " + SQLite.Bestimmter_wert(string.Format("select start from Zeiten where _id = {0}", id)));
                TimeSpan Differenz = dateTime - Beginn;
                decimal Differenz_dezimal = Kommandozeile.Abmelden(Convert.ToDateTime(mskdtxtBox_Ende.Text), false, true, Bemerkung, true, true);
            }
            else
                SQL_Befehl = string.Format("update Zeiten set Datum = {0}, Start = {1}, Ende = {2}, Bemerkung = {3} where _id = '{4}'", Datum, Startzeit, Endzeit, Bemerkung, id);

            //SQLite.Nur_Befehl(SQL_Befehl);
        }
    }
}
