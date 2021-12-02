using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        static double numberOfBegin, numberOfEnd;
        static double h;
        static double[] a;

        static int counter;
        public Form1()
        {
            InitializeComponent();
        }

        public static TextBox textBox4 = new TextBox();
        public static TextBox textBox5 = new TextBox();

        
        public static void doAny()
        {
            bool flag = true;
            for (double i = numberOfBegin; i < numberOfEnd; i += h)
            {
                counter++;
            }
            a = new double[counter];
            int counter1 = 0;
            
            for (double i = numberOfBegin; i < numberOfEnd; i += h)
            {
                SearchOfF(i, out a[counter1]);
                counter1++;
            }
            Show1();
            counter1 = 0;
            for (double i = numberOfBegin; i < numberOfEnd; i += h)
            {
                a[counter1] = SearchOfF(i);
                counter1++;
            }
            Show1(flag);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Location = new Point(281, 140);
            textBox4.Height = 120;
            textBox4.Width = 110;
            textBox4.Name = "text_Box4";
            textBox4.Multiline = true;
            this.Controls.Add(textBox4);
            textBox5.Location = new Point(421, 140);
            textBox5.Height = 120;
            textBox5.Width = 110;
            textBox5.Name = "text_Box4";
            textBox5.Multiline = true;
            this.Controls.Add(textBox5);
        }
        private static void Show1()
        {
            
                for (int i = 0; i < counter; i++)
                {
                   textBox4.Text = textBox4.Text + Convert.ToString(a[i]);
                    if (i == 4 && i % 4 == 0)
                    {
                        textBox4.Text = textBox4.Text + Environment.NewLine;
                    }
                }
        }
        private static void Show1(bool flag)
        {
            
            for (int i = 0; i < counter; i++)
            {
                textBox5.Text = textBox5.Text + Convert.ToString(a[i]);
                if (i == 4 && i % 4 == 0)
                {
                    textBox5.Text = textBox5.Text + Environment.NewLine;
                }
            }
        }
        public static double SearchOfF(double x)

        {
            if ((x * x - 5 * x) < 0)
            {
                return numberOfBegin + numberOfEnd;
            }
            else if (0 <= (x * x - 5 * x) && (x * x - 5 * x) < 10)
            {
                return numberOfBegin - numberOfEnd;
            }
            else if ((x * x - 5 * x) >= 10)
            {
                return numberOfBegin * numberOfEnd;
            }
            else
            {
                return 0;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool doDopAny = true;
            try
            {

                numberOfBegin = Convert.ToDouble(textBox1.Text);

                numberOfEnd = Convert.ToDouble(textBox2.Text);

                h = Convert.ToDouble(textBox3.Text);
                if (numberOfBegin % h == 0 && numberOfEnd % h == 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Invalid number");
            }

            doAny();


            
        }

        public static void SearchOfF(double x, out double y)
        {
            if ((x * x - 5 * x) < 0)
            {
                y = numberOfBegin + numberOfEnd;
            }
            else if (0 <= (x * x - 5 * x) && (x * x - 5 * x) < 10)
            {
                y = numberOfBegin - numberOfEnd;
            }
            else if ((x * x - 5 * x) >= 10)
            {
                y = numberOfBegin * numberOfEnd;
            }
            else
            {
                y = 0;
            }
        }
    }
    
}
