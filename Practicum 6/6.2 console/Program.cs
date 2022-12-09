using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_console
{
    internal class Program
    {
        //2.	Заменить все максимальные элементы нулями.
        //Задачи из данного пункта решить, используя одномерный массив.
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введи количество строк массива (n) >> ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Неверное значение n!");
                Console.Write("Введи количество строк массива (n) >> ");
            }


            double[] mas = new double[n];
            EnterElArray(ref mas);

            double max = mas[0];
            for (int i = 1; i < mas.Length; i++)
                if (mas[i] > max) max = mas[i];

            for (int i = 1; i < mas.Length; i++)
                if (mas[i] == max) mas[i] = 0;


            ShowArray(mas);
        }

        // Метод, предназначенный для ввода элементов в массив
        static void EnterElArray(ref double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                double item;
                Console.Write($"Введи [{i}] элемент >> ");
                while (!double.TryParse(Console.ReadLine(), out item))
                {
                    Console.WriteLine("Неверное значение элемента!");
                    Console.Write($"Введи [{i}] элемент >> ");
                }
                mas[i] = item;

            }
        }

        // Метод, выводящий на экран значения массива
        static void ShowArray(double[] mas)
        {
            Console.WriteLine("Результат: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
    }
}
