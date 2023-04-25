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
            label1 = new Label();
            txtBox_ID = new TextBox();
            txtBox_Start = new TextBox();
            label2 = new Label();
            txtBox_Ende = new TextBox();
            label3 = new Label();
            richTextBox_Bemerkung = new RichTextBox();
            label4 = new Label();
            txtBox_Datum = new TextBox();
            label5 = new Label();
            btn_Heute_Datum = new Button();
            btn_Jetzt_Start = new Button();
            btn_Jetzt_Ende = new Button();
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
            // txtBox_Start
            // 
            txtBox_Start.Location = new Point(89, 70);
            txtBox_Start.Name = "txtBox_Start";
            txtBox_Start.PlaceholderText = "00:00:00";
            txtBox_Start.Size = new Size(149, 23);
            txtBox_Start.TabIndex = 3;
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
            // txtBox_Ende
            // 
            txtBox_Ende.Location = new Point(89, 99);
            txtBox_Ende.Name = "txtBox_Ende";
            txtBox_Ende.PlaceholderText = "00:00:00";
            txtBox_Ende.Size = new Size(149, 23);
            txtBox_Ende.TabIndex = 5;
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
            richTextBox_Bemerkung.Size = new Size(149, 55);
            richTextBox_Bemerkung.TabIndex = 6;
            richTextBox_Bemerkung.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Margin = new Padding(3, 8, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Bemerkung:";
            // 
            // txtBox_Datum
            // 
            txtBox_Datum.Location = new Point(89, 41);
            txtBox_Datum.Name = "txtBox_Datum";
            txtBox_Datum.PlaceholderText = "dd.MM.yyyy";
            txtBox_Datum.Size = new Size(149, 23);
            txtBox_Datum.TabIndex = 9;
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
            // Bearbeiten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 361);
            Controls.Add(btn_Jetzt_Ende);
            Controls.Add(btn_Jetzt_Start);
            Controls.Add(btn_Heute_Datum);
            Controls.Add(txtBox_Datum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox_Bemerkung);
            Controls.Add(txtBox_Ende);
            Controls.Add(label3);
            Controls.Add(txtBox_Start);
            Controls.Add(label2);
            Controls.Add(txtBox_ID);
            Controls.Add(label1);
            Name = "Bearbeiten";
            Text = "Bearbeiten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBox_ID;
        private TextBox txtBox_Start;
        private Label label2;
        private TextBox txtBox_Ende;
        private Label label3;
        private RichTextBox richTextBox_Bemerkung;
        private Label label4;
        private TextBox txtBox_Datum;
        private Label label5;
        private Button btn_Heute_Datum;
        private Button btn_Jetzt_Start;
        private Button btn_Jetzt_Ende;
    }
}