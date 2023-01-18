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
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Start = new System.Windows.Forms.TextBox();
            this.txtBox_Ende = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Differenz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(70, 79);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_Speichern.TabIndex = 0;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Startzeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endzeit:";
            // 
            // txtBox_Start
            // 
            this.txtBox_Start.Location = new System.Drawing.Point(70, 6);
            this.txtBox_Start.Name = "txtBox_Start";
            this.txtBox_Start.Size = new System.Drawing.Size(110, 23);
            this.txtBox_Start.TabIndex = 3;
            // 
            // txtBox_Ende
            // 
            this.txtBox_Ende.Location = new System.Drawing.Point(70, 35);
            this.txtBox_Ende.Name = "txtBox_Ende";
            this.txtBox_Ende.Size = new System.Drawing.Size(110, 23);
            this.txtBox_Ende.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Manuell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Manuell";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Differenz:";
            // 
            // lbl_Differenz
            // 
            this.lbl_Differenz.AutoSize = true;
            this.lbl_Differenz.Location = new System.Drawing.Point(70, 61);
            this.lbl_Differenz.Name = "lbl_Differenz";
            this.lbl_Differenz.Size = new System.Drawing.Size(0, 15);
            this.lbl_Differenz.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 115);
            this.Controls.Add(this.lbl_Differenz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Ende);
            this.Controls.Add(this.txtBox_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Speichern);
            this.Name = "Form1";
            this.Text = "Arbeitszeiterfassung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Speichern;
        private Label label1;
        private Label label2;
        private TextBox txtBox_Start;
        private TextBox txtBox_Ende;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label lbl_Differenz;
    }
}