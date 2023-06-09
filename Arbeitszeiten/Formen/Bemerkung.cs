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

            if (string.IsNullOrEmpty(Bemerkung))
                Bemerkung = "null";

            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, false, Bemerkung, true);
            MessageBox.Show(new Form { TopMost = true }, "Das Ende wurde erfolgreich eingetragen.");
            Application.Exit();
        }
    }
}
