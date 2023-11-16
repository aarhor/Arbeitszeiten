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
            domainUpDown_Monat = new DomainUpDown();
            label1 = new Label();
            label2 = new Label();
            domainUpDown_Jahr = new DomainUpDown();
            lbl_Startzeit = new Label();
            lbl_Endzeit = new Label();
            lbl_Arbeitszeit = new Label();
            lbl_Ueberstunden = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            weiteresToolStripMenuItem = new ToolStripMenuItem();
            löschenToolStripMenuItem = new ToolStripMenuItem();
            lbl_Datum = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
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
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(131, 268);
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
            button1.Location = new Point(362, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Suchen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // domainUpDown_Monat
            // 
            domainUpDown_Monat.Items.Add("Januar");
            domainUpDown_Monat.Items.Add("Februar");
            domainUpDown_Monat.Items.Add("März");
            domainUpDown_Monat.Items.Add("April");
            domainUpDown_Monat.Items.Add("Mai");
            domainUpDown_Monat.Items.Add("Juni");
            domainUpDown_Monat.Items.Add("Juli");
            domainUpDown_Monat.Items.Add("August");
            domainUpDown_Monat.Items.Add("September");
            domainUpDown_Monat.Items.Add("Oktober");
            domainUpDown_Monat.Items.Add("November");
            domainUpDown_Monat.Items.Add("Dezember");
            domainUpDown_Monat.Location = new Point(221, 27);
            domainUpDown_Monat.Name = "domainUpDown_Monat";
            domainUpDown_Monat.ReadOnly = true;
            domainUpDown_Monat.Size = new Size(135, 23);
            domainUpDown_Monat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Monat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 58);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Jahr:";
            // 
            // domainUpDown_Jahr
            // 
            domainUpDown_Jahr.Items.Add("2022");
            domainUpDown_Jahr.Items.Add("2023");
            domainUpDown_Jahr.Items.Add("2024");
            domainUpDown_Jahr.Items.Add("2025");
            domainUpDown_Jahr.Items.Add("2026");
            domainUpDown_Jahr.Items.Add("2027");
            domainUpDown_Jahr.Items.Add("2028");
            domainUpDown_Jahr.Items.Add("2029");
            domainUpDown_Jahr.Items.Add("2030");
            domainUpDown_Jahr.Items.Add("2031");
            domainUpDown_Jahr.Items.Add("2032");
            domainUpDown_Jahr.Items.Add("2033");
            domainUpDown_Jahr.Items.Add("2034");
            domainUpDown_Jahr.Items.Add("2035");
            domainUpDown_Jahr.Items.Add("2036");
            domainUpDown_Jahr.Items.Add("2037");
            domainUpDown_Jahr.Items.Add("2038");
            domainUpDown_Jahr.Items.Add("2039");
            domainUpDown_Jahr.Items.Add("2040");
            domainUpDown_Jahr.Items.Add("2041");
            domainUpDown_Jahr.Items.Add("2042");
            domainUpDown_Jahr.Items.Add("2043");
            domainUpDown_Jahr.Items.Add("2044");
            domainUpDown_Jahr.Items.Add("2045");
            domainUpDown_Jahr.Items.Add("2046");
            domainUpDown_Jahr.Items.Add("2047");
            domainUpDown_Jahr.Items.Add("2048");
            domainUpDown_Jahr.Items.Add("2049");
            domainUpDown_Jahr.Items.Add("2050");
            domainUpDown_Jahr.Items.Add("2051");
            domainUpDown_Jahr.Items.Add("2052");
            domainUpDown_Jahr.Items.Add("2053");
            domainUpDown_Jahr.Items.Add("2054");
            domainUpDown_Jahr.Items.Add("2055");
            domainUpDown_Jahr.Items.Add("2056");
            domainUpDown_Jahr.Items.Add("2057");
            domainUpDown_Jahr.Items.Add("2058");
            domainUpDown_Jahr.Items.Add("2059");
            domainUpDown_Jahr.Items.Add("2060");
            domainUpDown_Jahr.Items.Add("2061");
            domainUpDown_Jahr.Items.Add("2062");
            domainUpDown_Jahr.Items.Add("2063");
            domainUpDown_Jahr.Items.Add("2064");
            domainUpDown_Jahr.Items.Add("2065");
            domainUpDown_Jahr.Items.Add("2066");
            domainUpDown_Jahr.Items.Add("2067");
            domainUpDown_Jahr.Items.Add("2068");
            domainUpDown_Jahr.Items.Add("2069");
            domainUpDown_Jahr.Items.Add("2070");
            domainUpDown_Jahr.Items.Add("2071");
            domainUpDown_Jahr.Items.Add("2072");
            domainUpDown_Jahr.Items.Add("2073");
            domainUpDown_Jahr.Items.Add("2074");
            domainUpDown_Jahr.Items.Add("2075");
            domainUpDown_Jahr.Items.Add("2076");
            domainUpDown_Jahr.Items.Add("2077");
            domainUpDown_Jahr.Items.Add("2078");
            domainUpDown_Jahr.Items.Add("2079");
            domainUpDown_Jahr.Items.Add("2080");
            domainUpDown_Jahr.Items.Add("2081");
            domainUpDown_Jahr.Items.Add("2082");
            domainUpDown_Jahr.Items.Add("2083");
            domainUpDown_Jahr.Items.Add("2084");
            domainUpDown_Jahr.Items.Add("2085");
            domainUpDown_Jahr.Items.Add("2086");
            domainUpDown_Jahr.Items.Add("2087");
            domainUpDown_Jahr.Items.Add("2088");
            domainUpDown_Jahr.Items.Add("2089");
            domainUpDown_Jahr.Items.Add("2090");
            domainUpDown_Jahr.Items.Add("2091");
            domainUpDown_Jahr.Items.Add("2092");
            domainUpDown_Jahr.Items.Add("2093");
            domainUpDown_Jahr.Items.Add("2094");
            domainUpDown_Jahr.Items.Add("2095");
            domainUpDown_Jahr.Items.Add("2096");
            domainUpDown_Jahr.Items.Add("2097");
            domainUpDown_Jahr.Items.Add("2098");
            domainUpDown_Jahr.Items.Add("2099");
            domainUpDown_Jahr.Items.Add("2100");
            domainUpDown_Jahr.Location = new Point(221, 56);
            domainUpDown_Jahr.Name = "domainUpDown_Jahr";
            domainUpDown_Jahr.ReadOnly = true;
            domainUpDown_Jahr.Size = new Size(135, 23);
            domainUpDown_Jahr.TabIndex = 5;
            // 
            // lbl_Startzeit
            // 
            lbl_Startzeit.AutoSize = true;
            lbl_Startzeit.Location = new Point(163, 110);
            lbl_Startzeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Startzeit.Name = "lbl_Startzeit";
            lbl_Startzeit.Size = new Size(52, 15);
            lbl_Startzeit.TabIndex = 6;
            lbl_Startzeit.Text = "Startzeit:";
            // 
            // lbl_Endzeit
            // 
            lbl_Endzeit.AutoSize = true;
            lbl_Endzeit.Location = new Point(167, 133);
            lbl_Endzeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Endzeit.Name = "lbl_Endzeit";
            lbl_Endzeit.Size = new Size(48, 15);
            lbl_Endzeit.TabIndex = 7;
            lbl_Endzeit.Text = "Endzeit:";
            // 
            // lbl_Arbeitszeit
            // 
            lbl_Arbeitszeit.AutoSize = true;
            lbl_Arbeitszeit.Location = new Point(158, 156);
            lbl_Arbeitszeit.Margin = new Padding(3, 8, 3, 0);
            lbl_Arbeitszeit.Name = "lbl_Arbeitszeit";
            lbl_Arbeitszeit.Size = new Size(57, 15);
            lbl_Arbeitszeit.TabIndex = 8;
            lbl_Arbeitszeit.Text = "Differenz:";
            // 
            // lbl_Ueberstunden
            // 
            lbl_Ueberstunden.AutoSize = true;
            lbl_Ueberstunden.Location = new Point(137, 179);
            lbl_Ueberstunden.Margin = new Padding(3, 8, 3, 0);
            lbl_Ueberstunden.Name = "lbl_Ueberstunden";
            lbl_Ueberstunden.Size = new Size(78, 15);
            lbl_Ueberstunden.TabIndex = 9;
            lbl_Ueberstunden.Text = "Überstunden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 202);
            label3.Margin = new Padding(3, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "Bemerkung:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(144, 220);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(293, 63);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { weiteresToolStripMenuItem, löschenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(448, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // weiteresToolStripMenuItem
            // 
            weiteresToolStripMenuItem.Enabled = false;
            weiteresToolStripMenuItem.Name = "weiteresToolStripMenuItem";
            weiteresToolStripMenuItem.Size = new Size(75, 20);
            weiteresToolStripMenuItem.Text = "Bearbeiten";
            weiteresToolStripMenuItem.Click += weiteresToolStripMenuItem_Click;
            // 
            // löschenToolStripMenuItem
            // 
            löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            löschenToolStripMenuItem.Size = new Size(63, 20);
            löschenToolStripMenuItem.Text = "Löschen";
            löschenToolStripMenuItem.Click += löschenToolStripMenuItem_Click;
            // 
            // lbl_Datum
            // 
            lbl_Datum.AutoSize = true;
            lbl_Datum.Location = new Point(169, 87);
            lbl_Datum.Margin = new Padding(3, 8, 3, 0);
            lbl_Datum.Name = "lbl_Datum";
            lbl_Datum.Size = new Size(46, 15);
            lbl_Datum.TabIndex = 13;
            lbl_Datum.Text = "Datum:";
            // 
            // Statistiken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 292);
            Controls.Add(lbl_Datum);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(lbl_Ueberstunden);
            Controls.Add(lbl_Arbeitszeit);
            Controls.Add(lbl_Endzeit);
            Controls.Add(lbl_Startzeit);
            Controls.Add(domainUpDown_Jahr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainUpDown_Monat);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(464, 312);
            Name = "Statistiken";
            Text = "Statistiken";
            Load += Statistiken_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DomainUpDown domainUpDown_Monat;
        private Label label1;
        private Label label2;
        private DomainUpDown domainUpDown_Jahr;
        private Label lbl_Startzeit;
        private Label lbl_Endzeit;
        private Label lbl_Arbeitszeit;
        private Label lbl_Ueberstunden;
        private Label label3;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem weiteresToolStripMenuItem;
        private DataGridViewTextBoxColumn Col_Datum;
        private DataGridViewTextBoxColumn Col_id;
        private ToolStripMenuItem löschenToolStripMenuItem;
        private Label lbl_Datum;
    }
}