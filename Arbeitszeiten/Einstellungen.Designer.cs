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
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Pfad = new System.Windows.Forms.TextBox();
            this.btn_Neustart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(79, 41);
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
            this.txtBox_Pfad.Size = new System.Drawing.Size(182, 23);
            this.txtBox_Pfad.TabIndex = 2;
            // 
            // btn_Neustart
            // 
            this.btn_Neustart.Location = new System.Drawing.Point(186, 41);
            this.btn_Neustart.Name = "btn_Neustart";
            this.btn_Neustart.Size = new System.Drawing.Size(75, 23);
            this.btn_Neustart.TabIndex = 3;
            this.btn_Neustart.Text = "Neustarten";
            this.btn_Neustart.UseVisualStyleBackColor = true;
            this.btn_Neustart.Click += new System.EventHandler(this.btn_Neustart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sicherung erstellen:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Neustart);
            this.Controls.Add(this.txtBox_Pfad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Speichern);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Speichern;
        private Label label1;
        private TextBox txtBox_Pfad;
        private Button btn_Neustart;
        private Label label2;
        private Button button1;
    }
}