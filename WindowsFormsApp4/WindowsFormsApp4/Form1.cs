using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool goToNextNum = true;
            int n = 0;
            int k = 0;
            
                try
                {
                    
                    n = Convert.ToInt32(textBox1.Text);
                    
                    k = Convert.ToInt32(textBox2.Text);
                    if (1 <= n && n <= 4 && 6 <= k && k <= 14)
                    {
                        goToNextNum = true;
                        
                    }
                    
                    else
                    {
                        MessageBox.Show("You can input 6 and more card numbers");
                        goToNextNum = false;
                }
                }
                catch
                {
                   MessageBox.Show("Invalid Number");
                }

            if (goToNextNum)
            {
                    if (n == 0)
                    {
                        n += 1;
                    }

                    switch (n)
                    {
                        case 1: textBox3.Text = "Пики";  textBox3.Text = textBox3.Text + " " + mast1(k); break;
                        case 2: Console.WriteLine("Черви"); textBox3.Text = textBox3.Text + " " + mast2(k); break;
                        case 3: Console.WriteLine("Крести"); textBox3.Text = textBox3.Text + " " + mast3(k); break;
                        case 4: Console.WriteLine("Бубны"); textBox3.Text = textBox3.Text + " " + mast4(k); break;
                    }
            }
        }
        public static string mast1(int k)
        {
            string s = "none";
            switch (k)
            {

                case 6: return"Шестёрка пик";
                case 7: return "Семёрка пик";
                case 8: return "Восьмёрка пик";
                case 9: return "Девятка пик"; 
                case 10: return "Десятка пик"; 
                case 11: return "Валет вини"; 
                case 12: return "Дама пик";
                case 13: return "Король пик";
                case 14: return "Туз пик";
            }
            return s;
        }

        public static string mast2(int k)
        {
            string s = "none";
            switch (k)
            {

                case 6: return "Шестёрка черви"; 
                case 7: return "Семёрка черви"; 
                case 8: return "Восьмёрка черви";
                case 9: return "Девятка черви";
                case 10: return "Десятка черви";
                case 11: return "Валет черви";
                case 12: return "Дама черви";
                case 13: return "Король черви";
                case 14: return "Туз черви";
            }
            return s;
        }

        public static string mast3(int k)
        {
            string s = "none";
            switch (k)
            {

                case 6: return "Шестёрка треф";
                case 7: return "Семёрка треф";
                case 8: return "Восьмёрка треф";
                case 9: return "Девятка треф";
                case 10: return "Десятка треф";
                case 11: return "Валет треф";
                case 12: return "Дама треф";
                case 13: return "Король треф";
                case 14: return "Туз крести";
            }
            return s;
        }
        public static string mast4(int k)
        {
            string s = "none";
            switch (k)
            {

                case 6: return "Шестёрка бубен";
                case 7: return "Семёрка бубен";
                case 8: return "Восьмёрка бубенк";
                case 9: return "Девятка бубен";
                case 10: return "Десятка бубен";
                case 11: return"Валет бубен";
                case 12: return "Дама бубен";
                case 13: return "Король бубен";
                case 14: return"Туз бубен";
            }
            return s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
 }


    
    }

        

