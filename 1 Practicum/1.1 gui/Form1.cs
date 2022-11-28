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
            double res = Math.Sqrt(Math.Pow((double)(TextBoxC.Value - TextBoxC.Value), 2) + Math.Pow((double)(TextBoxD.Value - TextBoxB.Value), 2));
            MessageBox.Show($"Искомым расстояние является число - {res}");
        }
    }
}
