using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<Students> list = new List<Students>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Directory.GetFiles(@"C:\Рабочая папка\Ткачук").Length; i++)
            {
                Students a = new Students();
                
                
                listBox1.Items.Add(Directory.GetFiles(@"C:\Рабочая папка\Ткачук")[i].Remove(0, 24).TrimEnd(new Char[] { 't', 'x','t', '.' }));
                a.path = Directory.GetFiles(@"C:\Рабочая папка\Ткачук")[i];
                using (StreamReader reader = new StreamReader(a.path))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (line.Contains("ФИО="))
                        {
                            a.fio=line.Remove(0, 4);
                        }
                        else if (line.Contains("РОДИТЕЛЬ="))
                        {
                            a.Rod = line.Remove(0, 9);
                        }
                        else if (line.Contains("УНИВЕРСИТЕТ="))
                        {
                            a.univ = line.Remove(0, 12);
                        }
                        else if (line.Contains("БАЛЛ="))
                        {
                            a.ball = Convert.ToDouble(line.Remove(0, 5));
                        }

                    }
                }
                list.Add(a);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                list.Remove(list[listBox1.SelectedIndex]);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(list[listBox1.SelectedIndex].fio + "\n" + list[listBox1.SelectedIndex].Rod + "\n" + list[listBox1.SelectedIndex].univ + "\n" + list[listBox1.SelectedIndex].ball);
        }
    }
}
