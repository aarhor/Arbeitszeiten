using Arbeitszeiten.Klassen;
using System.Data;

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
            string SQL_Befehl = string.Format("select Datum, _id from Zeiten where Datum like '{0}-{1}-%' group by Datum", Jahr, Monatszahl);
            List<string> list = SQLite.Auflistung_Einträge(SQL_Befehl, 2);

            for (int i = 0; i < list.Count(); i = i + 2)
            {
                dataGridView1.Rows.Add(list[i], list[i + 1]);
            }
        }

        public void Tag_auswählen(DateTime Tag)
        {
            string Tag_conv = Tag.ToString("yyyy-MM-dd");
            string SQL_Befehl = string.Format("select Start, Ende, Differenz, MehrMinder_Stunden, Bemerkung from Zeiten where Datum = '{0}'", Tag_conv);
            //List<string> list_Daten = new;
            //list_Daten.Clear();
            //list_Daten = SQLite.Auflistung_Einträge(SQL_Befehl, 5);
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
                if (Tag != "Alle Tage")
                    Tag_auswählen(Convert.ToDateTime(Tag));
            }
        }
    }
}