using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b) && int.TryParse(textBox3.Text, out c) &&
                a > 0 && b > 0 && c > 0)
            {
                textBox4.Text = "";
                Triangle tr1 = new Triangle(a, b, c);
                tr1.ShowSides(out int side1, out int side2, out int side3);
                textBox4.Text += $"Длины сторон треугольника равны: {side1}, {side2}, {side3}" + Environment.NewLine;
                textBox4.Text += $"Периметр треугольника равен: {tr1.GetPerimetr()}" + Environment.NewLine;
                double square = tr1.GetSquare();
                if (square > 0)
                {
                    textBox4.Text += $"Площадь треугольника равна: {square}" + Environment.NewLine;
                }
                else textBox4.Text += $"Невозможно вычислить площадь треугольника" + Environment.NewLine;
                if (tr1.is_exist)
                {
                    textBox4.Text += "Треугольник существует!" + Environment.NewLine;
                }
                else textBox4.Text += "Треугольник не существует" + Environment.NewLine;

            }
            else textBox4.Text = "Введены неверные данные!";
            
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

    }
}
