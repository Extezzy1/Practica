using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _6._3_gui
{
    public partial class Form1 : Form
    {
        //2.	Подсчитать сумму элементов, расположенных на побочной диагонали.
        //При решении задач из данного пункта использовать двумерный массив.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(EnterN.Text, out n) && n > 0)
            {
                int[,] mas = new int[n, n];
                Random rnd = new Random();
                resultTextBox.Text = "Изначальный массив:" + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = rnd.Next(0, 1000);
                        resultTextBox.Text += $"{mas[i, j]} ";
                    }
                    resultTextBox.Text += Environment.NewLine;
                }

                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += mas[i, n - i - 1];
                }
                resultTextBox.Text += Environment.NewLine + Environment.NewLine + $"Результат: {sum}";
            }
            else resultTextBox.Text = "Неверные данные!";
        }
    }
}
