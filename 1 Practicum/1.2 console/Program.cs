using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число >> ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number % 2 == 1) Console.WriteLine("Число является нечетным");
                else Console.WriteLine("Число не является нечетным");
            }
            else Console.WriteLine("Введенные данные должны быть числом!");
        }
    }
}
