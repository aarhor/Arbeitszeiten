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
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        async void Changelog_darstellen()
        {
            string HTML_Quellcode = Properties.Resources.Aenderungen;

            await webView.EnsureCoreWebView2Async();
            webView.NavigateToString(HTML_Quellcode);
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            Changelog_darstellen();
        }
    }
}
