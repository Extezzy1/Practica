using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (int.TryParse(textBox1.Text, out int a))
            {
                if (int.TryParse(textBox2.Text, out int b))
                {
                    if (int.TryParse(textBox3.Text, out int h))
                    {

                        if (a < b)
                        {
                            for (int i = a; i <= b; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();
                                    textBox4.Text += $"f({i})={Math.Round(Math.Exp((Math.Pow((i - 1), 2) / i)), 5)}" + Environment.NewLine;
                                }
                                catch (DivideByZeroException ex)
                                {
                                    textBox4.Text += $"В точке {i} функция не существует!" + Environment.NewLine;
                                }

                            }
                        }
                        else if (a > b)
                        {
                            for (int i = b; i <= a; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();
                                    textBox4.Text += $"f({i})={Math.Round(Math.Exp((Math.Pow((i - 1), 2) / i)), 5)}" + Environment.NewLine;
                                }
                                catch (DivideByZeroException ex)
                                {
                                    textBox4.Text += $"В точке {i} функция не существует!" + Environment.NewLine;
                                }

                            }
                        }
                        else textBox4.Text = "Значения a и b должны быть разными!";
                    }
                    else textBox4.Text = "Неверное значение h!";
                }
                else textBox4.Text = "Неверное значение b!";
            }
            else textBox4.Text = "Неверное значение a!";
        }
    }
}
