using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        static int m, n, d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {

                m = Convert.ToInt32(textBox1.Text);

                n = Convert.ToInt32(textBox2.Text);
                flag = false;

            }
            catch
            {
                MessageBox.Show("invalid number");
            }

            if (flag == false)
            {
                d = factorial(m, n);
                textBox3.Text = Convert.ToString(d);
            }
        }
        public static int factorial(int m, int n)
        {
            if (n == m)
            {
                return 1;
            }
            else if (m == 0)
            {
                return 1;
            }
            else if (n > m && m > 0)
            {
                return factorial(m, n - 1) + factorial(m - 1, n - 1);

            }
            else
            {
                return 0;
            }
        }
        
        
    }
}
