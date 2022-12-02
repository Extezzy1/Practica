using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи n >> ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > 16 || number < 1) Console.WriteLine("n принимает значения от 1 до 16!");
                else
                {
                    for (int i = 10; i < 10 + number; i++)
                    {
                        Console.WriteLine($"{i} {i}.4");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    int counter = 10;
                    while (counter < number + 10)
                    {
                        Console.WriteLine($"{counter} {counter}.4");
                        counter++;
                    }
                    counter = 10;
                    Console.WriteLine();
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine($"{counter} {counter}.4");
                        counter++;
                    }
                    while (counter < number + 10);
                }

            }
            else Console.WriteLine("Введено не целое число!");
        }
    }
}
