using System;
using System.Windows.Forms;


namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        WorkWithMas a;
        public Form1()
        {
            InitializeComponent();
        }
        
            
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numberOfMassive = "";

                a = new WorkWithMas(Convert.ToInt32(textBox1.Text));
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
                richTextBox2.Text += "Отсортированный массив:" ;
                richTextBox2.Text += a.MassivShowev() + Environment.NewLine;//показ отсорт массива

                int y = a[0];
                textBox5.Text = Convert.ToString(y);
                int[] u = new int[a.SizeOfMassiv];
                u = a;
                richTextBox2.Text += "Преобразованный в int массив: " ;
                for(int i = 0; i< a.SizeOfMassiv; i++)
                {
                    richTextBox2.Text += u[i] + " ";//int массив = класс объекту
                }
                richTextBox2.Text += Environment.NewLine; 
                a = u;
                richTextBox2.Text += "Преобразованный в объект класса int массив: "; 
                richTextBox2.Text += a.MassivShowev()+Environment.NewLine;
                int scal = a.ScalUmOnMassiv = Convert.ToInt32(textBox2.Text);
                richTextBox2.Text += "Домноженный на скаляр исходный массив: " ; 
                richTextBox2.Text += a.MassivShowev()+ Environment.NewLine;
                

                textBox3.Text = Convert.ToString(a.SizeOfMassiv);
                a++;
                richTextBox2.Text += "Увеличенный на 1 массив, изменённый скаляром: ";
                richTextBox2.Text += a.MassivShowev()+ Environment.NewLine;
                a--;
                richTextBox2.Text += "Уменьшенный на 1 массив, изменённый ранее на 1: ";
                richTextBox2.Text += a.MassivShowev() + Environment.NewLine;
                a = a * scal;
                richTextBox2.Text += "Умноженный другим способом массив на тот же скаляр: " ; 
                richTextBox2.Text += a.MassivShowev() + Environment.NewLine;
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
            

        }
    }
}
