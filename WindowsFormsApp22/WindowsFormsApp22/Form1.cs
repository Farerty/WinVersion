using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        
        static int[] IntArray;
        static int n;
        static List<int> list = new List<int>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numberOfMassive = "";
                
            
                    numberOfMassive = richTextBox1.Text;
                    int sizeForCheck = numberOfMassive.Length;
                    char d = ' ';
                    if(numberOfMassive[sizeForCheck-1] == d){}
                    else
                    {
                        numberOfMassive += " ";
                    }
                    
                    n = Convert.ToInt32(textBox1.Text);

                    int u = MassivFuller(numberOfMassive);
                    if(u == 1)
                    {
                        throw new Exception();
                    }
                sort();
                for (int i = 0; i < n; i++)
                {
                    richTextBox2.Text += IntArray[i] + " ";
                }
                ScalUmOnMassiv = Convert.ToInt32(textBox2.Text);
                for (int i = 0; i < n; i++)
                {
                    richTextBox3.Text += IntArray[i] + " ";
                }
                textBox3.Text = Convert.ToString(SizeOfMassiv);
            }
            catch
            {
                richTextBox1.Text = "несоответствие данных";
            }
            
            
        }
        public static int MassivFuller(string numberOfMassive)
        {
            string s = "";
            int suze = 0;
            
            for(int i = 0; i<numberOfMassive.Length; i++)
            {
                char c = numberOfMassive[i];
                if(c.ToString() == " " ){
                    int counter = 0;
                    counter = Convert.ToInt32(s);
                    list.Add(counter);
                    suze++;
                    s = "";

                }
                else
                {
                    s += c;
                }
            }
           
            if(n> suze || n < suze)
            {
                return 1;
            }
            
            IntArray = new int[suze];
            for(int i = 0; i < suze; i++)
            {
                IntArray[i] = list[i];
            }
            return 0;
        }
        
        public static void sort()
        {
            Array.Sort(IntArray);
        }

        int SizeOfMassiv
        {
            get { return n; }

        }
        int ScalUmOnMassiv
        {
            set
            {
                int scal = value;
                for (int i = 0; i < n; i++)
                {
                    IntArray[i] = IntArray[i] * scal;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            list.Clear();
        }
    }
}
