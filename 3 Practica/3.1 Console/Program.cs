using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи значение x >> ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.Write("Введи значение y >> ");
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    Console.WriteLine($"Значение Z = {max(x, 2 * y - x) + max(5 * x + 3 * y, y)}");
                }
                else Console.WriteLine("Введенные значения должны быть числами!");
            }
            else Console.WriteLine("Введенные значения должны быть числами!");
        }
        static double max(double number1, double number2) => number1 > number2 ? number1 : number2;
    }
}
