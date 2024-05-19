using Arbeitszeiten.Formen;
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
                txtBox_Pfad.Text = Registry.GetValue("Dateipfad");
                txtBox_Passwort.Text = Crypto_137.Text_Decrypt(Registry.GetValue("DB_Pwd"), string.Empty);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Form { TopMost = true }, "In dieses Feld kommt der KOMPLETTE Pfad zu der .db Datei (z.b. \"C:\\Temp\\Arbeitszeiten.db\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    if (File.Exists(txtBox_Pfad.Text))
                    {
                        string SQL_Befehl = Properties.Resources.Erstellen;

                        SQLite.Nur_Befehl(SQL_Befehl);

                        MessageBox.Show(new Form { TopMost = true }, "Der Dateipfad wurde erfolgreich in der Registry gespeichert und die Datei wurde erstellt.\nDas Programm muss nun einmal neugestartet werden..");
                        btn_Neustart.Enabled = true;
                    }
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

                    MessageBox.Show(new Form { TopMost = true }, "Der Dateipfad wurden erfolgreich in der Registry gespeichert.");
                }
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

        private void lnklbl_Aenderungen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Changelog Form_Changelog = new();
            Form_Changelog.Show();
        }
    }
}
