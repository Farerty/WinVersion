using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        static int counter1 = counter;
        static int[,] b;
        static int max = 0;

        public static TextBox textBox2 = new TextBox();
        public static TextBox textBox3 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Location = new Point(141, 60);
            textBox2.Height = 120;
            textBox2.Width = 110;
            textBox2.Name = "text_Box2";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
            textBox3.Location = new Point(281, 60);
            textBox3.Height = 120;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }
        public static void MassivFuller()
        {

            Random rand = new Random();

            b = new int[counter, counter];

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    b[i, j] = rand.Next(1, 100);
                    textBox2.Text += (b[i, j] + " ");
                    if (j == counter - 1)
                    {
                        textBox2.Text += Environment.NewLine;
                    }
                }
            }

        }
        public static void MassivChanger()
        {
            int[] firstColon = new int[counter];
            int[] secondColon = new int[counter];
            for (int i = 0, c = counter - 1; i < counter; i++, c--)
            {

                if (i == counter / 2)
                {
                    break;
                }

                for (int j = 0; j < counter; j++)
                {
                    firstColon[j] = b[j, i];

                }
                for (int j = 0; j < counter; j++)
                {
                    secondColon[j] = b[j, c];

                }

                for (int j = 0; j < counter; j++)
                {
                    b[j, i] = secondColon[j];

                    b[j, c] = firstColon[j];

                }

            }
        }
        public static void Show1()
        {
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    textBox3.Text += (b[i, j] + " ");
                    if (j == counter - 1)
                    {
                        textBox3.Text += Environment.NewLine;
                    }
                }
            }
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
                MassivChanger();
                Show1();
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
