using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_console
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
                        double y = 0;
                        for (double i = a; i <= b; i += h)
                        {
                            calculateFunc(i, out y);
                            Console.WriteLine("f({0:f2})={1:f4}", i, y);
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

        static void calculateFunc(double x, out double y)
        {
            if (Math.Abs(x) < 3) y = Math.Sin(x);
            else if (Math.Abs(x) >= 9) y = Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            else y = Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5);
        }
    }
}
