//using Arbeitszeiten;

using static Arbeitszeiten.Program;

namespace Arbeitszeiten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstArgument = CommandLineArguments.Args[0];


            label1.Text = firstArgument;
        }
    }
}