using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введи a >> ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи a >> ");
            }

            Console.Write("Введи b >> ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи b >> ");
            }

            Console.Write("Введи c >> ");
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи c >> ");
            }

            Triangle tr1 = new Triangle(a, b, c);
            tr1.ShowSides();
            tr1.GetPerimetr();
            tr1.GetSquare();
            if (tr1.is_exist)
            {
                Console.WriteLine("Треугольник существует!");
            }
            else Console.WriteLine("Треугольник не существует");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Установим новые значения для сторон треугольника");
            Console.Write("Введи a >> ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи a >> ");
            }

            Console.Write("Введи b >> ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи b >> ");
            }

            Console.Write("Введи c >> ");
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Сторона треугольника должна быть числом большим нуля!");
                Console.Write("Введи c >> ");
            }
            tr1._a = a;
            tr1._b = b;
            tr1._c = c;
            Console.WriteLine($"Текущие стороны треугольника: {tr1._a}, {tr1._b}, {tr1._c}");
        }
    }

    public class Triangle
    {
        private int a, b, c;
        public int _a
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int _b
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int _c
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public bool is_exist
        {
            get
            {
                return this.a + this.b > this.c && this.a + this.c > this.b && this.b + this.c > this.a;
            }
        }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowSides()
        {
            Console.WriteLine($"Длины сторон треугольника: {this.a}, {this.b}, {this.c}");
        }

        public void GetPerimetr()
        {
            Console.WriteLine($"Периметр треугольника равен: {this.a + this.b + this.c}");
        }

        public void GetSquare() {
            if (this.is_exist)
            {
                double halfPerimetr = (this.a + this.b + this.c) / 2;
                double square = Math.Sqrt(halfPerimetr * (halfPerimetr - this.a) * (halfPerimetr - this.b) * (halfPerimetr - this.c));
                Console.WriteLine($"Площадь треугольника равна: {square}");
            }
            else Console.WriteLine("Невозможно вычислить площадь!");
        }

    }
}
