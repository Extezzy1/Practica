using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                if (result % 2 == 1) MessageBox.Show("Введенное число является нечетным");
                else MessageBox.Show("Введенное число не является нечетным");
            }
            else MessageBox.Show("Введенные данные должны являться числом");
        }
    }
}
