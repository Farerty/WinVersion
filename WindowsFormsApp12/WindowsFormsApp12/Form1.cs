using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        static int counter;
        static int[] a;
        static int[,] b;
        static int max = 0;
        static int maxDop = 0;

        public static TextBox textBox2 = new TextBox();
        public static TextBox textBox3 = new TextBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Location = new Point(251, 140);
            textBox2.Height = 120;
            textBox2.Width = 110;
            textBox2.Name = "text_Box2";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
            textBox3.Location = new Point(401, 140);
            textBox3.Height = 120;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }
        public static void MassivFuller()
        {

            Random rand = new Random();
            a = new int[counter];
            b = new int[counter, counter];
            for (int i = 0; i < counter; i++)
            {
                a[i] = rand.Next(1, 100);
                max += a[i];
            }
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    b[i, j] = rand.Next(1, 100);
                    maxDop += b[i, j];
                }
            }
            textBox2.Text = "Среднее арифмитеское одномерного массива " + max / counter;
            textBox3.Text = "Среднее арифмитеское двумерного массива " + maxDop / counter;
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
