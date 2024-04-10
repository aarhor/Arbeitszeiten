using Arbeitszeiten.Klassen;

namespace Arbeitszeiten
{
    public partial class Einstellungen : Form
    {
        public Einstellungen(bool Ersteinrichtung = false)
        {
            InitializeComponent();

            Einrichtung = Ersteinrichtung;
        }

        private readonly bool Einrichtung;

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            if (Einrichtung)
                MessageBox.Show(new Form { TopMost = true }, "Es ist noch kein Pfad vorhanden!");
            else
            {
                bool Zeit_abziehen = Convert.ToBoolean(Registry.GetValue("Zeit_abziehen"));
                int abzug = (int)(Convert.ToDouble(Registry.GetValue("Zeit_abziehen_Dauer")) * 60);

                txtBox_Pfad.Text = Registry.GetValue("Dateipfad");
                txtBox_Passwort.Text = Crypto_137.Text_Decrypt(Registry.GetValue("DB_Pwd"), string.Empty);

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Form { TopMost = true }, "In dieses Feld kommt der KOMPLETTE Pfad zu der .db Datei (z.b. \"C:\\Temp\\Arbeitszeiten.db\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal abzug = Math.Round(Convert.ToDecimal(txtBox_Minuten.Text) / 60, 2);

            Registry.SetValue("Zeit_abziehen_Dauer", abzug.ToString());

            txtBox_Pfad.Text = txtBox_Pfad.Text.Replace("\"", string.Empty);

            string DB_Passwd = Crypto_137.Text_Encrypt(txtBox_Passwort.Text, string.Empty);

            Registry.SetValue("Dateipfad", txtBox_Pfad.Text);
            Registry.SetValue("DB_Pwd", DB_Passwd);

            if (!File.Exists(txtBox_Pfad.Text))
            {
                if (string.IsNullOrEmpty(txtBox_Pfad.Text) || string.IsNullOrEmpty(txtBox_Passwort.Text))
                    MessageBox.Show(new Form { TopMost = true }, "Es wurde kein Pfad oder Datenbank Passwort angegeben. Bitte trage die leeren Felder nach!");
                else
                {
                    string SQL_Befehl = Properties.Resources.Erstellen;

                    SQLite.Nur_Befehl(SQL_Befehl);

                    if (File.Exists(txtBox_Pfad.Text))
                        MessageBox.Show(new Form { TopMost = true }, "Alle Werte sowie der Dateipfad wurden erfolgreich in der Registry gespeichert und die Datei wurde erstellt.\nDas Programm muss nun einmal neugestartet werden..");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtBox_Pfad.Text) || string.IsNullOrEmpty(txtBox_Passwort.Text))
                    MessageBox.Show(new Form { TopMost = true }, "Es wurde kein Pfad oder Datenbank Passwort angegeben. Bitte trage die leeren Felder nach!");
                else
                {
                    btn_Neustart.Enabled = true;
                    SQLite.Neues_DB_Passwort(txtBox_Passwort.Text);

                    MessageBox.Show(new Form { TopMost = true }, "Alle Werte sowie der Dateipfad wurden erfolgreich in der Registry gespeichert.");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Form { TopMost = true }, "Wenn der start button gedrückt wird, wird immer automatisch die angegebene Zeit von der aktuellen abgezogen.\n" +
                "Die Zeit MUSS in Minuten angegeben werden.");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBox_Minuten.ReadOnly = false;
                button1.Enabled = true;
                Registry.SetValue("Zeit_abziehen", true.ToString());

                MessageBox.Show(new Form { TopMost = true }, "Wenn der start button gedrückt wird, wird immer automatisch die angegebene Zeit von der aktuellen abgezogen.\n" +
                    "Die Zeit MUSS in Minuten angegeben werden.");
            }
            else
            {
                txtBox_Minuten.ReadOnly = true;
                button1.Enabled = false;
                Registry.SetValue("Zeit_abziehen", false.ToString());

                MessageBox.Show(new Form { TopMost = true }, "Es wird keine Zeit von der Startzeit abgezogen.");
            }
        }

        private void btn_Neustart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Pfad.Text) || string.IsNullOrEmpty(txtBox_Passwort.Text))
            {
                MessageBox.Show(new Form { TopMost = true }, "Es wurde kein Pfad oder Datenbank Passwort angegeben. Bitte trage die leeren Felder nach!");
            }
            else
            {
                Application.Restart();
            }
        }

        private void lnklbl_DBpwd_anzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnklbl_DBpwd_anzeigen.Text == "Ausblenden")
            {
                txtBox_Passwort.PasswordChar = '*';
                lnklbl_DBpwd_anzeigen.Text = "Anzeigen";
            }
            else if (lnklbl_DBpwd_anzeigen.Text == "Anzeigen")
            {
                txtBox_Passwort.PasswordChar = '\0';
                lnklbl_DBpwd_anzeigen.Text = "Ausblenden";
            }
        }
    }
}
