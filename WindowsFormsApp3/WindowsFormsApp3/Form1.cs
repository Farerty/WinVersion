using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"\AAAAAA.png";
            string pathDop = "";
            pathDop = Path.GetFullPath(path);
            System.IO.FileStream fs = new System.IO.FileStream(pathDop,System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pictureBox1.Image = img;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           double x = 0, y = 0;
            
            
                try
                {
                    
                    x = Convert.ToDouble(textBox1.Text);
                    
                    y = Convert.ToDouble(textBox1.Text);
                    
                }
                catch
                {
                    MessageBox.Show("Invalid number");
                }

            
            if (Math.Abs(x * x) + Math.Abs(y * y) > 15 * 15 && Math.Abs(x * x) + Math.Abs(y * y) < 25 * 25)
            {
                textBox3.Text = "Вне";
            }
            else if (Math.Abs(x * x) + Math.Abs(y * y) < 15 * 15)
            {
                textBox3.Text = "Внутри";
            }

            else if (Math.Abs(x * x) + Math.Abs(y * y) > 25 * 25)
            {
                textBox3.Text = "Внутри";
            }
            else
            {
                textBox3.Text = "на границе";
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
