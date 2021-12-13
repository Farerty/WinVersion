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

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int minLenghtLineIndex = 0;
            int minLenght = Int32.MaxValue;
            int counter = 1;
            
            foreach (string line in File.ReadLines(@"ter.txt"))
            {
                if (line.Length < minLenght)
                {
                    minLenght = line.Length;
                    minLenghtLineIndex = counter;
                }
                counter++;
            }

            textBox1.Text = Convert.ToString(minLenghtLineIndex);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
