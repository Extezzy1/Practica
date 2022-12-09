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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            double a, b;
            if (int.TryParse(EnterN.Text, out n) && n > 0 && double.TryParse(EnterA.Text, out a) &&
                double.TryParse(EnterB.Text, out b) && int.TryParse(EnterM.Text, out m) && m > 0)
            {
                int[,] mas = new int[n,m];
                Random rnd = new Random();
                ResultTextBox.Text = "Изначальный массив:" + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = rnd.Next(0, 1000);
                        ResultTextBox.Text += $"{mas[i, j]} ";
                    }
                    ResultTextBox.Text += Environment.NewLine;
                }

                ResultTextBox.Text += Environment.NewLine + Environment.NewLine + "Конечный массив: " + Environment.NewLine;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mas[i, j] >= a && mas[i, j] <= b) mas[i, j] = 0;
                        ResultTextBox.Text += $"{mas[i, j]} ";
                    }
                    ResultTextBox.Text += Environment.NewLine;
                }


            }
            else ResultTextBox.Text = "Неверные данные!";
        }
    }
}
