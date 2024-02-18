namespace Arbeitszeiten.Formen
{
    partial class Bearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bearbeiten));
            label1 = new Label();
            txtBox_ID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox_Bemerkung = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            btn_Heute_Datum = new Button();
            btn_Jetzt_Start = new Button();
            btn_Jetzt_Ende = new Button();
            btn_Speichern = new Button();
            mskdtxtBox_Datum = new MaskedTextBox();
            mskdtxtBox_Start = new MaskedTextBox();
            mskdtxtBox_Ende = new MaskedTextBox();
            chkBox_Pause = new CheckBox();
            groupBox1 = new GroupBox();
            chkBox_Ausserhalb = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(3, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtBox_ID
            // 
            txtBox_ID.Location = new Point(89, 12);
            txtBox_ID.Name = "txtBox_ID";
            txtBox_ID.ReadOnly = true;
            txtBox_ID.Size = new Size(149, 23);
            txtBox_ID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Margin = new Padding(3, 8, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Startzeit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Margin = new Padding(3, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Endzeit:";
            // 
            // richTextBox_Bemerkung
            // 
            richTextBox_Bemerkung.Location = new Point(89, 128);
            richTextBox_Bemerkung.Name = "richTextBox_Bemerkung";
            richTextBox_Bemerkung.Size = new Size(230, 55);
            richTextBox_Bemerkung.TabIndex = 6;
            richTextBox_Bemerkung.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Margin = new Padding(3, 8, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Bemerkung:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 44);
            label5.Margin = new Padding(3, 8, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Datum:";
            // 
            // btn_Heute_Datum
            // 
            btn_Heute_Datum.Location = new Point(244, 41);
            btn_Heute_Datum.Name = "btn_Heute_Datum";
            btn_Heute_Datum.Size = new Size(75, 23);
            btn_Heute_Datum.TabIndex = 10;
            btn_Heute_Datum.Text = "Heute";
            btn_Heute_Datum.UseVisualStyleBackColor = true;
            btn_Heute_Datum.Click += btn_Heute_Datum_Click;
            // 
            // btn_Jetzt_Start
            // 
            btn_Jetzt_Start.Location = new Point(244, 70);
            btn_Jetzt_Start.Name = "btn_Jetzt_Start";
            btn_Jetzt_Start.Size = new Size(75, 23);
            btn_Jetzt_Start.TabIndex = 11;
            btn_Jetzt_Start.Text = "Jetzt";
            btn_Jetzt_Start.UseVisualStyleBackColor = true;
            btn_Jetzt_Start.Click += btn_Jetzt_Start_Click;
            // 
            // btn_Jetzt_Ende
            // 
            btn_Jetzt_Ende.Location = new Point(244, 99);
            btn_Jetzt_Ende.Name = "btn_Jetzt_Ende";
            btn_Jetzt_Ende.Size = new Size(75, 23);
            btn_Jetzt_Ende.TabIndex = 12;
            btn_Jetzt_Ende.Text = "Jetzt";
            btn_Jetzt_Ende.UseVisualStyleBackColor = true;
            btn_Jetzt_Ende.Click += btn_Jetzt_Ende_Click;
            // 
            // btn_Speichern
            // 
            btn_Speichern.Location = new Point(89, 189);
            btn_Speichern.Name = "btn_Speichern";
            btn_Speichern.Size = new Size(75, 23);
            btn_Speichern.TabIndex = 13;
            btn_Speichern.Text = "Speichern";
            btn_Speichern.UseVisualStyleBackColor = true;
            btn_Speichern.Click += btn_Speichern_Click;
            // 
            // mskdtxtBox_Datum
            // 
            mskdtxtBox_Datum.Location = new Point(89, 41);
            mskdtxtBox_Datum.Mask = "00/00/0000";
            mskdtxtBox_Datum.Name = "mskdtxtBox_Datum";
            mskdtxtBox_Datum.Size = new Size(149, 23);
            mskdtxtBox_Datum.TabIndex = 14;
            mskdtxtBox_Datum.ValidatingType = typeof(DateTime);
            // 
            // mskdtxtBox_Start
            // 
            mskdtxtBox_Start.Location = new Point(89, 70);
            mskdtxtBox_Start.Mask = "90:00:00";
            mskdtxtBox_Start.Name = "mskdtxtBox_Start";
            mskdtxtBox_Start.Size = new Size(149, 23);
            mskdtxtBox_Start.TabIndex = 15;
            mskdtxtBox_Start.ValidatingType = typeof(DateTime);
            // 
            // mskdtxtBox_Ende
            // 
            mskdtxtBox_Ende.Location = new Point(89, 99);
            mskdtxtBox_Ende.Mask = "00:00:00";
            mskdtxtBox_Ende.Name = "mskdtxtBox_Ende";
            mskdtxtBox_Ende.Size = new Size(149, 23);
            mskdtxtBox_Ende.TabIndex = 16;
            mskdtxtBox_Ende.ValidatingType = typeof(DateTime);
            // 
            // chkBox_Pause
            // 
            chkBox_Pause.AutoSize = true;
            chkBox_Pause.Checked = true;
            chkBox_Pause.CheckState = CheckState.Checked;
            chkBox_Pause.Location = new Point(6, 22);
            chkBox_Pause.Name = "chkBox_Pause";
            chkBox_Pause.Size = new Size(57, 19);
            chkBox_Pause.TabIndex = 17;
            chkBox_Pause.Text = "Pause";
            chkBox_Pause.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBox_Ausserhalb);
            groupBox1.Controls.Add(chkBox_Pause);
            groupBox1.Location = new Point(325, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(97, 200);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Optionen";
            // 
            // chkBox_Ausserhalb
            // 
            chkBox_Ausserhalb.AutoSize = true;
            chkBox_Ausserhalb.Location = new Point(6, 47);
            chkBox_Ausserhalb.Name = "chkBox_Ausserhalb";
            chkBox_Ausserhalb.Size = new Size(81, 19);
            chkBox_Ausserhalb.TabIndex = 18;
            chkBox_Ausserhalb.Text = "Außerhalb";
            chkBox_Ausserhalb.UseVisualStyleBackColor = true;
            // 
            // Bearbeiten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 221);
            Controls.Add(groupBox1);
            Controls.Add(mskdtxtBox_Ende);
            Controls.Add(mskdtxtBox_Start);
            Controls.Add(mskdtxtBox_Datum);
            Controls.Add(btn_Speichern);
            Controls.Add(btn_Jetzt_Ende);
            Controls.Add(btn_Jetzt_Start);
            Controls.Add(btn_Heute_Datum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox_Bemerkung);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBox_ID);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(445, 260);
            MinimumSize = new Size(445, 260);
            Name = "Bearbeiten";
            Text = "Bearbeiten";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBox_ID;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox_Bemerkung;
        private Label label4;
        private Label label5;
        private Button btn_Heute_Datum;
        private Button btn_Jetzt_Start;
        private Button btn_Jetzt_Ende;
        private Button btn_Speichern;
        private MaskedTextBox mskdtxtBox_Datum;
        private MaskedTextBox mskdtxtBox_Start;
        private MaskedTextBox mskdtxtBox_Ende;
        private CheckBox chkBox_Pause;
        private GroupBox groupBox1;
        private CheckBox chkBox_Ausserhalb;
    }
}