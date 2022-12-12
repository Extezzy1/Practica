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

namespace _8._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int lenght = 0;
            if (int.TryParse(textBox2.Text, out lenght))
            {
                textBox3.Text = "";
                string[] str_split = str.Split(' ');
                int counter = 0;
                Regex regex = new Regex(@"\w");
                MatchCollection match;
                textBox3.Text += "Заданные слова: " + Environment.NewLine;
                foreach (string item in str_split)
                {
                    match = regex.Matches(item);
                    if (match.Count == lenght)
                    {
                        string res = "";
                        foreach (var x in match) res += x;
                        textBox3.Text += res + Environment.NewLine;
                        counter++;
                    }
                }
                if (counter == 0) textBox3.Text += "В заданном тексте нет подходящих слов!";
            }
            else MessageBox.Show("Введенное значение должно являться числом!");
        }
    }
}
