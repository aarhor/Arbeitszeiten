using Arbeitszeiten.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitszeiten.Formen
{
    public partial class Bemerkung : Form
    {
        public Bemerkung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Bemerkung = txtBox_Bemerkung.Text;
            DateTime dateTime = DateTime.Now;
            string Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd")).ToString();

            if (string.IsNullOrEmpty(Bemerkung))
                Bemerkung = "null";

            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, false, Bemerkung, true);

            string Endzeit = SQLite.Bestimmter_wert("select Ende from Zeiten order by _id DESC LIMIT 1");

            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
            "Beginn: {0}\n" +
            "Ende: {1}", Startzeit, Endzeit));
            Application.Exit();
        }
    }
}
