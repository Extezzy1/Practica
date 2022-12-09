using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b) &&
                double.TryParse(textBox3.Text, out double h))
            {
                for (double i = a; i <= b; i += h)
                {
                    textBox4.Text +=($"f({Math.Round(i, 2)}) = {Math.Round(calculateFunc(i), 4)}") + Environment.NewLine;
                }
            }
            else MessageBox.Show("Введенные данные должны являться числами!");
        }

        static double calculateFunc(double x)
        {
            if (Math.Abs(x) < 3) return Math.Sin(x);
            if (Math.Abs(x) >= 9) return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            return Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5);
        }
    }
}
