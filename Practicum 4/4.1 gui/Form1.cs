using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b1 = 5;
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {

                double res = calculateFunc(n, b1);
                richTextBox1.Text = $"Результат: {res}";
            }
            else richTextBox1.Text = "Неверное значение n!";
        }


        static double calculateFunc(int n, double b1)
        {
            if (n == 1) return b1;
            else if (n == 2) return (b1 / (n * n + n + 1));
            else return calculateFunc(n - 1, b1) / (n * n + n + 1);
        }

    }
}
