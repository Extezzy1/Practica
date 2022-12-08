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
            double a, b, h;
            if (double.TryParse(textBox1.Text, out a))
            {
                if (double.TryParse(textBox2.Text, out b))
                {
                    if (double.TryParse(textBox3.Text, out h))
                    {
                        if (h <= 0)
                        {
                            textBox4.Text = "h должно быть больше нуля!";
                            return;
                        }

                        if (a < b)
                        {
                            for (double i = a; i <= b; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();
                                    textBox4.Text += $"f({i})={fx(i)}" + Environment.NewLine;
                                }
                                catch (DivideByZeroException ex)
                                {
                                    textBox4.Text += $"В точке {i} функция не существует!" + Environment.NewLine;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }

                            }
                        }
                        else if (a > b)
                        {
                            for (double i = b; i <= a; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();
                                    textBox4.Text += $"f({i})={fx(i)}" + Environment.NewLine;
                                }
                                catch (DivideByZeroException ex)
                                {
                                    textBox4.Text += $"В точке {i} функция не существует!" + Environment.NewLine;
                                }
                                catch (Exception ex)
                                {
                                    textBox4.Text += $"В точке {i} функция не существует!";
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

        static double fx(double i)
        {
            return Math.Round(Math.Exp((Math.Pow((i - 1), 2) / i)), 5);
        }
    }
}
