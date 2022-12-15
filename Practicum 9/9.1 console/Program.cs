using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи n >> ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("output.dat", FileMode.Create)))
                {
                    for (int i = 1; i <= n; i++)
                    {
                        double res = 1 / (double)i;
                        writer.Write(res);
                    }
                }
                FileStream f = new FileStream("output.dat", FileMode.Open);
                using (BinaryReader reader = new BinaryReader(f))
                {
                    using (StreamWriter wr = new StreamWriter(File.Open("output.txt", FileMode.Create), Encoding.UTF8))
                    {
                        int counter = 1;
                        while (reader.PeekChar() > -1)
                        {
                            double number = reader.ReadDouble();
                            wr.WriteLine(number);
                            if (counter % 3 == 0) Console.Write(number + Environment.NewLine);
                            counter++;
                        }
                    }
                }
            }
            else Console.WriteLine("n должно являться числом большим нуля!");
        }
    }
}
