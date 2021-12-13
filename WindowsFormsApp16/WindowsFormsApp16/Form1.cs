using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public static TextBox textBox3 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = false;
            
            StringBuilder str = new StringBuilder(textBox1.Text);
            textBox3.Text = "Исходная строка " + str;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                    f = true;
            }
            if (f == true)
                textBox2.Text = "Есть одинаковые символы";
            else
                textBox2.Text = "Нет одинаковых символов";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Location = new Point(10, 70);
            textBox3.Height = 40;
            textBox3.Width = 195;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
           
        }
    }
}
