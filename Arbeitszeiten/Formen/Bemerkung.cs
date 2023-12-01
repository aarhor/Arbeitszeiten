using Arbeitszeiten.Klassen;

namespace Arbeitszeiten.Formen
{
    public partial class Bemerkung : Form
    {
        public Bemerkung(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        int id;

        private void button1_Click(object sender, EventArgs e)
        {
            string Bemerkung = txtBox_Bemerkung.Text;
            DateTime dateTime = DateTime.Now;
            string Startzeit = SQLite.startzeit_heute(dateTime.ToString("yyyy-MM-dd")).ToString();

            if (string.IsNullOrEmpty(Bemerkung))
                Bemerkung = "null";

            Kommandozeile.Abmelden(Convert.ToDateTime(null), false, false, Bemerkung, true, id);

            string Endzeit = SQLite.Bestimmter_wert("select Ende from Zeiten where _id = " + id.ToString());

            MessageBox.Show(new Form { TopMost = true }, string.Format("Das Ende wurde erfolgreich eingetragen.\n" +
            "Beginn: {0}\n" +
            "Ende: {1}", Startzeit, Endzeit));
            Application.Exit();
        }
    }
}
