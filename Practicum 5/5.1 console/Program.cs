using System;

namespace _5._1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            Console.Write("Введи a >> ");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Write("Введи b >> ");
                if (int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.Write("Введи h >> ");
                    if (double.TryParse(Console.ReadLine(), out h))
                    {

                        if (h <= 0)
                        {
                            Console.WriteLine("h должно быть больше нуля!");
                            return;
                        }
                        if (a < b)
                        {
                            for (double i = a; i <= b; i += h)
                            {
                                try
                                {

                                    if (i == 0) throw new DivideByZeroException();
                                    
                                    Console.WriteLine($"f({i})={fx(i)}");
                                }
                                catch (DivideByZeroException ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }

                            }
                        }
                        else if (a > b)
                        {
                            for (double i = b; i <= a; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();

                                    Console.WriteLine($"f({i})={fx(i)}");
                                }
                                catch (DivideByZeroException ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }

                            }
                        }
                        else Console.WriteLine("Значения a и b должны быть разными!");
                    }
                    else Console.WriteLine("Неверное значение h!");
                }
                else Console.WriteLine("Неверное значение b!");
            }
            else Console.WriteLine("Неверное значение a!");
        }
        static double fx(double i)
        {
            return Math.Round(Math.Exp((Math.Pow((i - 1), 2) / i)), 5);
        }
    }
}
