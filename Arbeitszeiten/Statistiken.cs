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
            dataGridView1.Rows.Add("Alle Tage");

            string Monatszahl = Monate[Array.IndexOf(Monate, domainUpDown1.Text) + 1].ToString();
            string Jahr = domainUpDown2.Text;
            List<string> list = SQLite.select_Tage_stats(Monatszahl, Jahr);

            foreach (DateTime dateTime in from string s in list
                                          let dateTime = Convert.ToDateTime(s)
                                          select dateTime)
            {
                dataGridView1.Rows.Add(dateTime.ToString("dd.MM.yyyy"));
            }
        }

        public void Tag_auswählen(DateTime Tag)
        {
            string Tag_conv = Tag.ToString("yyyy-MM-dd");
            label2.Text = Tag_conv;
            string SQL_Befehl = "select * from Zeiten where Datum = '" + Tag_conv + "'";
        }

        private void Statistiken_Load(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            Tage_abfragen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tage_abfragen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string Tag = dataGridView1.Rows[index: dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Tag_auswählen(Convert.ToDateTime(Tag));
            }
        }
    }
}