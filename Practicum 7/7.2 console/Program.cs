using System;

namespace _7._2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Console.Write("Введи строку >> ");
            String str = Console.ReadLine();
            string[] str_split = str.Split(' ');
            int counter = 0;
            Console.WriteLine();
            char[] UselessSymbols = { '!', '.', ',', '?', ':', ';', '@', '"' };
            Console.WriteLine("Искомые слова: ");
            foreach (string word in str_split)
            {
                foreach (char symbol in alphabet)
                {
                    if (symbol == word[0])
                    {
                        Console.WriteLine($"{word.Trim(UselessSymbols)}");
                        counter++;
                        break;
                    }
                }
            }
            if (counter == 0) Console.WriteLine("Заданная строка не содержит подходящих слов!");
        }
    }
}
