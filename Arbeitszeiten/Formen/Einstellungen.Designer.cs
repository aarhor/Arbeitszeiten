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
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Pfad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Minuten = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(194, 41);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_Speichern.TabIndex = 0;
            this.btn_Speichern.Text = "Erstellen";
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
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBox_Minuten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Pfad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Speichern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(297, 220);
            this.MinimumSize = new System.Drawing.Size(297, 220);
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
        private Label label2;
        private Label label3;
        private TextBox txtBox_Minuten;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
    }
}