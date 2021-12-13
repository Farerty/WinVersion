using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public static TextBox textBox3 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Location = new Point(181, 110);
            textBox3.Height = 120;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string p = "Компьютер - это то без чего в наше время не обойтись.";
            richTextBox1.Text = p;
            char c1 = Convert.ToChar(textBox2.Text);
            c1 = Char.ToLower(c1);
            char c2 = char.ToUpper(c1);
            int poz = Math.Max(p.IndexOf(c1), p.IndexOf(c2));

            while (poz != -1)
            {
                int l = poz, r = poz;
                bool b1 = true, b2 = true;
                while (b1 || b2)
                {
                    if (b1 && l > 0 && char.IsLetter(p[l])) l--; else b1 = false;
                    if (b2 && r < p.Length - 1 && char.IsLetter(p[r])) r++; else b2 = false;
                }
                p = p.Remove(l, r - l);
                poz = Math.Max(p.IndexOf(c1), p.IndexOf(c2));
            }
            textBox3.Text = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
