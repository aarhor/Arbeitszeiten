namespace Arbeitszeiten.Formen
{
    partial class Bemerkung
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
            button1 = new Button();
            txtBox_Bemerkung = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Wie lautet die Bemerkung?";
            // 
            // button1
            // 
            button1.Location = new Point(60, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox_Bemerkung
            // 
            txtBox_Bemerkung.Location = new Point(12, 27);
            txtBox_Bemerkung.Name = "txtBox_Bemerkung";
            txtBox_Bemerkung.Size = new Size(180, 23);
            txtBox_Bemerkung.TabIndex = 2;
            // 
            // Bemerkung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 91);
            Controls.Add(txtBox_Bemerkung);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(222, 130);
            MinimumSize = new Size(222, 130);
            Name = "Bemerkung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bemerkung";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtBox_Bemerkung;
    }
}