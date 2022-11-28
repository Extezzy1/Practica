using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дана точка на плоскости с координатами(х, у). 
            //Составить программу, которая выдает одно из сообщений «Да», «Нет», «На границе»
            //в зависимости от того, лежит ли точка внутри заштрихованной области,
            //вне заштрихованной области или на ее границе.
            Console.Write("Введи координату x >> ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.Write("Введи координату y >> ");
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    int r1 = 25;
                    int r2 = 100;
                    double squareSum = x * x + y * y;

                    if (squareSum == r1 || squareSum == r2) Console.WriteLine("На границе");
                    else if (squareSum > r1 && squareSum < r2) Console.WriteLine("Да");
                    else Console.WriteLine("Нет");
                }
                else Console.WriteLine("Введено неверное значение y");
            }
            else Console.WriteLine("Введено неверное значение x");
        }
    }
}
