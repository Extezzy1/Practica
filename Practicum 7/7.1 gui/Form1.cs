using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char s1, s2;
            String s = textBox3.Text;
            if (char.TryParse(textBox1.Text, out s1) && char.TryParse(textBox2.Text, out s2))
            {
                int counter1 = 0, counter2 = 0;
                foreach (char symbol in s)
                {
                    if (symbol == s1) counter1++;
                    if (symbol == s2) counter2++;
                }
                if (counter1 > counter2) textBox4.Text = $"Символ {s1} встречается чаще!";
                else if (counter1 < counter2) textBox4.Text = $"Символ {s2} встречается чаще!";
                else if (counter1 == 0 && counter2 == 0) textBox4.Text = "Заданные символы не встречаются в строке!";
                else textBox4.Text = "Заданные символы встречаются одинаковое количество раз!";
            }
            else textBox4.Text = "Неверные входные данные!";

        }
    }
}
