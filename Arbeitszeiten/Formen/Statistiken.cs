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

        private readonly string[] Monate = ["Januar", "01", "Februar", "02", "März", "03", "April", "04", "Mai", "05", "Juni", "06", "Juli", "07", "August", "08", "September", "09", "Oktober", "10", "November", "11", "Dezember", "12"];
        string id, Monatszahl, Jahr = string.Empty;
        int Arbeitstage_Monat = 0;

        public void Tage_abfragen()
        {
            Arbeitstage_Monat = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Alle Tage", "0");

            Monatszahl = Monate[Array.IndexOf(Monate, domainUpDown_Monat.Text) + 1].ToString();
            Jahr = domainUpDown_Jahr.Text;
            string SQL_Befehl = string.Format("select Datum, _id from Zeiten where Datum like '{0}-{1}-%' group by Datum", Jahr, Monatszahl);
            List<string> list = SQLite.Auflistung_Einträge(SQL_Befehl, 2);

            for (int i = 0; i < list.Count(); i = i + 2)
            {
                DateTime tag = Convert.ToDateTime(list[i]);
                dataGridView1.Rows.Add(tag.ToString("dd.MM.yyyy"), list[i + 1]);
                Arbeitstage_Monat++;
            }
        }

        public void Graphen_zeichnen()
        {
            BearbeitenToolStripMenuItem.Enabled = false;
            löschenToolStripMenuItem.Enabled = false;
            lbl_Datum.Text = string.Format("Datum: {0}", "---");
            lbl_Startzeit.Text = string.Format("Startzeit: {0}", "---");
            lbl_Endzeit.Text = string.Format("Endzeit: {0}", "---");
            lbl_Arbeitszeit.Text = string.Format("Differenz: {0}", "---");
            lbl_Ueberstunden.Text = string.Format("Überstunden: {0}", "---");
            richTextBox1.Text = string.Empty;

            try
            {
                double Ueberstunden_Monat = Convert.ToDouble(SQLite.Bestimmter_wert(string.Format("select sum(MehrMinder_Stunden) as Überstunden from Zeiten where Datum like '{0}-{1}-%'", Jahr, Monatszahl)));
                double GesamtStunden_Monat = Convert.ToDouble(SQLite.Bestimmter_wert(string.Format("select sum(Differenz) as Gesamt from Zeiten where Datum like '{0}-{1}-%'", Jahr, Monatszahl)));
                lbl_Startzeit.Text = string.Format("Startzeit: {0}", "---");
                lbl_Endzeit.Text = string.Format("Endzeit: {0}", "---");
                lbl_Arbeitszeit.Text = string.Format("Differenz: {0} Stunden an {1} Arbeitstagen", Math.Round(GesamtStunden_Monat, 2), Arbeitstage_Monat);
                lbl_Ueberstunden.Text = string.Format("Überstunden: {0} Stunden", Math.Round(Ueberstunden_Monat, 2));
                richTextBox1.Text = string.Empty;
            }
            catch (FormatException)
            {
                lbl_Startzeit.Text = string.Format("Startzeit: {0}", "---");
                lbl_Endzeit.Text = string.Format("Endzeit: {0}", "---");
                lbl_Arbeitszeit.Text = string.Format("Differenz: {0}", "---");
                lbl_Ueberstunden.Text = string.Format("Überstunden: {0}", "---");
                richTextBox1.Text = "## Es gibt aktuell noch nicht genügend Daten um die Zeiten zu berechnen ##";
            }
        }

        public void Tag_auswählen(string _id, string Tag)
        {
            if (Tag != "Alle Tage")
            {
                try
                {
                    DateTime dateTime = Convert.ToDateTime(Tag);
                    string SQL_Befehl = string.Format("select Start, Ende, Differenz, MehrMinder_Stunden, Bemerkung from Zeiten where _id = '{0}'", _id);
                    List<string> list_Daten = SQLite.Auflistung_Einträge(SQL_Befehl, 5);

                    lbl_Datum.Text = string.Format("Datum: {0}", dateTime.ToString("dddd, dd.MM.yyyy"));
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
                    richTextBox1.Text = "## Für diesen Tag gibt es noch keine Endzeit ##";
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
            Graphen_zeichnen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tage_abfragen();
            Graphen_zeichnen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Startzeit.Text = string.Format("Startzeit: ");
            lbl_Endzeit.Text = string.Format("Endzeit: ");
            lbl_Arbeitszeit.Text = string.Format("Differenz: ");
            lbl_Ueberstunden.Text = string.Format("Überstunden: ");
            richTextBox1.Text = string.Empty;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string Tag = string.Empty;
                Tag = dataGridView1.Rows[index: dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (Tag != "Alle Tage")
                {
                    BearbeitenToolStripMenuItem.Enabled = true;
                    löschenToolStripMenuItem.Enabled = true;
                    id = dataGridView1.Rows[index: dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    Tag_auswählen(id, Tag);
                }
                else
                {
                    BearbeitenToolStripMenuItem.Enabled = false;
                    löschenToolStripMenuItem.Enabled = false;
                    Graphen_zeichnen();
                }
            }
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SQLite.Nur_Befehl("delete from Zeiten where _id = " + id))
            {
                id = string.Empty;
                MessageBox.Show("Der Eintrag wurde gelöscht");
                Tage_abfragen();
            }
        }

        private void BearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bearbeiten Form_Bearbeiten = new(id);
            Form_Bearbeiten.ShowDialog();
        }

        private void domainUpDown_Monat_SelectedItemChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Tage_abfragen();
                Graphen_zeichnen();
            }
        }

        private void jahresüberblickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Jahr = domainUpDown_Jahr.Text;
            string SQL_Befehl = string.Format("select round(sum(MehrMinder_Stunden), 2), round(sum(Differenz), 2), count(_id) as Anzahl_Tage from Zeiten where Datum like '{0}-%-%'", Jahr);
            List<string> Zeiten = SQLite.Auflistung_Einträge(SQL_Befehl, 3);
            string Ueberstunden = Zeiten[0];
            string Arbeitszeit = Zeiten[1];
            string Arbeitstage = string.Format("{0} Arbeitstagen", Zeiten[2]);

            if (Arbeitstage == "1 Arbeitstagen")
                Arbeitstage = string.Format("{0} Arbeitstag", Zeiten[2]);

            lbl_Startzeit.Text = string.Format("Startzeit: ---");
            lbl_Endzeit.Text = string.Format("Endzeit: ---");
            lbl_Arbeitszeit.Text = string.Format("Differenz: {0} Stunden an {1}", Arbeitszeit, Arbeitstage);
            lbl_Ueberstunden.Text = string.Format("Überstunden: {0} Stunden an {1}", Ueberstunden, Arbeitstage);
        }
    }
}