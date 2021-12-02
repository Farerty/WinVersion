using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public static TextBox textBox1 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberFirst = 0, numberSecond = 0, numberOfresultSum = 0;
            
            try
                {
                    
                    numberFirst = Convert.ToInt32(textBox4.Text);
                    
                    numberSecond = Convert.ToInt32(textBox5.Text);
                    
                }
                catch
                {
                    MessageBox.Show("Invalid number");
                }
            numberFirst = LitleNumber(numberFirst);
            numberSecond = LitleNumber(numberSecond);
            numberOfresultSum = numberFirst + numberSecond;
            textBox1.Text = textBox1.Text + Convert.ToString(numberOfresultSum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Location = new Point(211, 140);
            textBox1.Height = 20;
            textBox1.Width = 110;
            textBox1.Name = "text_Box3";
            textBox1.Multiline = true;
            this.Controls.Add(textBox1);
        }
        public static int LitleNumber(int n)
        {
            int numberWithoutEnd = 1;
            numberWithoutEnd = n;
            n /= 10;
            n *= 10;
            numberWithoutEnd = numberWithoutEnd - n;
            return numberWithoutEnd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
    
}
