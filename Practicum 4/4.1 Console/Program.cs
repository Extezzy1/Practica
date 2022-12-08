using System;

namespace _4._1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = 5;
            Console.Write("Введи n >> ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0) {
                
                double res = calculateFunc(n, b1);
                Console.WriteLine($"Результат: {res}");
            }
            else Console.WriteLine("Неверное значение n!");
        }


        static double calculateFunc(int n, double b1)
        {
            if (n == 1) return b1;
            else if (n == 2) return (b1 / (n * n + n + 1));
            else return calculateFunc(n - 1, b1) / (n * n + n + 1);
        }

    
    }
}
