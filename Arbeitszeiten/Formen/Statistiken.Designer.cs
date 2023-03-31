namespace Arbeitszeiten
{
    partial class Statistiken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistiken));
            dataGridView1 = new DataGridView();
            Col_Datum = new DataGridViewTextBoxColumn();
            Col_id = new DataGridViewTextBoxColumn();
            button1 = new Button();
            domainUpDown1 = new DomainUpDown();
            label1 = new Label();
            label2 = new Label();
            domainUpDown2 = new DomainUpDown();
            lbl_Startzeit = new Label();
            lbl_Endzeit = new Label();
            lbl_Arbeitszeit = new Label();
            lbl_Ueberstunden = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_Datum, Col_id });
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(131, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Col_Datum
            // 
            Col_Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Datum.HeaderText = "Datum";
            Col_Datum.Name = "Col_Datum";
            Col_Datum.ReadOnly = true;
            Col_Datum.Resizable = DataGridViewTriState.False;
            Col_Datum.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_id
            // 
            Col_id.HeaderText = "_id";
            Col_id.Name = "Col_id";
            Col_id.ReadOnly = true;
            Col_id.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(362, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Suchen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("Januar");
            domainUpDown1.Items.Add("Februar");
            domainUpDown1.Items.Add("März");
            domainUpDown1.Items.Add("April");
            domainUpDown1.Items.Add("Mai");
            domainUpDown1.Items.Add("Juni");
            domainUpDown1.Items.Add("Juli");
            domainUpDown1.Items.Add("August");
            domainUpDown1.Items.Add("September");
            domainUpDown1.Items.Add("Oktober");
            domainUpDown1.Items.Add("November");
            domainUpDown1.Items.Add("Dezember");
            domainUpDown1.Location = new Point(221, 7);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(135, 23);
            domainUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Monat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 38);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Jahr:";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Items.Add("2022");
            domainUpDown2.Items.Add("2023");
            domainUpDown2.Items.Add("2024");
            domainUpDown2.Items.Add("2025");
            domainUpDown2.Items.Add("2026");
            domainUpDown2.Location = new Point(221, 36);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(135, 23);
            domainUpDown2.TabIndex = 5;
            // 
            // lbl_Startzeit
            // 
            lbl_Startzeit.AutoSize = true;
            lbl_Startzeit.Location = new Point(163, 70);
            lbl_Startzeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Startzeit.Name = "lbl_Startzeit";
            lbl_Startzeit.Size = new Size(52, 15);
            lbl_Startzeit.TabIndex = 6;
            lbl_Startzeit.Text = "Startzeit:";
            // 
            // lbl_Endzeit
            // 
            lbl_Endzeit.AutoSize = true;
            lbl_Endzeit.Location = new Point(167, 93);
            lbl_Endzeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Endzeit.Name = "lbl_Endzeit";
            lbl_Endzeit.Size = new Size(48, 15);
            lbl_Endzeit.TabIndex = 7;
            lbl_Endzeit.Text = "Endzeit:";
            // 
            // lbl_Arbeitszeit
            // 
            lbl_Arbeitszeit.AutoSize = true;
            lbl_Arbeitszeit.Location = new Point(158, 116);
            lbl_Arbeitszeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Arbeitszeit.Name = "lbl_Arbeitszeit";
            lbl_Arbeitszeit.Size = new Size(57, 15);
            lbl_Arbeitszeit.TabIndex = 8;
            lbl_Arbeitszeit.Text = "Differenz:";
            // 
            // lbl_Ueberstunden
            // 
            lbl_Ueberstunden.AutoSize = true;
            lbl_Ueberstunden.Location = new Point(137, 139);
            lbl_Ueberstunden.Margin = new Padding(3, 8, 3, 0);
            lbl_Ueberstunden.Name = "lbl_Ueberstunden";
            lbl_Ueberstunden.Size = new Size(78, 15);
            lbl_Ueberstunden.TabIndex = 9;
            lbl_Ueberstunden.Text = "Überstunden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 162);
            label3.Margin = new Padding(3, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "Bemerkung:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(144, 180);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(315, 63);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // Statistiken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 255);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(lbl_Ueberstunden);
            Controls.Add(lbl_Arbeitszeit);
            Controls.Add(lbl_Endzeit);
            Controls.Add(lbl_Startzeit);
            Controls.Add(domainUpDown2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(487, 294);
            MinimumSize = new Size(487, 294);
            Name = "Statistiken";
            Text = "Statistiken";
            Load += Statistiken_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DomainUpDown domainUpDown1;
        private Label label1;
        private Label label2;
        private DomainUpDown domainUpDown2;
        private Label lbl_Startzeit;
        private Label lbl_Endzeit;
        private Label lbl_Arbeitszeit;
        private Label lbl_Ueberstunden;
        private DataGridViewTextBoxColumn Col_Datum;
        private DataGridViewTextBoxColumn Col_id;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}