using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathTemp = "C:\\Temp";
            Directory.Delete(pathTemp, true);
            string K1 = pathTemp + "\\K1";
            string K2 = pathTemp + "\\K2";
            string t1 = K1 + "\\t1.txt";
            string t2 = K1 + "\\t2.txt";
            string t3 = K2 + "\\t3.txt";
            string ALL = pathTemp + "\\ALL";
            System.IO.Directory.CreateDirectory(pathTemp);
            Console.WriteLine("Создана директория Temp");
            System.IO.Directory.CreateDirectory(K1);
            Console.WriteLine("Создана директория K1");
            System.IO.Directory.CreateDirectory(K2);
            Console.WriteLine("Создана директория K2");
            using (StreamWriter sw = new StreamWriter(t1, false))
            {
                Console.WriteLine("Создан файл t1.txt");
                sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            }
            using (StreamWriter sw = new StreamWriter(t2, false))
            {
                Console.WriteLine("Создан файл t2.txt");
                sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
            using (StreamWriter sw = new StreamWriter(t3, false))
            {
                Console.WriteLine("Создан файл t3.txt");
                using (StreamReader sr = new StreamReader(t1))
                {
                    string line1 = sr.ReadLine();
                    sw.WriteLine(line1);
                }
                using (StreamReader sr = new StreamReader(t2))
                {
                    string line2 = sr.ReadLine();
                    sw.WriteLine(line2);
                }
            }
            File.Move(t2, K2 + "\\t2.txt");
            File.Copy(t1, K2 + "\\t1.txt");
            Directory.Move(K2, ALL);
            Directory.Delete(K1, true);
            string[] allfiles = Directory.GetFiles(ALL);
            Console.WriteLine("Папка ALL содержит следующие файлы:");
            foreach (var item in allfiles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
