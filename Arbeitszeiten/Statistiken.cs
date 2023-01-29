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

namespace Arbeitszeiten
{
    public partial class Statistiken : Form
    {
        public Statistiken()
        {
            InitializeComponent();
        }

        string[] Monate = { "Januar", "01", "Februar", "02", "März", "03", "April", "04", "Mai", "05", "Juni", "06", "Juli", "07", "August", "08", "September", "09", "Oktober", "10", "November", "11", "Dezember", "12" };

        public void Tage_abfragen()
        {
            dataGridView1.Rows.Clear();
            string Monatszahl = Monate[Array.IndexOf(Monate, domainUpDown1.Text) + 1].ToString();
            List<string> list = SQLite.select_Tage_stats(Monatszahl, "2023");

            foreach (string s in list)
            {
                DateTime dateTime = Convert.ToDateTime(s);
                dataGridView1.Rows.Add(dateTime.ToString("dd.MM.yyyy"));
            }
        }

        private void Statistiken_Load(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            Tage_abfragen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tage_abfragen();
        }
    }
}
