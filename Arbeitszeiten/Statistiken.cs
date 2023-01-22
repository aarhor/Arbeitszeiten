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

        private void Statistiken_Load(object sender, EventArgs e)
        {
            List<string> list = new();
            list = SQLite.select_Tage_stats();

            foreach (string s in list)
            {
                DateTime dateTime= Convert.ToDateTime(s);
                dataGridView1.Rows.Add(dateTime.ToString("dd.MM.yyyy"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
