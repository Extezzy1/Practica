using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._4_gui
{
    public partial class Form1 : Form
    {
        //2.Четные столбцы таблицы заменить на вектор.
        //Для хранения массив n?n использовать ступенчатый массив.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, X;
            if (int.TryParse(textBox1.Text, out n) && n > 0)
            {
                int[][] mas = new int[n][];
                for (int i = 0; i < n; i++) mas[i] = new int[n];
                Random rnd = new Random();
                textBox2.Text = "Изначальный массив:" + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i][j] = rnd.Next(-1000, 1000);
                        textBox2.Text += $"{mas[i][j]} ";
                    }
                    textBox2.Text += Environment.NewLine;
                }

                textBox2.Text += Environment.NewLine + "Сгенерированный массив - вектор:" + Environment.NewLine;
                int[] VectorX = new int[n];
                for (int i = 0; i < n; i++)
                {
                    VectorX[i] = rnd.Next(-1000, 1000);
                    textBox2.Text += $"{VectorX[i]} ";
                }

                textBox2.Text += Environment.NewLine + Environment.NewLine + "Конечный массив: " + Environment.NewLine;
                for (int i = 0; i < n; i+=2)
                {
                    for(int j = 0; j < n; j++)
                    {
                        mas[j][i] = VectorX[j];
                    }
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        textBox2.Text += $"{mas[i][j]} ";
                    }
                    textBox2.Text += Environment.NewLine;
                }
            }
            else textBox2.Text = "Неверные входные данные!";
        }
    }
}
