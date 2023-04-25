using Arbeitszeiten.Formen;
using Arbeitszeiten.Klassen;

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

            string Monatszahl = Monate[Array.IndexOf(Monate, domainUpDown_Monat.Text) + 1].ToString();
            string Jahr = domainUpDown_Jahr.Text;
            string SQL_Befehl = string.Format("select Datum, _id from Zeiten where Datum like '{0}-{1}-%' group by Datum", Jahr, Monatszahl);
            List<string> list = SQLite.Auflistung_Einträge(SQL_Befehl, 2);

            for (int i = 0; i < list.Count(); i = i + 2)
            {
                DateTime tag = Convert.ToDateTime(list[i]);
                dataGridView1.Rows.Add(tag.ToString("dd.MM.yyyy"), list[i + 1]);
            }
        }

        public void Graphen_zeichnen()
        {
            lbl_Startzeit.Text = string.Format("Startzeit: {0}", "---");
            lbl_Endzeit.Text = string.Format("Endzeit: {0}", "---");
            lbl_Arbeitszeit.Text = string.Format("Differenz: {0}", "---");
            lbl_Ueberstunden.Text = string.Format("Überstunden: {0}", "---");
            richTextBox1.Text = string.Empty;

        }

        public void Tag_auswählen(string _id, string Tag)
        {
            if (Tag != "Alle Tage")
            {
                try
                {
                    string SQL_Befehl = string.Format("select Start, Ende, Differenz, MehrMinder_Stunden, Bemerkung from Zeiten where _id = '{0}'", _id);
                    List<string> list_Daten = SQLite.Auflistung_Einträge(SQL_Befehl, 5);
                    lbl_Startzeit.Text = string.Format("Startzeit: {0}", list_Daten[0].Substring(list_Daten[0].Length - 8, 8));

                    if (!string.IsNullOrEmpty(list_Daten[1]))
                    {
                        lbl_Endzeit.Text = string.Format("Endzeit: {0}", list_Daten[1].Substring(list_Daten[1].Length - 8, 8));
                        lbl_Arbeitszeit.Text = string.Format("Differenz: {0} Stunden", list_Daten[2]);
                        lbl_Ueberstunden.Text = string.Format("Überstunden: {0} Stunden", list_Daten[3]);
                        richTextBox1.Text = list_Daten[4];
                    }
                    else
                        richTextBox1.Text = "## Es gibt noch keine Endzeit für diesen Tag ##";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Statistiken_Load(object sender, EventArgs e)
        {
            DateTime heute = DateTime.Now;
            string Monat = heute.ToString("MMMM");
            string Jahr = heute.ToString("yyyy");

            domainUpDown_Monat.SelectedItem = Monat;
            domainUpDown_Jahr.SelectedItem = Jahr;
            Tage_abfragen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tage_abfragen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Startzeit.Text = string.Format("Startzeit: ");
            lbl_Endzeit.Text = string.Format("Endzeit: ");
            lbl_Arbeitszeit.Text = string.Format("Differenz: ");
            lbl_Ueberstunden.Text = string.Format("Überstunden: ");
            richTextBox1.Text = string.Empty;

            string Tag, id = string.Empty;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Tag = dataGridView1.Rows[index: dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (Tag != "Alle Tage")
                {
                    weiteresToolStripMenuItem.Enabled = true;
                    id = dataGridView1.Rows[index: dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    Tag_auswählen(id, Tag);
                }
                else
                {
                    weiteresToolStripMenuItem.Enabled = false;
                    Graphen_zeichnen();
                }
            }
        }

        private void weiteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bearbeiten Form_Bearbeiten = new();
            Form_Bearbeiten.ShowDialog();
        }
    }
}