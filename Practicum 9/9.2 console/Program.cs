using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biggest_lenght = 0;
            string biggest_line = "";
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > biggest_lenght)
                    {
                        biggest_lenght = line.Length;
                        biggest_line = line;
                    }
                    
                }
            }
            if (biggest_lenght == 0) Console.WriteLine("Файл пуст!");
            else
            {
                Console.WriteLine($"Длина самой длинной строки - {biggest_lenght}");
                Console.WriteLine($"Самая длинная строка - {biggest_line}");
            }
        }
    }
}
