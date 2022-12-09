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
            // Написать программу, которая проверяет, является ли заданное целое число нечетным
            Console.Write("Введи число >> ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (Math.Abs(number) % 2 == 1) Console.WriteLine("Число является нечетным");
                else Console.WriteLine("Число не является нечетным");
            }
            else Console.WriteLine("Введенные данные должны быть целым числом!");
        }
    }
}
