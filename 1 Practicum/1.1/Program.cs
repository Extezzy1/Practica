using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, которая подсчитывает расстояние между точками с координатами a, b и с,d;
            Console.Write("Введи координату a >> ");
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                Console.Write("Введи координату b >> ");
                if (double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.Write("Введи координату c >> ");
                    if (double.TryParse(Console.ReadLine(), out double c))
                    {
                        Console.Write("Введи координату d >> ");
                        if (double.TryParse(Console.ReadLine(), out double d))
                        {
                            double resNumber = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));
                            Console.Write($"\nИскомым расстояние является число - {resNumber}\n");
                        }
                        else Console.WriteLine("Введенные данные должны быть числом!");
                    }
                    else Console.WriteLine("Введенные данные должны быть числом!");
                }
                else Console.WriteLine("Введенные данные должны быть числом!");
            }
            else Console.WriteLine("Введенные данные должны быть числом!");
        }
    }
}
