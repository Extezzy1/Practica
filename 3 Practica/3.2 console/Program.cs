using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи значение a >> ");
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                Console.Write("Введи значение b >> ");
                if (double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.Write("Введи значение h >> ");
                    if (double.TryParse(Console.ReadLine(), out double h))
                    {
                        for (double i = a; i <= b; i += h)
                        {
                            Console.WriteLine("f({0:f2})={1:f4}", i, calculateFunc(i));
                        }

                    }
                    else Console.WriteLine("Введенные данные должны являться числами!");
                }
                else Console.WriteLine("Введенные данные должны являться числами!");
            }
            else Console.WriteLine("Введенные данные должны являться числами!");
        }

        static double calculateFunc(double x)
        {
            if (Math.Abs(x) < 3) return Math.Sin(x);
            if (Math.Abs(x) >= 9) return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            return Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5);
        }
    }
}
