using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_console
{
    class Program
    {
        //2.	Заменить все элементы, попадающие в интервал  [a, b], нулем.
        //Задачи из данного пункта решить двумя способами, используя одномерный массив, а затем двумерный.
        //Размерность массива вводится с клавиатуры.
        // Одномерный массив
        static void Main(string[] args)
        {
            int n;
            double a, b;

            Console.Write("Введи количество строк массива (n) >> ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Неверное значение n!");
                Console.Write("Введи количество строк массива (n) >> ");
            }

            Console.Write("Введи a >> ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверное значение a!");
                Console.Write("Введи a >> ");
            }

            Console.Write("Введи b >> ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неверное значение b!");
                Console.Write("Введи b >> ");
            }

            int[] mas = new int[n];
            EnterElArray(ref mas);

            for (int i = 0; i < mas.Length; i++)
                if (mas[i] <= b && mas[i] >= a) mas[i] = 0;

            ShowArray(mas);
        }

        // Метод, предназначенный для ввода элементов в массив
        static void EnterElArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                int item;
                Console.Write($"Введи [{i}] элемент >> ");
                while (!int.TryParse(Console.ReadLine(), out item))
                {
                    Console.WriteLine("Неверное значение элемента!");
                    Console.Write($"Введи [{i}] элемент >> ");
                }
                mas[i] = item;
                
            }
        }

        // Метод, выводящий на экран значения массива
        static void ShowArray(int[] mas)
        {
            Console.WriteLine("Результат: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
    }
}
