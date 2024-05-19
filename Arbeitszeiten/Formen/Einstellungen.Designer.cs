namespace Arbeitszeiten
{
    partial class Einstellungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            btn_Neustart = new Button();
            label1 = new Label();
            txtBox_Pfad = new TextBox();
            btn_Speichern = new Button();
            txtBox_Passwort = new TextBox();
            label2 = new Label();
            lnklbl_DBpwd_anzeigen = new LinkLabel();
            lnklbl_Aenderungen = new LinkLabel();
            SuspendLayout();
            // 
            // btn_Neustart
            // 
            btn_Neustart.Enabled = false;
            btn_Neustart.Location = new Point(118, 85);
            btn_Neustart.Name = "btn_Neustart";
            btn_Neustart.Size = new Size(75, 23);
            btn_Neustart.TabIndex = 6;
            btn_Neustart.Text = "Neustarten";
            btn_Neustart.UseVisualStyleBackColor = true;
            btn_Neustart.Click += btn_Neustart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Dateipfad (?):";
            label1.Click += label1_Click;
            // 
            // txtBox_Pfad
            // 
            txtBox_Pfad.Location = new Point(97, 12);
            txtBox_Pfad.Name = "txtBox_Pfad";
            txtBox_Pfad.Size = new Size(177, 23);
            txtBox_Pfad.TabIndex = 1;
            // 
            // btn_Speichern
            // 
            btn_Speichern.Location = new Point(199, 85);
            btn_Speichern.Name = "btn_Speichern";
            btn_Speichern.Size = new Size(75, 23);
            btn_Speichern.TabIndex = 5;
            btn_Speichern.Text = "Speichern";
            btn_Speichern.UseVisualStyleBackColor = true;
            btn_Speichern.Click += button1_Click;
            // 
            // txtBox_Passwort
            // 
            txtBox_Passwort.Location = new Point(97, 41);
            txtBox_Passwort.Name = "txtBox_Passwort";
            txtBox_Passwort.PasswordChar = '*';
            txtBox_Passwort.Size = new Size(177, 23);
            txtBox_Passwort.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 12;
            label2.Text = "DB Kennwort:";
            // 
            // lnklbl_DBpwd_anzeigen
            // 
            lnklbl_DBpwd_anzeigen.AutoSize = true;
            lnklbl_DBpwd_anzeigen.Location = new Point(218, 67);
            lnklbl_DBpwd_anzeigen.Name = "lnklbl_DBpwd_anzeigen";
            lnklbl_DBpwd_anzeigen.Size = new Size(56, 15);
            lnklbl_DBpwd_anzeigen.TabIndex = 13;
            lnklbl_DBpwd_anzeigen.TabStop = true;
            lnklbl_DBpwd_anzeigen.Text = "Anzeigen";
            lnklbl_DBpwd_anzeigen.LinkClicked += lnklbl_DBpwd_anzeigen_LinkClicked;
            // 
            // lnklbl_Aenderungen
            // 
            lnklbl_Aenderungen.AutoSize = true;
            lnklbl_Aenderungen.Location = new Point(12, 90);
            lnklbl_Aenderungen.Name = "lnklbl_Aenderungen";
            lnklbl_Aenderungen.Size = new Size(73, 15);
            lnklbl_Aenderungen.TabIndex = 14;
            lnklbl_Aenderungen.TabStop = true;
            lnklbl_Aenderungen.Text = "Änderungen";
            lnklbl_Aenderungen.LinkClicked += lnklbl_Aenderungen_LinkClicked;
            // 
            // Einstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 114);
            Controls.Add(lnklbl_Aenderungen);
            Controls.Add(lnklbl_DBpwd_anzeigen);
            Controls.Add(txtBox_Passwort);
            Controls.Add(label2);
            Controls.Add(btn_Speichern);
            Controls.Add(txtBox_Pfad);
            Controls.Add(label1);
            Controls.Add(btn_Neustart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Einstellungen";
            Text = "Einstellungen";
            Load += Einstellungen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Neustart;
        private Label label1;
        private TextBox txtBox_Pfad;
        private Button btn_Speichern;
        private TextBox txtBox_Passwort;
        private Label label2;
        private LinkLabel lnklbl_DBpwd_anzeigen;
        private LinkLabel lnklbl_Aenderungen;
    }
}