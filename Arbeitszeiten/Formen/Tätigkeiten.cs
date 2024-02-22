using Arbeitszeiten.Klassen;

namespace Arbeitszeiten.Formen
{
    public partial class Tätigkeiten : Form
    {
        public Tätigkeiten()
        {
            InitializeComponent();
        }

        private void Eintragen()
        {
            DateTime dateTime = DateTime.Now;
            string Tätigkeit = textBox1.Text;
            string Datum = dateTime.ToString("yyyy-MM-dd");
            string Uhrzeit = dateTime.ToString("HH:mm:ss");

            if (SQLite.insert_table_Taetigkeit(Datum, Uhrzeit, Tätigkeit))
            {
                MessageBox.Show(new Form { TopMost = true }, "Erfolgreich eintragen");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eintragen();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Eintragen();
        }
    }
}
