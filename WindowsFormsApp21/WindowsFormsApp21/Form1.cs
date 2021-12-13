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

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        string strTxt1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов", strTxt2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
        StringBuilder strTxt3 = new StringBuilder();
        string path1 = @"C:\temp\K1\";
        string path2 = @"C:\temp\K2\";
        DirectoryInfo dirInfo = new DirectoryInfo(@"C:\temp");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                strTxt3.Append(strTxt1);
                strTxt3.Append("\n");
                strTxt3.Append(strTxt2);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                else
                {
                    dirInfo.Delete(true);
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory("K1");
                FileStream textInK1 = File.Create(path1 + @"\t1.txt");
                textInK1.Close();
                StreamWriter sw1 = new StreamWriter(path1 + @"\t1.txt");
                sw1.WriteLine(strTxt1);
                dirInfo.CreateSubdirectory("K2");
                FileStream textInK2 = File.Create(path1 + @"\t2.txt");
                textInK2.Close();
                FileStream txt3 = File.Create(path2 + @"\t3.txt");
                txt3.Close();
                StreamWriter swTXT2 = new StreamWriter(path1 + @"\t2.txt", false);
                StreamWriter swTXT3 = new StreamWriter(path2 + @"\t3.txt", false);
                swTXT2.WriteLine(strTxt2);
                sw1.Close();
                swTXT2.Close();
                swTXT3.Write(strTxt3.ToString());
                swTXT3.Close();
                StreamReader srTXT1 = new StreamReader(path1 + @"\t1.txt");
                richTextBox1.Text = "Первый файл с распололжением " + path1 + "t1.txt";
                richTextBox1.Text += Environment.NewLine + srTXT1.ReadToEnd().ToString();
                
                richTextBox1.Text += "Второй файл с распололжением " + path1 + "t2.txt";
                StreamReader srTXT2 = new StreamReader(path1 + @"\t2.txt");
                richTextBox1.Text += Environment.NewLine + srTXT2.ReadToEnd().ToString();
                richTextBox1.Text += "Третий файл с распололжением " + path2 + "t3.txt";
                StreamReader srTXT3 = new StreamReader(path2 + @"\t3.txt");
                richTextBox1.Text += Environment.NewLine + srTXT3.ReadToEnd().ToString() + Environment.NewLine;
                srTXT1.Close();
                srTXT2.Close();
                srTXT3.Close();
                File.Move(path1 + @"\t1.txt", path2 + @"\t1.txt");
                File.Move(path1 + @"\t2.txt", path2 + @"\t2.txt");
                Directory.Move(path2, @"C:\temp\ALL");
                Directory.Delete(@"C:\temp\K1", true);
                string[] files = Directory.GetFiles(@"C:\temp\ALL");
                foreach (string File in files)
                {
                    richTextBox1.Text += File;
                }

            }
            catch
            {
                richTextBox1.Text = "Какая-то ошибка";
            }
        }
    }
}
