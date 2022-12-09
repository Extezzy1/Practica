﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1._1_gui
{
    public partial class Form1 : Form
    {
        //2.	Заменить все элементы, попадающие в интервал  [a, b], нулем.
        //Задачи из данного пункта решить двумя способами, используя одномерный массив, а затем двумерный.
        //Размерность массива вводится с клавиатуры.
        // Одномерный массив
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EnterN.Text, out int n) && n > 0 && int.TryParse(EnterA.Text, out int a) &&
                int.TryParse(EnterB.Text, out int b))
            {
                int[] mas = new int[n];
                Random rnd = new Random();
                ResultTextBox.Text = "Изначальный массив:" + Environment.NewLine;
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(a - 10, b);
                    ResultTextBox.Text += $"{mas[i]} ";
                }

                ResultTextBox.Text += Environment.NewLine + Environment.NewLine + "Конечный массив: " + Environment.NewLine;

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] >= a && mas[i] <= b) mas[i] = 0;
                    ResultTextBox.Text += $"{mas[i]} ";
                }
                

            }
            else ResultTextBox.Text = "Неверные данные!";
        }

    }
}
