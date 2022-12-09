using System;

namespace _7._1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            char s1, s2;
            String s;
            Console.Write("Введи первый символ >> ");
            while (!char.TryParse(Console.ReadLine(), out s1))
            {
                Console.WriteLine("Введенные данные должны являться символами!");
                Console.Write("Введи первый символ >> ");
            }

            Console.Write("Введи второй символ >> ");
            while (!char.TryParse(Console.ReadLine(), out s2))
            {
                Console.WriteLine("Введенные данные должны являться символами!");
                Console.Write("Введи второй символ >> ");
            }

            Console.Write("Введи строку символ >> ");
            s = Console.ReadLine();
            int counter1 = 0, counter2 = 0;
            foreach (char symbol in s)
            {
                if (symbol == s1) counter1++;
                if (symbol == s2) counter2++;
            }
            if (counter1 > counter2) Console.WriteLine($"Символ {s1} встречается чаще!");
            else if (counter1 < counter2) Console.WriteLine($"Символ {s2} встречается чаще!");
            else if (counter1 == 0 && counter2 == 0) Console.WriteLine("Заданные символы не встречаются в строке!");
            else Console.WriteLine("Заданные символы встречаются одинаковое количество раз!");
        }
    }
}
