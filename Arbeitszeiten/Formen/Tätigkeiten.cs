using Arbeitszeiten.Klassen;

namespace Arbeitszeiten.Formen
{
    public partial class Tätigkeiten : Form
    {
        public Tätigkeiten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string Tätigkeit = textBox1.Text;
            string Datum = dateTime.ToString("yyyy-MM-dd");
            string Uhrzeit = dateTime.ToString("HH:mm:ss");

            if (SQLite.insert_table_Taetigkeit(Datum, Uhrzeit, Tätigkeit))
            {
                MessageBox.Show("Erfolgreich eintragen");
                Application.Exit();
            }
        }
    }
}
