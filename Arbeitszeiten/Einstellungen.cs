using Arbeitszeiten.Klassen;

namespace Arbeitszeiten
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            Registry.SetValue("Dateipfad", txtBox_Pfad.Text);
            if (!File.Exists(txtBox_Pfad.Text))
            {
                SQLite.create_table();

                if (File.Exists(txtBox_Pfad.Text))
                    MessageBox.Show("Der Dateipfad wurde erfolgreich in der Registry gespeichert und die Datei wurde erstellt.\nBitte einmal das Programm neustarten.");
            }
            else
                MessageBox.Show("Der Dateipfad wurde erfolgreich in der Registry gespeichert.");
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            bool vorhanden = Registry.RegistryKeyExists(@"software\" + Application.CompanyName + @"\" + Application.ProductName);

            if (vorhanden)
                txtBox_Pfad.Text = Registry.GetValue("Dateipfad");
            else
                MessageBox.Show("Es ist noch kein Pfad vorhanden!");
        }

        private void btn_Neustart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In dieses Feld kommt der KOMPLETTE Pfad zu der .db Datei (z.b. \"C:\\Temp\\Arbeitszeiten.db\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Pfad = txtBox_Pfad.Text;
            string Pfad_Sicherung = Path.GetDirectoryName(Pfad) + @"\Sicherungen\Arbeitszeiten_" + DateTime.Now.ToString("yyyyMMdd") + ".db.bak";

            if (!Directory.Exists(Path.GetDirectoryName(Pfad) + @"\Sicherungen\"))
                Directory.CreateDirectory(Path.GetDirectoryName(Pfad) + @"\Sicherungen\");

            File.Copy(Pfad, Pfad_Sicherung, true);
        }
    }
}
