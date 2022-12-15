using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1_console
{
    class Program
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
            int index = 0;
            Console.Write("Введи индекс >> ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Введенный индекс должен быть целым числом!");
                Console.Write("Введи индекс >> ");
            }
            try
            {
                Console.WriteLine($"По индексу хранится значение - {tr1[index]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            tr1 = tr1++;
            Console.WriteLine("Значение длин сторон после инкремента: " + (string)tr1);
            tr1 = tr1--;
            Console.WriteLine("Значение длин сторон после декремента: " + (string)tr1);

            int number;
            Console.Write("Введи скаляр на который нужно умножить значен длин сторон треугольника >> ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Скаляр должен быть целым числом!");
                Console.Write("Введи c >> ");
            }
            tr1 = tr1 * number;

            string tr2 = (string)tr1;
            Console.WriteLine("Значения длин сторон после умножения на скаляр: " + tr2);
            tr1 = (Triangle)tr2;
            Console.WriteLine($"Значение переменных после преобразования из строки в Triangle: {tr1._a}, {tr1._b}, {tr1._c}");
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

        public void GetSquare()
        {
            if (this.is_exist)
            {
                double halfPerimetr = (this.a + this.b + this.c) / 2;
                double square = Math.Sqrt(halfPerimetr * (halfPerimetr - this.a) * (halfPerimetr - this.b) * (halfPerimetr - this.c));
                Console.WriteLine($"Площадь треугольника равна: {square}");
            }
            else Console.WriteLine("Невозможно вычислить площадь!");
        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return this.a;
                if (index == 1) return this.b;
                if (index == 2) return this.c;
                throw new Exception("Неверный индекс");
            }
        }

        public static Triangle operator++(Triangle tr1)
        {
            tr1.a++;
            tr1.b++;
            tr1.c++;
            return tr1;
        }

        public static Triangle operator --(Triangle tr1)
        {
            tr1.a--;
            tr1.b--;
            tr1.c--;
            return tr1;
        }
        public static bool operator true(Triangle tr1)
        {
            return tr1.is_exist;
        }
        public static bool operator false(Triangle tr1)
        {
            return tr1.is_exist;
        }

        public static Triangle operator *(Triangle tr1, int number)
        {
            tr1.a *= number;
            tr1.b *= number;
            tr1.c *= number;
            return tr1;
        }

        public static explicit operator string(Triangle tr1)
        {
            return $"a = {tr1.a}, b = {tr1.b}, c = {tr1.c}";
        }
        public static explicit operator Triangle(string str)
        {
            string[] str_split = str.Split(',');
            int a, b, c;
            a = int.Parse(str_split[0].Split('=')[1].Trim());
            b = int.Parse(str_split[1].Split('=')[1].Trim());
            c = int.Parse(str_split[2].Split('=')[1].Trim());
            Triangle tr1 = new Triangle(a, b, c);
            return tr1;
        }
    }
}
