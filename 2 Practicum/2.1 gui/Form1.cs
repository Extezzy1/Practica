using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxX.Text, out double x) && double.TryParse(textBoxY.Text, out double y))
            {
                double squareSum = x * x + y * y;
                double r1 = 25, r2 = 100;
                if (squareSum == r1 || squareSum == r2) MessageBox.Show("На границе");
                else if (squareSum > r1 && squareSum < r2) MessageBox.Show("Да");
                else MessageBox.Show("Нет");
            }
            else MessageBox.Show("Введены некоректные данные");
        }
    }
}
