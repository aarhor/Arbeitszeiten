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
        public Bearbeiten()
        {
            InitializeComponent();
        }

        private void btn_Jetzt_Ende_Click(object sender, EventArgs e)
        {
            txtBox_Ende.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Jetzt_Start_Click(object sender, EventArgs e)
        {
            txtBox_Start.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Heute_Datum_Click(object sender, EventArgs e)
        {
            txtBox_Datum.Text = DateTime.Now.ToString("dd.MM.yyyy ");
        }

        private void Bearbeiten_Load(object sender, EventArgs e)
        {
            txtBox_ID.Text = Properties.Settings.Default.ID_Bearbeiten;

            string SQL_Befehl = string.Format("select Datum, Start, Ende, Bemerkung from Zeiten where _id = '{0}'", txtBox_ID.Text);
            List<string> list_Daten = SQLite.Auflistung_Einträge(SQL_Befehl, 4);

            txtBox_Datum.Text = list_Daten[0].Remove(10);
            txtBox_Start.Text = list_Daten[1].Remove(0, 11);

            if (!string.IsNullOrEmpty(list_Daten[2]))
            {
                txtBox_Ende.Text = list_Daten[2].Remove(0, 11);
                richTextBox_Bemerkung.Text = list_Daten[3];
            }
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {

        }
    }
}
