using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи название месяца >> ");
            string month = Console.ReadLine().ToLower();
            Console.Write("Введи порядковый номер дня месяца >> ");
            if (int.TryParse(Console.ReadLine(), out int numberOfDay) && numberOfDay > 0 && numberOfDay < 32)
            {
                switch (month)
                {
                    case "январь":
                    case "март":
                    case "май":
                    case "июль":
                    case "август":
                    case "октябрь":
                    case "декабрь":
                        Console.WriteLine($"Количество дней до конца месяца - {31 - numberOfDay}");
                        break;
                    case "апрель":
                    case "июнь":
                    case "сентябрь":
                    case "ноябрь":
                        if (numberOfDay == 31) Console.WriteLine("В данном месяце только 30 дней!");
                        else Console.WriteLine($"Количество дней до конца месяца - {30 - numberOfDay}");
                        break;
                    case "февраль":
                        if (numberOfDay >= 29) Console.WriteLine("В данном месяце только 28 дней!");
                        else Console.WriteLine($"Количество дней до конца месяца - {28 - numberOfDay}");
                        break;
                }
            }
            else Console.WriteLine("Неверный номер дня");
        }
    }
}
