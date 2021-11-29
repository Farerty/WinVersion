using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double theA = 0, theB = 0;
            
                try
                {
                    
                    theA = Convert.ToDouble(textBox1.Text);
                    
                    theB = Convert.ToDouble(textBox2.Text);
                    
                }
                catch
                {
                    MessageBox.Show("Invalid Number");
                }
            double theC = 0;
            theC = Math.Sqrt(theA * theA + theB * theB);
            textBox3.Text = Convert.ToString(theC);
        }
    }
}
