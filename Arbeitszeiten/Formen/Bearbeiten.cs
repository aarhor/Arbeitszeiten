using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitszeiten.Formen
{
    public partial class Bearbeiten : Form
    {
        public Bearbeiten()
        {
            InitializeComponent();
        }

        private void btn_Jetzt_Ende_Click(object sender, EventArgs e)
        {
            txtBox_Ende.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Jetzt_Start_Click(object sender, EventArgs e)
        {
            txtBox_Start.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Heute_Datum_Click(object sender, EventArgs e)
        {
            txtBox_Datum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
