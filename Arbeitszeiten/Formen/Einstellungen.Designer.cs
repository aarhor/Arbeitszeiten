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
            label3 = new Label();
            txtBox_Minuten = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            txtBox_Passwort = new TextBox();
            label2 = new Label();
            lnklbl_DBpwd_anzeigen = new LinkLabel();
            SuspendLayout();
            // 
            // btn_Neustart
            // 
            btn_Neustart.Enabled = false;
            btn_Neustart.Location = new Point(118, 118);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 6;
            label3.Text = "Zeit die abgezogen wird (?):";
            label3.Click += label3_Click;
            // 
            // txtBox_Minuten
            // 
            txtBox_Minuten.Location = new Point(170, 89);
            txtBox_Minuten.Name = "txtBox_Minuten";
            txtBox_Minuten.ReadOnly = true;
            txtBox_Minuten.Size = new Size(46, 23);
            txtBox_Minuten.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 70);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Zeit abziehen";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(199, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 92);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Minuten";
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
            lnklbl_DBpwd_anzeigen.Location = new Point(204, 67);
            lnklbl_DBpwd_anzeigen.Name = "lnklbl_DBpwd_anzeigen";
            lnklbl_DBpwd_anzeigen.Size = new Size(56, 15);
            lnklbl_DBpwd_anzeigen.TabIndex = 13;
            lnklbl_DBpwd_anzeigen.TabStop = true;
            lnklbl_DBpwd_anzeigen.Text = "Anzeigen";
            lnklbl_DBpwd_anzeigen.LinkClicked += lnklbl_DBpwd_anzeigen_LinkClicked;
            // 
            // Einstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 147);
            Controls.Add(lnklbl_DBpwd_anzeigen);
            Controls.Add(txtBox_Passwort);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(txtBox_Minuten);
            Controls.Add(label3);
            Controls.Add(button1);
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
        private Label label3;
        private TextBox txtBox_Minuten;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private TextBox txtBox_Passwort;
        private Label label2;
        private LinkLabel lnklbl_DBpwd_anzeigen;
    }
}