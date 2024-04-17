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
            btn_Start = new Button();
            btn_Ende = new Button();
            lbl_Differenz = new Label();
            chkBox_Manuell = new CheckBox();
            groupBox1 = new GroupBox();
            chkBox_Workshop = new CheckBox();
            chkBox_Hallo_Tschuess = new CheckBox();
            chkBox_Pause = new CheckBox();
            chkBox_Rechnerisch = new CheckBox();
            chkBox_Außerhalb = new CheckBox();
            lbl_Meldung = new Label();
            txtBox_Bemerkung = new TextBox();
            label4 = new Label();
            lbl_Endzeit = new Label();
            lbl_Absolut = new Label();
            mskdtxtBox_Start = new MaskedTextBox();
            mskdtxtBox_Ende = new MaskedTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Startzeit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 43);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Endzeit:";
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(197, 11);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 5;
            btn_Start.Text = "Anfang";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += button1_Click;
            // 
            // btn_Ende
            // 
            btn_Ende.Enabled = false;
            btn_Ende.Location = new Point(197, 40);
            btn_Ende.Name = "btn_Ende";
            btn_Ende.Size = new Size(75, 23);
            btn_Ende.TabIndex = 6;
            btn_Ende.Text = "Ende";
            btn_Ende.UseVisualStyleBackColor = true;
            btn_Ende.Click += button2_Click;
            // 
            // lbl_Differenz
            // 
            lbl_Differenz.AutoSize = true;
            lbl_Differenz.Location = new Point(18, 126);
            lbl_Differenz.Margin = new Padding(3, 12, 3, 0);
            lbl_Differenz.Name = "lbl_Differenz";
            lbl_Differenz.Size = new Size(57, 15);
            lbl_Differenz.TabIndex = 7;
            lbl_Differenz.Text = "Differenz:";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBox_Workshop);
            groupBox1.Controls.Add(chkBox_Hallo_Tschuess);
            groupBox1.Controls.Add(chkBox_Pause);
            groupBox1.Controls.Add(chkBox_Rechnerisch);
            groupBox1.Controls.Add(chkBox_Außerhalb);
            groupBox1.Controls.Add(chkBox_Manuell);
            groupBox1.Location = new Point(278, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 177);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Optionen";
            // 
            // chkBox_Workshop
            // 
            chkBox_Workshop.AutoSize = true;
            chkBox_Workshop.Location = new Point(6, 122);
            chkBox_Workshop.Name = "chkBox_Workshop";
            chkBox_Workshop.Size = new Size(145, 19);
            chkBox_Workshop.TabIndex = 16;
            chkBox_Workshop.Text = "Workshop, Schulung...";
            chkBox_Workshop.UseVisualStyleBackColor = true;
            // 
            // chkBox_Hallo_Tschuess
            // 
            chkBox_Hallo_Tschuess.AutoSize = true;
            chkBox_Hallo_Tschuess.Enabled = false;
            chkBox_Hallo_Tschuess.Location = new Point(6, 147);
            chkBox_Hallo_Tschuess.Name = "chkBox_Hallo_Tschuess";
            chkBox_Hallo_Tschuess.Size = new Size(105, 19);
            chkBox_Hallo_Tschuess.TabIndex = 14;
            chkBox_Hallo_Tschuess.Text = "Hallo / Tschüss";
            chkBox_Hallo_Tschuess.UseVisualStyleBackColor = true;
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
            lbl_Meldung.Location = new Point(12, 179);
            lbl_Meldung.Name = "lbl_Meldung";
            lbl_Meldung.Size = new Size(250, 15);
            lbl_Meldung.TabIndex = 13;
            lbl_Meldung.Text = "Es wird NICHTS in die Datenbank geschrieben!";
            lbl_Meldung.Visible = false;
            // 
            // txtBox_Bemerkung
            // 
            txtBox_Bemerkung.Location = new Point(81, 69);
            txtBox_Bemerkung.Name = "txtBox_Bemerkung";
            txtBox_Bemerkung.Size = new Size(191, 23);
            txtBox_Bemerkung.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 72);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "Bemerkung:";
            // 
            // lbl_Endzeit
            // 
            lbl_Endzeit.AutoSize = true;
            lbl_Endzeit.Location = new Point(39, 99);
            lbl_Endzeit.Margin = new Padding(3, 12, 3, 0);
            lbl_Endzeit.Name = "lbl_Endzeit";
            lbl_Endzeit.Size = new Size(36, 15);
            lbl_Endzeit.TabIndex = 16;
            lbl_Endzeit.Text = "Ende:";
            // 
            // lbl_Absolut
            // 
            lbl_Absolut.AutoSize = true;
            lbl_Absolut.Location = new Point(23, 153);
            lbl_Absolut.Margin = new Padding(3, 12, 3, 0);
            lbl_Absolut.Name = "lbl_Absolut";
            lbl_Absolut.Size = new Size(51, 15);
            lbl_Absolut.TabIndex = 18;
            lbl_Absolut.Text = "Absolut:";
            // 
            // mskdtxtBox_Start
            // 
            mskdtxtBox_Start.Location = new Point(81, 12);
            mskdtxtBox_Start.Mask = "00/00/0000 00:00";
            mskdtxtBox_Start.Name = "mskdtxtBox_Start";
            mskdtxtBox_Start.ReadOnly = true;
            mskdtxtBox_Start.Size = new Size(110, 23);
            mskdtxtBox_Start.TabIndex = 19;
            mskdtxtBox_Start.ValidatingType = typeof(DateTime);
            // 
            // mskdtxtBox_Ende
            // 
            mskdtxtBox_Ende.Location = new Point(81, 41);
            mskdtxtBox_Ende.Mask = "00/00/0000 00:00";
            mskdtxtBox_Ende.Name = "mskdtxtBox_Ende";
            mskdtxtBox_Ende.ReadOnly = true;
            mskdtxtBox_Ende.Size = new Size(110, 23);
            mskdtxtBox_Ende.TabIndex = 20;
            mskdtxtBox_Ende.ValidatingType = typeof(DateTime);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 197);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(474, 22);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(64, 17);
            toolStripStatusLabel1.Text = "Tätigkeiten";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(61, 17);
            toolStripStatusLabel2.Text = "Statistiken";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(78, 17);
            toolStripStatusLabel3.Text = "Einstellungen";
            toolStripStatusLabel3.Click += toolStripStatusLabel3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 219);
            Controls.Add(statusStrip1);
            Controls.Add(mskdtxtBox_Ende);
            Controls.Add(mskdtxtBox_Start);
            Controls.Add(lbl_Absolut);
            Controls.Add(lbl_Endzeit);
            Controls.Add(txtBox_Bemerkung);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lbl_Differenz);
            Controls.Add(btn_Ende);
            Controls.Add(btn_Start);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Meldung);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(490, 225);
            Name = "Form1";
            Text = "Arbeitszeiterfassung";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btn_Start;
        private Button btn_Ende;
        private Label lbl_Differenz;
        private CheckBox chkBox_Manuell;
        private GroupBox groupBox1;
        private CheckBox chkBox_Außerhalb;
        private CheckBox chkBox_Rechnerisch;
        private Label lbl_Meldung;
        private TextBox txtBox_Bemerkung;
        private Label label4;
        public CheckBox chkBox_Pause;
        private Label lbl_Endzeit;
        private Label lbl_Absolut;
        public CheckBox chkBox_Hallo_Tschuess;
        private MaskedTextBox mskdtxtBox_Start;
        private MaskedTextBox mskdtxtBox_Ende;
        private CheckBox chkBox_Workshop;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}