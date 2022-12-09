using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            String str = textBox1.Text;
            string[] str_split = str.Split(' ');
            int counter = 0;
            char[] UselessSymbols = { '!', '.', ',', '?', ':', ';', '@', '"' };
            textBox2.Text = "Искомые слова: " + Environment.NewLine;
            foreach (string word in str_split)
            {
                foreach (char symbol in alphabet)
                {
                    if (symbol == word[0])
                    {
                        textBox2.Text += $"{word.Trim(UselessSymbols)}" + Environment.NewLine;
                        counter++;
                        break;
                    }
                }
            }
            if (counter == 0) textBox2.Text += "Заданная строка не содержит подходящих слов!";
        }
    }
}
