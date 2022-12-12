using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи искомую строку >> ");
            string str = Console.ReadLine();
            int lenght = 0;
            Console.Write("Введи длину >> ");
            while (!int.TryParse(Console.ReadLine(), out lenght) || lenght <= 0)
            {
                Console.WriteLine("Длина должна быть больше нуля!");
                Console.Write("Введи длину >> ");
            }
            string[] str_split = str.Split(' ');
            int counter = 0;
            Regex regex = new Regex(@"\w");
            MatchCollection match;
            Console.WriteLine("Заданные слова: ");
            foreach (string item in str_split)
            {
                match = regex.Matches(item);
                if (match.Count == lenght)
                {
                    string res = "";
                    foreach (var x in match) res += x;
                    Console.WriteLine(res);
                    counter++;
                }
            }
            if (counter == 0) Console.WriteLine("В заданном тексте нет подходящих слов!");
        }
    }
}
