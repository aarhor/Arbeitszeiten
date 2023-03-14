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
            label1 = new Label();
            label2 = new Label();
            txtBox_Start = new TextBox();
            txtBox_Ende = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lbl_Differenz = new Label();
            linkLabel1 = new LinkLabel();
            chkBox_Manuell = new CheckBox();
            linkLabel2 = new LinkLabel();
            groupBox1 = new GroupBox();
            chkBox_Pause = new CheckBox();
            chkBox_Rechnerisch = new CheckBox();
            chkBox_Außerhalb = new CheckBox();
            lbl_Meldung = new Label();
            txtBox_Bemerkung = new TextBox();
            label4 = new Label();
            lbl_Endzeit = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Startzeit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 38);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Endzeit:";
            // 
            // txtBox_Start
            // 
            txtBox_Start.Location = new Point(89, 6);
            txtBox_Start.Name = "txtBox_Start";
            txtBox_Start.ReadOnly = true;
            txtBox_Start.Size = new Size(110, 23);
            txtBox_Start.TabIndex = 3;
            // 
            // txtBox_Ende
            // 
            txtBox_Ende.Location = new Point(89, 35);
            txtBox_Ende.Name = "txtBox_Ende";
            txtBox_Ende.ReadOnly = true;
            txtBox_Ende.Size = new Size(110, 23);
            txtBox_Ende.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(205, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 35);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Speichern";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl_Differenz
            // 
            lbl_Differenz.AutoSize = true;
            lbl_Differenz.Location = new Point(26, 113);
            lbl_Differenz.Name = "lbl_Differenz";
            lbl_Differenz.Size = new Size(57, 15);
            lbl_Differenz.TabIndex = 7;
            lbl_Differenz.Text = "Differenz:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(382, 141);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Einstellungen";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // chkBox_Manuell
            // 
            chkBox_Manuell.AutoSize = true;
            chkBox_Manuell.Location = new Point(6, 22);
            chkBox_Manuell.Name = "chkBox_Manuell";
            chkBox_Manuell.Size = new Size(69, 19);
            chkBox_Manuell.TabIndex = 10;
            chkBox_Manuell.Text = "Manuell";
            chkBox_Manuell.UseVisualStyleBackColor = true;
            chkBox_Manuell.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(315, 141);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 15);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Statistiken";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBox_Pause);
            groupBox1.Controls.Add(chkBox_Rechnerisch);
            groupBox1.Controls.Add(chkBox_Außerhalb);
            groupBox1.Controls.Add(chkBox_Manuell);
            groupBox1.Location = new Point(286, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 126);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Optionen";
            // 
            // chkBox_Pause
            // 
            chkBox_Pause.AutoSize = true;
            chkBox_Pause.Checked = true;
            chkBox_Pause.CheckState = CheckState.Checked;
            chkBox_Pause.Location = new Point(6, 97);
            chkBox_Pause.Name = "chkBox_Pause";
            chkBox_Pause.Size = new Size(57, 19);
            chkBox_Pause.TabIndex = 13;
            chkBox_Pause.Text = "Pause";
            chkBox_Pause.UseVisualStyleBackColor = true;
            chkBox_Pause.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // chkBox_Rechnerisch
            // 
            chkBox_Rechnerisch.AutoSize = true;
            chkBox_Rechnerisch.Location = new Point(6, 72);
            chkBox_Rechnerisch.Name = "chkBox_Rechnerisch";
            chkBox_Rechnerisch.Size = new Size(154, 19);
            chkBox_Rechnerisch.TabIndex = 12;
            chkBox_Rechnerisch.Text = "Rechnerische Arbeitszeit";
            chkBox_Rechnerisch.UseVisualStyleBackColor = true;
            chkBox_Rechnerisch.CheckedChanged += chkBox_Rechnerisch_CheckedChanged;
            // 
            // chkBox_Außerhalb
            // 
            chkBox_Außerhalb.AutoSize = true;
            chkBox_Außerhalb.Location = new Point(6, 47);
            chkBox_Außerhalb.Name = "chkBox_Außerhalb";
            chkBox_Außerhalb.Size = new Size(152, 19);
            chkBox_Außerhalb.TabIndex = 11;
            chkBox_Außerhalb.Text = "Außerhalb Arbeitszeiten";
            chkBox_Außerhalb.UseVisualStyleBackColor = true;
            // 
            // lbl_Meldung
            // 
            lbl_Meldung.AutoSize = true;
            lbl_Meldung.Location = new Point(30, 141);
            lbl_Meldung.Name = "lbl_Meldung";
            lbl_Meldung.Size = new Size(250, 15);
            lbl_Meldung.TabIndex = 13;
            lbl_Meldung.Text = "Es wird NICHTS in die Datenbank geschrieben!";
            lbl_Meldung.Visible = false;
            // 
            // txtBox_Bemerkung
            // 
            txtBox_Bemerkung.Location = new Point(89, 64);
            txtBox_Bemerkung.Name = "txtBox_Bemerkung";
            txtBox_Bemerkung.Size = new Size(191, 23);
            txtBox_Bemerkung.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "Bemerkung:";
            // 
            // lbl_Endzeit
            // 
            lbl_Endzeit.AutoSize = true;
            lbl_Endzeit.Location = new Point(47, 91);
            lbl_Endzeit.Name = "lbl_Endzeit";
            lbl_Endzeit.Size = new Size(36, 15);
            lbl_Endzeit.TabIndex = 16;
            lbl_Endzeit.Text = "Ende:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 167);
            Controls.Add(lbl_Endzeit);
            Controls.Add(txtBox_Bemerkung);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(lbl_Differenz);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBox_Ende);
            Controls.Add(txtBox_Start);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Meldung);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Arbeitszeiterfassung";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbl_Endzeit;
    }
}