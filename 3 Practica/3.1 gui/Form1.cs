using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double x) && double.TryParse(textBox2.Text, out double y))
            {
                MessageBox.Show($"Значение Z = {max(x, 2 * y - x) + max(5 * x + 3 * y, y)}");
            }
            else MessageBox.Show("Введенные значения должны быть числами!");
        }

        static double max(double number1, double number2) => number1 > number2 ? number1 : number2;
    }
}
