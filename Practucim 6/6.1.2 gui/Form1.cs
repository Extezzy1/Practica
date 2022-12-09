using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1._2_gui
{
    public partial class Form1 : Form
    {
        //2.	Заменить все элементы, попадающие в интервал  [a, b], нулем.
        //Задачи из данного пункта решить двумя способами, используя одномерный массив, а затем двумерный.
        //Размерность массива вводится с клавиатуры.
        // Двумерный массив
        private int n, m;
        private int[,] mas;
        private int i = 0, j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(EnterA.Text, out double a) && double.TryParse(EnterB.Text, out double b))
            {
                ResultTextBox.Text = "Изначальный массив: " + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        ResultTextBox.Text += $"{mas[i, j]} ";
                    }
                    ResultTextBox.Text += Environment.NewLine;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mas[i, j] <= b && mas[i, j] >= a) mas[i, j] = 0;
                    }
                }
                ResultTextBox.Text += Environment.NewLine + "Массив после преобразований: " + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        ResultTextBox.Text += $"{mas[i, j]} ";
                    }
                    ResultTextBox.Text += Environment.NewLine;
                }
            }
            else MessageBox.Show("Введены неверные данные!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (int.TryParse(textBox1.Text, out int number))
                {
                    if (i == n - 1 && j == m - 1) textBox1.ReadOnly = true;
                    mas[i, j] = number;
                    j++;
                    if (j == m)
                    {
                        j = 0;
                        i++;
                    }
                    textBox1.Text = "";
                }
                else MessageBox.Show("Значение должно быть целым числом!");
            }
        }

        private void EnterM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.textBox1.ReadOnly = false;

                if (!int.TryParse(EnterN.Text, out this.n) || !int.TryParse(EnterM.Text, out this.m) || n < 0 || m < 0)
                {
                    MessageBox.Show("Неверное значение!");
                }
                else this.mas = new int[n, m];
            }
        }
    }
}
