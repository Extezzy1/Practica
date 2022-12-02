using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.Text.ToLower();

            if (int.TryParse(textBox1.Text, out int numberOfDay) && numberOfDay > 0 && numberOfDay < 32)
            {
                switch (month)
                {
                    case "январь":
                    case "март":
                    case "май":
                    case "июль":
                    case "август":
                    case "октябрь":
                    case "декабрь":
                        MessageBox.Show($"Количество дней до конца месяца - {31 - numberOfDay}");
                        break;
                    case "апрель":
                    case "июнь":
                    case "сентябрь":
                    case "ноябрь":
                        if (numberOfDay == 31) MessageBox.Show("В данном месяце только 30 дней!");
                        else MessageBox.Show($"Количество дней до конца месяца - {30 - numberOfDay}");
                        break;
                    case "февраль":
                     
                        string isLeapYear = comboBox2.Text.ToLower();
                        if (isLeapYear == "да")
                        {
                            if (numberOfDay > 29) MessageBox.Show("В данном месяце только 29 дней!");
                            else MessageBox.Show($"Количество дней до конца месяца - {29 - numberOfDay}");
                        }
                        else if (isLeapYear == "нет")
                        {
                            if (numberOfDay >= 29) MessageBox.Show("В данном месяце только 28 дней!");
                            else MessageBox.Show($"Количество дней до конца месяца - {28 - numberOfDay}");

                        }
                        else
                        {
                            MessageBox.Show("Выбери значение да/нет в выпадающем списке!");
                        }
                        break;
                }
            }
            else MessageBox.Show("Неверный номер дня");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
