using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public static TextBox textBox3 = new TextBox();
        public static TextBox textBox4 = new TextBox();
        public static TextBox textBox5 = new TextBox();


        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                f1();
                f2();
                f3();
           
            
        }
        public void f1()
            {
                bool doAnyDop = true, doAny = true; 
                int counter = 0;

                double kursOfRubl = 0;
                    try
                    {
                        kursOfRubl = Convert.ToDouble(textBox1.Text);
                        
                    }
                    catch
                    {
                        
                        doAny = false;
            }
                do
                {
                    counter += 5;
                    if(doAny)
                        textBox3.Text = textBox3.Text + Convert.ToString(counter * kursOfRubl) + Environment.NewLine;
                    if(counter == 120)
                    {
                        doAnyDop = false;
                    }
                } while (doAnyDop == true);
            }
            public  void f2()
            {
                bool doAnyDop = true, doAny = true;
            int counter = 0;
                double kursOfRubl = 0;

                    try
                    {

                        kursOfRubl = Convert.ToDouble(textBox1.Text);
                    }
                    catch
                    {
                        
                        doAny = false;
            }
                
                while (doAnyDop == true)
                {
                    counter += 5;
                if (doAny)
                    textBox4.Text = textBox4.Text + Convert.ToString(counter * kursOfRubl) + Environment.NewLine;
                    if (counter == 120)
                    {
                        doAnyDop = false;
                    }
            }
            }
            public  void f3()
            {
                bool doAnyDop = true, doAny = true;
            int counter = 0;
            double n;
                double kursOfRubl = 0;
                    try
                    {

                        kursOfRubl = Convert.ToDouble(textBox1.Text);
                    }
                    catch
                    {
                        doAny = false;
                    }
                for (; doAnyDop == true;)
                {
                    counter += 5;
                    n = counter * kursOfRubl;
                if (doAny)
                    textBox5.Text = textBox5.Text + Convert.ToString(n) + Environment.NewLine;
                    
                    
                    if (counter == 120)
                    {
                        doAnyDop = false;
                    }
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label textbox3_label = new Label();
            textbox3_label.Location = new Point(217,120);
            textbox3_label.Text = "do_while";
            textbox3_label.AutoSize = true;
            this.Controls.Add(textbox3_label);

            textBox3.Location = new Point(211, 140);
            textBox3.Height = 320;
            textBox3.Width = 110;
            textBox3.Name = "text_Box3";
            textBox3.Multiline = true;
            this.Controls.Add(textBox3);

            Label textbox4_label = new Label();
            textbox4_label.Location = new Point(330, 120);
            textbox4_label.Text = "while";
            textbox4_label.AutoSize = true;
            this.Controls.Add(textbox4_label);

            textBox4.Location = new Point(320, 140);
            textBox4.Height = 320;
            textBox4.Width = 110;
            textBox4.Name = "text_Box4";
            textBox4.Multiline = true;
            this.Controls.Add(textBox4);

            Label textbox5_label = new Label();
            textbox5_label.Location = new Point(430, 120);
            textbox5_label.Text = "for";
            textbox5_label.AutoSize = true;
            this.Controls.Add(textbox5_label);

            textBox5.Location = new Point(428, 140);
            textBox5.Height = 320;
            textBox5.Width = 110;
            textBox5.Name = "text_Box5";
            textBox5.Multiline = true;
            this.Controls.Add(textBox5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
