using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b) &&
                double.TryParse(textBox3.Text, out double c) && double.TryParse(textBox4.Text, out double d))
            {
                double res = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));
                MessageBox.Show($"Искомым расстояние является число - {res}");
            }
            else MessageBox.Show("Введенные данные должны быть числами!");
        }
    }
}
