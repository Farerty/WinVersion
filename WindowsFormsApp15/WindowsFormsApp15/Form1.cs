using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public static TextBox textBox2 = new TextBox();
        public static TextBox textBox3 = new TextBox();
        static int counter = 0;
        static int counter1 = counter;
        static int[] a;
        static int[][] b;
        static int max = 0;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Location = new Point(70, 100);
            textBox2.Height = 70;
            textBox2.Width = 110;
            textBox2.Name = "text_Box2";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
            textBox3.Location = new Point(200, 70);
            textBox3.Height = 120;
            textBox3.Width = 200;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            try
            {
                
               
                    counter = Convert.ToInt32(textBox1.Text);
                    Flag = false;
                
            }
            catch
            {
                MessageBox.Show("invalid number");
            }
            if(Flag == false)
            {
                MassivFuller();
                Show1();

                
                Show1(flag);
            }
        }
        private static void MassivFuller()
        {

            Random rand = new Random();

            b = new int[counter][];
            a = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                b[i] = new int[counter];
                for (int j = 0; j < counter; j++)
                {
                    b[i][j] = rand.Next(-10, 30);
                    if (b[i][j] > 0)
                    {
                        a[i] += 1;
                    }

                }
            }


        }

        private static void Show1()
        {
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    textBox2.Text += b[i][j] + " ";
                    if (j == counter - 1)
                    {
                        textBox2.Text += Environment.NewLine;
                    }
                }
            }
        }
        private static void Show1(bool flag)
        {
            for (int i = 0; i < counter; i++)
            {
                textBox3.Text += "Для строки " +(i+1)+ " количество положительных элементов " + a[i]+ Environment.NewLine;
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
