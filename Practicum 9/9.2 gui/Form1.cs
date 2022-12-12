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

namespace _9._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int biggest_lenght = 0;
            string biggest_line = "";
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > biggest_lenght)
                    {
                        biggest_lenght = line.Length;
                        biggest_line = line;
                    }

                }
            }
            if (biggest_lenght == 0) textBox2.Text = "Файл пуст!";
            else
            {
                textBox2.Text = $"Длина самой длинной строки - {biggest_lenght}" + Environment.NewLine;
                textBox2.Text += $"Самая длинная строка - {biggest_line}";
            }
        }
    }
}
