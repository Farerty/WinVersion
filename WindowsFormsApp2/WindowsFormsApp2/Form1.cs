using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double theA = 0, theB = 0, TheC = 0;

                try
                {
                    theA = Convert.ToDouble(textBox1.Text);

                    theB = Convert.ToDouble(textBox2.Text);
                    
                    TheC = Convert.ToDouble(textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Number");
                }
        
            
            textBox4.Text = Convert.ToString(resultOfUr(theA, theB, TheC));
            
        }
        public static bool resultOfUr(double a, double b, double c)
        {
            double result = b * b - 4 * a * c;
            if (result <= 0)
            {
                return false;
            }
            else if (result > 0)
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}

