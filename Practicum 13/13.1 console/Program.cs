using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            int n;

            Console.Write("Введи n >> ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("n должен являться целым числом большим нуля!");
                Console.Write("Введи n >> ");
            }


            List<Function> func = new List<Function>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Выбери функцию:\n1 - Прямая\n2 - Куб\n3 - Гипербола >> ");
                if (int.TryParse(Console.ReadLine(), out int action) && action >= 1 && action <= 3)
                {
                    Console.Write("Введи a >> ");
                    while (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("a должен являться числом!");
                        Console.Write("Введи a >> ");
                    }

                    Console.Write("Введи b >> ");
                    while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("b должен являться числом!");
                        Console.Write("Введи b >> ");
                    }
                    switch (action)
                    {
                        case 1:
                            func.Add(new Line(a, b));
                            break;
                        case 2:
                            Console.Write("Введи c >> ");
                            while (!double.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine("c должен являться числом!");
                                Console.Write("Введи c >> ");
                            }
                            func.Add(new Kub(a, b, c));
                            break;
                        case 3:
                            func.Add(new Hyperbola(a, b));
                            break;
                    }
                }
                else Console.WriteLine("Неверное значение!");
            }
            Console.Write("Введи x >> ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("x должен являться числом!");
                Console.Write("Введи x >> ");
            }
            foreach (Function item in func)
            {
                Console.WriteLine($"Значение функции {item.GetName()} в точке {x} - {item.calculateFunc(x)}");
            }
        }
    }

    abstract class Function
    {
        public string name;
        public abstract double calculateFunc(double x);
        public abstract string GetName();
    }

    class Line : Function
    {
        public new string name = "Line";
        private double a, b;
        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double calculateFunc(double x)
        {
            return this.a * x + this.b;
        }

        public override string GetName()
        {
            return this.name;
        }
    }

    class Kub : Function
    {
        public new string name = "Kub";
        private double a, b, c;
        public Kub(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double calculateFunc(double x)
        {
            return this.a * x * x + this.b * x + this.c;
        }

        public override string GetName()
        {
            return this.name;
        }
    }

    class Hyperbola : Function
    {
        public new string name = "Hyperbola";
        private double a, b;
        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double calculateFunc(double x)
        {
            if (x == 0) throw new Exception("В точке {x} функция не существует!");
            return this.a / x + this.b;

        }

        public override string GetName()
        {
            return this.name;
        }
    }

}
