using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_console
{
    internal class Program
    {
        //2.	Подсчитать сумму элементов, расположенных на побочной диагонали.
        //При решении задач из данного пункта использовать двумерный массив.
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введи количество строк массива (n) >> ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Неверное значение n! n должно быть числом большим нуля");
                Console.Write("Введи количество строк массива (n) >> ");
            }
            
            int[,] mas = new int[n, n];
            EnterElArray(ref mas, n, n);

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += mas[i, n - i - 1];
            }
            Console.WriteLine($"Результат: {sum}");
            ShowArray(mas, n, n);
        }

        // Метод, предназначенный для ввода элементов в массив
        static void EnterElArray(ref int[,] mas, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int item;
                    Console.Write($"Введи [{i}][{j}] элемент >> ");
                    while (!int.TryParse(Console.ReadLine(), out item))
                    {
                        Console.WriteLine("Неверное значение ряда!");
                        Console.Write($"Введи [{i}][{j}] элемент >> ");
                    }
                    mas[i, j] = item;
                }
            }
        }

        // Метод, выводящий на экран значения массива
        static void ShowArray(int[,] mas, int n, int m)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
