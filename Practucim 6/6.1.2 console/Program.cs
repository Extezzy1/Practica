using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2_console
{
    internal class Program
    {
        //2.	Заменить все элементы, попадающие в интервал  [a, b], нулем.
        //Задачи из данного пункта решить двумя способами, используя одномерный массив, а затем двумерный.
        //Размерность массива вводится с клавиатуры.
        // Двумерный массив
        static void Main(string[] args)
        {
            int n, m, a, b;

            Console.Write("Введи количество строк массива (n) >> ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Console.Write("Введи количество столбцов массива (m) >> ");
                if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                {
                    Console.Write("Введи a >> ");
                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.Write("Введи b >> ");
                        if (int.TryParse(Console.ReadLine(), out b))
                        {
                            if (a >= b)
                            {
                                Console.WriteLine("a должно быть меньше b!");
                                return;
                            }
                            else
                            {
                                int[,] mas = new int[n, m];
                                EnterElArray(ref mas, n, m);

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < m; j++)
                                    {
                                        if (mas[i, j] <= b && mas[i, j] >= a) mas[i, j] = 0;
                                    }
                                }

                                ShowArray(mas, n, m);
                            }
                        }
                        else Console.WriteLine("Неверное значение b");
                    }
                    else Console.WriteLine("Неверное значение a");
                }
                else Console.WriteLine("Неверное значение m");
            }
            else Console.WriteLine("Неверное значение n");
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
            Console.WriteLine("Результат: ");
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
