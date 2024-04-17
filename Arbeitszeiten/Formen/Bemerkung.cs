using Arbeitszeiten.Klassen;

namespace Arbeitszeiten.Formen
{
    public partial class Bemerkung : Form
    {
        public Bemerkung(int _id, bool Ausserhalb)
        {
            InitializeComponent();
            id = _id;
            Außerhalb = Ausserhalb;
        }

        int id;
        bool Außerhalb = false;

        private void Eintragen()
        {
            string Bemerkung = txtBox_Bemerkung.Text;
            DateTime dateTime = DateTime.Now;
            DateTime Startzeit = SQLite.Startzeit_heute(dateTime.ToString("yyyy-MM-dd"));

            if (string.IsNullOrEmpty(Bemerkung))
                Bemerkung = "null";

            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, Bemerkung, true, id);

            string Endzeit = SQLite.Bestimmter_wert("select Ende from Zeiten where _id = " + id.ToString());

            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
                    "Datum:\t{0}\n" +
                    "Beginn:\t{1}\n" +
                    "Ende:\t{2}", Startzeit.ToString("d"), Startzeit.ToString("T"), dateTime.ToString("T")));
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eintragen();
        }

        private void txtBox_Bemerkung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Eintragen();
        }
    }
}
