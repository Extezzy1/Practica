using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                textBox2.Text = "";
                using (BinaryWriter writer = new BinaryWriter(File.Open("output.dat", FileMode.Create)))
                {
                    for (int i = 1; i <= n; i++)
                    {
                        double res = 1 / (double)i;
                        writer.Write(res);
                    }
                }
                FileStream f = new FileStream("output.dat", FileMode.Open);
                using (BinaryReader reader = new BinaryReader(f))
                {
                    int counter = 1;
                    while (reader.PeekChar() > -1)
                    {
                        double number = reader.ReadDouble();
                        if (counter % 3 == 0) textBox2.Text += number + Environment.NewLine;
                        counter++;
                    }
                }
            }
            else textBox2.Text = "n должно являться числом большим нуля!";
        }
    }
}
