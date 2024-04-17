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
            lnklbl_Aenderungen = new LinkLabel();
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dateipfad:\r\n(?)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_Pfad
            // 
            this.txtBox_Pfad.Location = new System.Drawing.Point(79, 12);
            this.txtBox_Pfad.Name = "txtBox_Pfad";
            this.txtBox_Pfad.Size = new System.Drawing.Size(190, 23);
            this.txtBox_Pfad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sicherung erstellen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zeit die abgezogen wird (?):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_Minuten
            // 
            this.txtBox_Minuten.Location = new System.Drawing.Point(170, 115);
            this.txtBox_Minuten.Name = "txtBox_Minuten";
            this.txtBox_Minuten.ReadOnly = true;
            this.txtBox_Minuten.Size = new System.Drawing.Size(46, 23);
            this.txtBox_Minuten.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(119, 74);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sichern";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Zeit abziehen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(170, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minuten";
            // 
            // lnklbl_Aenderungen
            // 
            lnklbl_Aenderungen.AutoSize = true;
            lnklbl_Aenderungen.Location = new Point(12, 123);
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
            ClientSize = new Size(283, 147);
            Controls.Add(lnklbl_Aenderungen);
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

        private Button btn_Speichern;
        private Label label1;
        private TextBox txtBox_Pfad;
        private Label label2;
        private Label label3;
        private TextBox txtBox_Minuten;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private TextBox txtBox_Passwort;
        private Label label2;
        private LinkLabel lnklbl_DBpwd_anzeigen;
        private LinkLabel lnklbl_Aenderungen;
    }
}