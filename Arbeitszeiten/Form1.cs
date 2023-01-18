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

        //string firstArgument = CommandLineArguments.Args[0];

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            DateTime dateTime_Start = Convert.ToDateTime(txtBox_Start.Text);
            DateTime dateTime_Ende = Convert.ToDateTime(txtBox_Ende.Text);
            TimeSpan timeSpan = dateTime_Ende - dateTime_Start;

            lbl_Differenz.Text = Convert.ToDecimal(timeSpan.TotalHours).ToString("#.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox_Start.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox_Ende.Text = DateTime.Now.AddHours(+8.5).ToString();
        }
    }
}