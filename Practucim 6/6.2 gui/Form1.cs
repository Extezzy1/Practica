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

namespace _6._2_gui
{
    public partial class Form1 : Form
    {
        //2.	Заменить все максимальные элементы нулями.
        //Задачи из данного пункта решить, используя одномерный массив.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EnterN.Text, out int n) && n > 0)
            {
                double[] mas = new double[n];
                Random rnd = new Random();
                ResultTextBox.Text = "Изначальный массив:" + Environment.NewLine;
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(0, 1000);
                    ResultTextBox.Text += $"{mas[i]} ";
                }

                ResultTextBox.Text += Environment.NewLine + Environment.NewLine + "Конечный массив: " + Environment.NewLine;


                double max = mas[0];
                for (int i = 1; i < mas.Length; i++)
                    if (mas[i] > max) max = mas[i];

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == max) mas[i] = 0;
                    ResultTextBox.Text += $"{mas[i]} ";
                }

            }
            else ResultTextBox.Text = "Неверные данные!";
        }
    }
}
