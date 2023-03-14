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
            bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
            int abzug = (int)(Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60);

            if (vorhanden)
                txtBox_Pfad.Text = Registry.GetValue("Dateipfad");
            else
                MessageBox.Show("Es ist noch kein Pfad vorhanden!");

            if (Zeit_abziehen)
            {
                checkBox1.Checked = true;
                button1.Enabled = true;
                txtBox_Minuten.ReadOnly = false;
                txtBox_Minuten.Text = abzug.ToString();
            }
            else
            {
                button1.Enabled = false;
                checkBox1.Checked = false;
                txtBox_Minuten.ReadOnly = true;
                txtBox_Minuten.Text = abzug.ToString();
            }
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
            decimal abzug = Math.Round(Convert.ToDecimal(txtBox_Minuten.Text) / 60, 2);

            Registry.SetValue("Zeit_abziehen_Dauer", abzug.ToString());
            MessageBox.Show("Der WErt wurde eingetragen.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Pfad = txtBox_Pfad.Text;
            string Pfad_Sicherung = Path.GetDirectoryName(Pfad) + @"\Sicherungen\Arbeitszeiten_" + DateTime.Now.ToString("yyyyMMdd") + ".db.bak";

            if (!Directory.Exists(Path.GetDirectoryName(Pfad) + @"\Sicherungen\"))
                Directory.CreateDirectory(Path.GetDirectoryName(Pfad) + @"\Sicherungen\");

            File.Copy(Pfad, Pfad_Sicherung, true);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wenn der start button gedrückt wird, wird immer automatisch die angegebene Zeit von der aktuellen abgezogen.\n" +
                "Die Zeit MUSS in Minuten angegeben werden. Auch wenn 1, 2, 3... Stunden sein soll. Aktuell werden NUR komplette Minuten unterstützt.");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBox_Minuten.ReadOnly = false;
                button1.Enabled = true;
                Registry.SetValue("Zeit_abziehen", true.ToString());

                MessageBox.Show("Wenn der start button gedrückt wird, wird immer automatisch die angegebene Zeit von der aktuellen abgezogen.\n" +
                    "Die Zeit MUSS in Minuten angegeben werden. Auch wenn 1, 2, 3... Stunden sein soll. Aktuell werden NUR komplette Minuten unterstützt.");
            }
            else
            {
                txtBox_Minuten.ReadOnly = true;
                button1.Enabled = false;
                Registry.SetValue("Zeit_abziehen", false.ToString());

                MessageBox.Show("Es wird keine Zeit von der Startzeit abgezogen.");
            }
        }
    }
}
