using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public static TextBox textBox2 = new TextBox();
        public static TextBox textBox3 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            using (BinaryWriter BW = new BinaryWriter(File.Open(@"mas.bin", FileMode.Create)))
            {
                bool Flag = true;
                int count = 0;
                
                    try
                    {
                        count = Convert.ToInt32(textBox1.Text);
                        Flag = false;
                    }
                    catch
                    {
                        textBox1.Text = "invalid number";
                    }
                

                if (Flag == false)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int number = rnd.Next(-10, 11);
                        if (number < 0)
                        {
                            BW.Write(number);
                        }
                       textBox2.Text += number + " ";
                    }
                    BW.Close();
                    
                    using (BinaryReader BR = new BinaryReader(File.Open(@"mas.bin", FileMode.Open)))
                    {
                        List<int> list = new List<int>();
                        while (BR.BaseStream.Position != BR.BaseStream.Length)
                        {
                            list.Add(BR.ReadInt32());
                        }
                        textBox3.Text += string.Join(" ", list);
                        BR.Close();
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Location = new Point(181, 80);
            textBox2.Height = 120;
            textBox2.Width = 110;
            textBox2.Name = "text_Box2";
            textBox2.Multiline = true;
            this.Controls.Add(textBox2);
            textBox3.Location = new Point(321, 80);
            textBox3.Height = 120;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
