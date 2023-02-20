namespace Arbeitszeiten
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Start = new System.Windows.Forms.TextBox();
            this.txtBox_Ende = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Differenz = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkBox_Manuell = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBox_Pause = new System.Windows.Forms.CheckBox();
            this.chkBox_Rechnerisch = new System.Windows.Forms.CheckBox();
            this.chkBox_Außerhalb = new System.Windows.Forms.CheckBox();
            this.lbl_Meldung = new System.Windows.Forms.Label();
            this.txtBox_Bemerkung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Startzeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endzeit:";
            // 
            // txtBox_Start
            // 
            this.txtBox_Start.Location = new System.Drawing.Point(89, 6);
            this.txtBox_Start.Name = "txtBox_Start";
            this.txtBox_Start.ReadOnly = true;
            this.txtBox_Start.Size = new System.Drawing.Size(110, 23);
            this.txtBox_Start.TabIndex = 3;
            // 
            // txtBox_Ende
            // 
            this.txtBox_Ende.Location = new System.Drawing.Point(89, 35);
            this.txtBox_Ende.Name = "txtBox_Ende";
            this.txtBox_Ende.ReadOnly = true;
            this.txtBox_Ende.Size = new System.Drawing.Size(110, 23);
            this.txtBox_Ende.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Differenz
            // 
            this.lbl_Differenz.AutoSize = true;
            this.lbl_Differenz.Location = new System.Drawing.Point(26, 93);
            this.lbl_Differenz.Name = "lbl_Differenz";
            this.lbl_Differenz.Size = new System.Drawing.Size(57, 15);
            this.lbl_Differenz.TabIndex = 7;
            this.lbl_Differenz.Text = "Differenz:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(382, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Einstellungen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkBox_Manuell
            // 
            this.chkBox_Manuell.AutoSize = true;
            this.chkBox_Manuell.Location = new System.Drawing.Point(6, 22);
            this.chkBox_Manuell.Name = "chkBox_Manuell";
            this.chkBox_Manuell.Size = new System.Drawing.Size(69, 19);
            this.chkBox_Manuell.TabIndex = 10;
            this.chkBox_Manuell.Text = "Manuell";
            this.chkBox_Manuell.UseVisualStyleBackColor = true;
            this.chkBox_Manuell.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(315, 141);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 15);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Statistiken";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBox_Pause);
            this.groupBox1.Controls.Add(this.chkBox_Rechnerisch);
            this.groupBox1.Controls.Add(this.chkBox_Außerhalb);
            this.groupBox1.Controls.Add(this.chkBox_Manuell);
            this.groupBox1.Location = new System.Drawing.Point(286, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 126);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optionen";
            // 
            // chkBox_Pause
            // 
            this.chkBox_Pause.AutoSize = true;
            this.chkBox_Pause.Checked = true;
            this.chkBox_Pause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_Pause.Location = new System.Drawing.Point(6, 97);
            this.chkBox_Pause.Name = "chkBox_Pause";
            this.chkBox_Pause.Size = new System.Drawing.Size(57, 19);
            this.chkBox_Pause.TabIndex = 13;
            this.chkBox_Pause.Text = "Pause";
            this.chkBox_Pause.UseVisualStyleBackColor = true;
            this.chkBox_Pause.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chkBox_Rechnerisch
            // 
            this.chkBox_Rechnerisch.AutoSize = true;
            this.chkBox_Rechnerisch.Location = new System.Drawing.Point(6, 72);
            this.chkBox_Rechnerisch.Name = "chkBox_Rechnerisch";
            this.chkBox_Rechnerisch.Size = new System.Drawing.Size(154, 19);
            this.chkBox_Rechnerisch.TabIndex = 12;
            this.chkBox_Rechnerisch.Text = "Rechnerische Arbeitszeit";
            this.chkBox_Rechnerisch.UseVisualStyleBackColor = true;
            this.chkBox_Rechnerisch.CheckedChanged += new System.EventHandler(this.chkBox_Rechnerisch_CheckedChanged);
            // 
            // chkBox_Außerhalb
            // 
            this.chkBox_Außerhalb.AutoSize = true;
            this.chkBox_Außerhalb.Location = new System.Drawing.Point(6, 47);
            this.chkBox_Außerhalb.Name = "chkBox_Außerhalb";
            this.chkBox_Außerhalb.Size = new System.Drawing.Size(152, 19);
            this.chkBox_Außerhalb.TabIndex = 11;
            this.chkBox_Außerhalb.Text = "Außerhalb Arbeitszeiten";
            this.chkBox_Außerhalb.UseVisualStyleBackColor = true;
            // 
            // lbl_Meldung
            // 
            this.lbl_Meldung.AutoSize = true;
            this.lbl_Meldung.Location = new System.Drawing.Point(26, 123);
            this.lbl_Meldung.Name = "lbl_Meldung";
            this.lbl_Meldung.Size = new System.Drawing.Size(250, 15);
            this.lbl_Meldung.TabIndex = 13;
            this.lbl_Meldung.Text = "Es wird NICHTS in die Datenbank geschrieben!";
            this.lbl_Meldung.Visible = false;
            // 
            // txtBox_Bemerkung
            // 
            this.txtBox_Bemerkung.Location = new System.Drawing.Point(89, 64);
            this.txtBox_Bemerkung.Name = "txtBox_Bemerkung";
            this.txtBox_Bemerkung.Size = new System.Drawing.Size(191, 23);
            this.txtBox_Bemerkung.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bemerkung:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 167);
            this.Controls.Add(this.txtBox_Bemerkung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_Differenz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Ende);
            this.Controls.Add(this.txtBox_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Meldung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arbeitszeiterfassung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private TextBox txtBox_Start;
        private TextBox txtBox_Ende;
        private Label lbl_Differenz;
        private CheckBox chkBox_Manuell;
        private LinkLabel linkLabel2;
        private GroupBox groupBox1;
        private CheckBox chkBox_Außerhalb;
        private CheckBox chkBox_Rechnerisch;
        private Label lbl_Meldung;
        private TextBox txtBox_Bemerkung;
        private Label label4;
        public CheckBox chkBox_Pause;
    }
}