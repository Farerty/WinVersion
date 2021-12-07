using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public static TextBox textBox2 = new TextBox();
        public static TextBox textBox3 = new TextBox();

        static int counter;
        static double[] a;
        static double[,] b;
        static double max = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Location = new Point(131, 90);
            textBox2.Height = 120;
            textBox2.Width = 110;
            textBox2.Name = "text_Box2";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
            textBox3.Location = new Point(291, 90);
            textBox3.Height = 120;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool doAnyDop = true;
            try
            {
                
                counter = Convert.ToInt32(textBox1.Text);
                doAnyDop = false;
            }
            catch
            {
               MessageBox.Show("invalid number");
            }
            if(doAnyDop == false)
            {
                MassivFuller();
                doAny();
            }
        }
        public static void MassivFuller()
        {

            Random rand = new Random();
            a = new double[counter];
            b = new double[counter, counter];

            for (int i = 0; i < counter; i++)
            {
                a[i] = rand.Next(1, 100);

            }
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    b[i, j] = rand.Next(1, 100);

                }
            }

        }
        public static void MAx()
        {
            max = a[0];
            for (int i = 0; i < counter; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }

        }
        public static void MAx(bool flag)
        {
            max = b[0, 0];
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    if (max < b[i, j])
                    {
                        max = b[i, j];
                    }
                }
            }
        }
        public static void doAny()
        {
            MAx();
            
            for (int i = 0; i < counter; i++)
            {
                if (a[i] != max)
                {
                    textBox2.Text += i + " ";
                }
            }
            Console.WriteLine();
            bool flag = true;
            MAx(flag);
            
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    if (b[i, j] < max)
                    {
                        textBox3.Text +=  i +"," + j + " | ";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
