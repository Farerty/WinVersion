using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
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
            const int i = 10;
            factorial(i);
        }
        public static void factorial(int i)
        {
            if (i == 0)
            {
                textBox1.Text = textBox1.Text + "И больше лунатиков не стало на луне" + Environment.NewLine;
                return;
            }
            if (i == 1)
            {
                textBox1.Text = textBox1.Text + "Последний лунатик жил на луне" + Environment.NewLine;
                textBox1.Text = textBox1.Text + "Последний лунатик ворочился во сне" + Environment.NewLine;
                textBox1.Text = textBox1.Text + "Последний из лунатиков упал с луны во сне" + Environment.NewLine;
            }
            else
            {
                textBox1.Text = textBox1.Text + i + " лунатиков жили на луне" + Environment.NewLine;
                textBox1.Text = textBox1.Text + i + " лунатиков ворочились во сне" + Environment.NewLine;
                textBox1.Text = textBox1.Text + "Один из лунатиков упал с луны во сне" + Environment.NewLine;

            }
            factorial(i - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Location = new Point(131, 60);
            textBox1.Height = 420;
            textBox1.Width = 240;
            textBox1.Name = "text_Box1";
            textBox1.Multiline = true;
            this.Controls.Add(textBox1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
