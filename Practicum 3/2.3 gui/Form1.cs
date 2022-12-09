using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._3_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number > 16 || number < 0) MessageBox.Show("n принимает значения от 1 до 16!");
                else
                {
                    for (int i = 10; i < number + 10; i++)
                    {
                        textBox2.Text += $"{i} {i}.4" + Environment.NewLine;
                    }
                    textBox2.Text += Environment.NewLine;
                    textBox2.Text += Environment.NewLine;
                    int counter = 10;
                    while (counter < number + 10)
                    {
                        textBox2.Text += $"{counter} {counter}.4" + Environment.NewLine;
                        counter++;
                    }
                    counter = 10;
                    textBox2.Text += Environment.NewLine;
                    textBox2.Text += Environment.NewLine;
                    do
                    {
                        textBox2.Text += $"{counter} {counter}.4" + Environment.NewLine;
                        counter++;
                    }
                    while (counter < number + 10);
                }

            }
            else MessageBox.Show("Введено не целое число!");
        }
    }
}
