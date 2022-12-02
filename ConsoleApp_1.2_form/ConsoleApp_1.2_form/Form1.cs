using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_1._2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            if (a <= 0 || b <= 0 || c <= 0)
            {
                textBox4.Text += "Сторона не может иметь отрицательное значение";
                return;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                textBox4.Text += "Сторона не может иметь значение равное нулю";
                return;
            }
            if (a == b && b == c && a == c)
            {
                textBox4.Text += "Треугольник - равносторонний";
                return;
            }
            if (a == b || b == c || a == c)
            {
                textBox4.Text += "Треугольник - равнобедренный";
            }
            else
            {
                textBox4.Text += "Треугольник - НЕ равнобедренный";
            }
        }
    }
}
