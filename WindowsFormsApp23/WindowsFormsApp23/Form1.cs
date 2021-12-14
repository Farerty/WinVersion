using System;
using System.Windows.Forms;


namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        DoAny a;
        public Form1()
        {
            InitializeComponent();
        }
        
            
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numberOfMassive = "";

                a = new DoAny(Convert.ToInt32(textBox1.Text));
                numberOfMassive = richTextBox1.Text;
                int sizeForCheck = numberOfMassive.Length;
                char d = ' ';
                if (numberOfMassive[sizeForCheck - 1] == d) { }
                else
                {
                    numberOfMassive += " ";
                }

                a.MassivFuller(numberOfMassive);
                a.sort();
                richTextBox2.Text = a.MassivShowev();//показ отсорт массива
                int y = a[0];
                textBox5.Text = Convert.ToString(y);
                int[] u = new int[a.SizeOfMassiv];
                u = a;
                for(int i = 0; i< a.SizeOfMassiv; i++)
                {
                    richTextBox3.Text += u[i] + " ";//int массив = класс объекту
                }
                a = u;
                richTextBox4.Text = a.MassivShowev();
                int scal = a.ScalUmOnMassiv = Convert.ToInt32(textBox2.Text);
                richTextBox5.Text = a.MassivShowev();
                //умноженные на скаляр
                // ёбанный сыр а так можно было....

                textBox3.Text = Convert.ToString(a.SizeOfMassiv);
                a++;
                richTextBox6.Text = a.MassivShowev();
                a--;
                richTextBox7.Text = a.MassivShowev();
                a = a * scal;
                richTextBox8.Text = a.MassivShowev();
                textBox4.Text = Convert.ToString(!a);
            }
            catch
            {
                richTextBox1.Text = "несоответствие данных";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
            richTextBox8.Text = "";

        }
    }
}
