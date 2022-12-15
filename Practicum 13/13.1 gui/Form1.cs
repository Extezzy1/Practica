using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._1_gui
{
    public partial class Form1 : Form
    {
        private List<Function> func = new List<Function>();
        private double x, a, b, c;

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out a) && double.TryParse(textBox4.Text, out b) && double.TryParse(textBox5.Text, out c))
            {
                func.Add(new Kub(a, b, c));
            }
            else MessageBox.Show("Неверные значения!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out a) && double.TryParse(textBox4.Text, out b))
            {
                func.Add(new Hyperbola(a, b));
            }
            else MessageBox.Show("Неверные значения!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out x))
            {
                foreach (Function item in func)
                {
                    textBox1.Text += $"Значение функции {item.GetName()} в точке {x} = {Math.Round(item.calculateFunc(x))}" + Environment.NewLine;
                }
            }
            else MessageBox.Show("Неверные значения!");
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out a) && double.TryParse(textBox4.Text, out b))
            {
                func.Add(new Line(a, b));
            }
            else MessageBox.Show("Неверные значения!");
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


