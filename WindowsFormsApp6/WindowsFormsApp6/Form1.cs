using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public static TextBox textBox2 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool doAny = true;
            int numberOfStrok = 0;
            try
            {
                numberOfStrok = Convert.ToInt32(textBox1.Text);
                doAny = true;
            }
            catch
            {
                MessageBox.Show("Invalid Number");
                doAny = false;
            }
            if (doAny)
            {
                rekFun(numberOfStrok);
            }
            
        }
        public static int rekFun(int n)
        {
            if (n == 1 || n == 0)
            {
                textBox2.Text = textBox2.Text + Convert.ToString(1) + Environment.NewLine; 
                return 1;
            }
            for (int i = 0; i < n; i++)
            {
                textBox2.Text = textBox2.Text + 1 + " ";
                if (i == n - 1)
                {
                    textBox2.Text = textBox2.Text + Environment.NewLine;
                }
            }
            return rekFun(n - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label textbox2_label = new Label();
            textbox2_label.Location = new Point(150, 120);
            textbox2_label.Text = "Результат";
            textbox2_label.AutoSize = true;
            this.Controls.Add(textbox2_label);

            textBox2.Location = new Point(150, 140);
            textBox2.Height = 200;
            textBox2.Width = 110;
            textBox2.Name = "text_Box3";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
        }
    }
}
