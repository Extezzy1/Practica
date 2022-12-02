using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                if (double.TryParse(textBox2.Text, out double q))
                {
                    if (double.TryParse(textBox3.Text, out double b1))
                    {
                        if (q == 1) richTextBox1.Text = "Знаменатель не может быть равен единице!";
                        else
                        {
                            double sum = b1;
                            double b = 0;
                            Sum(b1, q, n, ref sum);
                            CalculateFunc(b1, q, n, ref b);
                            richTextBox1.Text += $"Сумма первых {n} членов прогресии равна: {sum}" + Environment.NewLine;
                            richTextBox1.Text += $"{n} член прогрессии равен: {b}";
                        }

                    }
                    else MessageBox.Show("Неверное значение первого члена прогрессии!");
                }
                else MessageBox.Show("Неверное значение знаменателя прогрессии!");

            }
            else MessageBox.Show("Неверное значение n!");
        }

        static void CalculateFunc(double b1, double q, int n, ref double b, int i = 1)
        {

            if (n > i)
            {
                b = b1 * q;
                i++;
                CalculateFunc(b, q, n, ref b, i);
            }

        }


        static void Sum(double b1, double q, int n, ref double sum, int i = 1)
        {

            if (n > i)
            {

                double b = b1 * q;
                sum += b;
                i++;
                Sum(b, q, n, ref sum, i);
            }

        }
    }
}
