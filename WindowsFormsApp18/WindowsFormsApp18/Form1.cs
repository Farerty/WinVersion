using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Компьютер – это электронно-вычислительная машина, способная выполнять заданную последовательность операций, называемую программой. Само слово «компьютер» произошло от английских to compute («вычислять») и computer («вычислитель»).";
           richTextBox1.Text = str;
            var newtext = Regex.Replace(str, "[-.?!)(,:]", "");
            richTextBox2.Text = newtext;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
