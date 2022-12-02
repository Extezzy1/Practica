using System;

namespace _4._2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введи n >> ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.Write("Введи знаменатель прогрессии >> ");
                if (double.TryParse(Console.ReadLine(), out double q))
                {
                    Console.Write("Введи первый член прогрессии >> ");
                    if (double.TryParse(Console.ReadLine(), out double b1)) {
                        if (q == 1)
                        {
                            Console.WriteLine("Знаменатель не может быть равен единице!");
                            return;
                        }
                        double sum = b1;
                        double b = 0;
                        Sum(b1, q, n, ref sum);
                        CalculateFunc(b1, q, n, ref b);
                        Console.WriteLine($"Сумма первых {n} членов прогресии равна: {sum}");
                        Console.WriteLine($"{n} член прогрессии равен: {b}");
                    }
                    else Console.WriteLine("Неверное значение первого члена прогрессии!");
                }
                else Console.WriteLine("Неверное значение знаменателя прогрессии!");

            }
            else Console.WriteLine("Неверное значение n!");
        }

        static void CalculateFunc(double b1, double q, int n, ref double b, int i = 1)
        {
            
            if (n > i)
            {
                b = b1 * q;
                i++;
                CalculateFunc(b, q, n, ref b, i);
            }
            
        }


        static void Sum(double b1, double q, int n, ref double sum, int i = 1)
        {

            if (n > i)
            {
                
                double b = b1 * q;
                sum += b;
                i++;
                Sum(b, q, n, ref sum, i);
            }

        }
    }
}
