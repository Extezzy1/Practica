using System;

namespace _5._1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи a >> ");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Write("Введи b >> ");
                if (int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.Write("Введи h >> ");
                    if (int.TryParse(Console.ReadLine(), out int h))
                    {

                        if (a < b)
                        {
                            for (int i = a; i <= b; i += h)
                            {
                                try
                                {

                                    if (i == 0) throw new DivideByZeroException();
                                    
                                    Console.WriteLine($"f({i})={Math.Round(Math.Pow((i - 1), 2) / i, 5)}");
                                }
                                catch (DivideByZeroException ex)
                                {
                                    Console.WriteLine($"В точке {i} функция не существует!");
                                }

                            }
                        }
                        else if (a > b)
                        {
                            for (int i = b; i <= a; i += h)
                            {
                                try
                                {
                                    if (i == 0) throw new DivideByZeroException();

                                    Console.WriteLine($"f({i})={Math.Round(Math.Pow((i - 1), 2) / i, 5)}");
                                }
                                catch (DivideByZeroException ex)
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
    }
}
