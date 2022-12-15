using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, index, number;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b) && int.TryParse(textBox3.Text, out c) && int.TryParse(textBox4.Text, out index)
                && int.TryParse(textBox5.Text, out number) && a > 0 && b > 0 && c > 0)
            {
                Triangle tr1 = new Triangle(a, b, c);
                tr1.ShowSides(out int a1, out int b1, out int c1);
                textBox6.Text = $"Длины сторон треугольника: {a1}, {b1}, {c1}" + Environment.NewLine;
                
                int perimetr = tr1.GetPerimetr();
                double square = tr1.GetSquare();
                textBox6.Text += $"Периметр треугольника: {perimetr}" + Environment.NewLine;
                textBox6.Text += $"Площадь треугольника: {square}" + Environment.NewLine;
                if (tr1.is_exist)
                {
                    textBox6.Text += "Треугольник существует!" + Environment.NewLine + Environment.NewLine;
                }
                else textBox6.Text += "Треугольник не существует" + Environment.NewLine + Environment.NewLine;

                try
                {
                    textBox6.Text += $"По индексу хранится значение - {tr1[index]}" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    textBox6.Text += ex.Message + Environment.NewLine;
                }

                tr1 = tr1++;
                textBox6.Text += "Значение длин сторон после инкремента: " + (string)tr1 + Environment.NewLine;
                tr1 = tr1--;
                textBox6.Text += "Значение длин сторон после декремента: " + (string)tr1 + Environment.NewLine;
                tr1 = tr1 * number;

                string tr2 = (string)tr1;
                textBox6.Text += "Значения длин сторон после умножения на скаляр: " + tr2 + Environment.NewLine;
                tr1 = (Triangle)tr2;
                textBox6.Text += $"Значение переменных после преобразования из строки в Triangle: {tr1._a}, {tr1._b}, {tr1._c}" + Environment.NewLine;
            }
            else textBox6.Text = "Неверные входные данные, все значения должны быть целыми числами!";
            
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

        public void ShowSides(out int a, out int b, out int c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }

        public int GetPerimetr()
        {
            return this.a + this.b + this.c;
        }

        public double GetSquare()
        {
            if (this.is_exist)
            {
                double halfPerimetr = (this.a + this.b + this.c) / 2;
                double square = Math.Sqrt(halfPerimetr * (halfPerimetr - this.a) * (halfPerimetr - this.b) * (halfPerimetr - this.c));
                return square;
            }
            else return 0.0;
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

        public static Triangle operator ++(Triangle tr1)
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
