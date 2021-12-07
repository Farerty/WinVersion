using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public static double num1, num2, h;
        public static TextBox textBox4 = new TextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Location = new Point(281, 160);
            textBox4.Height = 180;
            textBox4.Width = 180;
            textBox4.Name = "text_Box4";
            textBox4.Multiline = true;
            this.Controls.Add(textBox4);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private static double DoImpotantThing(double i)
        {

            try
            {
                if (i == 1)
                {
                    throw new Exception();
                }
                else
                {
                    return Math.Log10(i - 1);
                }
            }
            catch
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private static void DiaOfGr()
        {
            for (double i = num1; i < num2; i += h)
            {
                try
                {
                    textBox4.Text += "y(" + i + ") = " + DoImpotantThing(i) + Environment.NewLine;
                }
                catch
                {
                    MessageBox.Show("y(" + i + ") = error");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool doDopAny = true;
            try
            {
               
                num1 = Convert.ToDouble(textBox1.Text);
                if (num1 < 0)
                {
                    throw new Exception();
                }
                
                num2 = Convert.ToDouble(textBox2.Text);
                if (num2 < num1 || num2 == 0)
                {
                    throw new Exception();
                }
                
                h = Convert.ToDouble(textBox3.Text);
                if (h <= 0)
                {
                    throw new Exception();
                }
                doDopAny = false;
            }
            catch
            { 
                MessageBox.Show("Либо вы ввели в качестве конца 0, что не имеет смысла.");
                MessageBox.Show("Либо вы ввели что-то не то, либо ввели не правильное начало диапазона!\n Или вы настолько приисполнились, что начало диапазона больше его конца?");
               
            }
            if(doDopAny == false)
            {
                DiaOfGr();

            }
            
        }
    }
}
