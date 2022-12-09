using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Четные столбцы таблицы заменить на вектор.
            //Для хранения массив n?n использовать ступенчатый массив.
            int n;
            Console.Write("Введи размерность массива (n) >> ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Неверное значение n! n должно быть числом большим нуля");
                Console.Write("Введи размерность массива (n) >> ");
            }

            int[][] mas = new int[n][];
            
            for (int i = 0; i < n; i++) mas[i] = new int[n];

            EnterElArray(ref mas);
            int[] XVector = new int[n];
            for (int i = 0; i < n; i++)
            {
                int item;
                Console.Write($"Введи [{i}] элемент вектора >> ");
                while (!int.TryParse(Console.ReadLine(), out item))
                {
                    Console.WriteLine("Неверное значение ряда!");
                    Console.Write($"Введи [{i}] элемент вектора >> ");
                }
                XVector[i] = item;
            }

            Console.WriteLine("Изначальный массив: ");
            ShowArray(mas);

            for (int i = 0; i < n; i += 2)
            {
                for(int j = 0; j < n; j++)
                {
                    mas[j][i] = XVector[j];
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Конечный массив: ");
            ShowArray(mas);

        }
        // Метод, предназначенный для ввода элементов в массив
        static void EnterElArray(ref int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    int item;
                    Console.Write($"Введи [{i}][{j}] элемент >> ");
                    while (!int.TryParse(Console.ReadLine(), out item))
                    {
                        Console.WriteLine("Неверное значение ряда!");
                        Console.Write($"Введи [{i}][{j}] элемент >> ");
                    }
                    mas[i][j] = item;
                }
            }
        }

        // Метод, выводящий на экран значения массива
        static void ShowArray(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write($"{mas[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
