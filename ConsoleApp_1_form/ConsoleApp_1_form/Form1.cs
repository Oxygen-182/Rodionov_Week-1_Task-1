using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_1_form
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
            double a1 = double.Parse(textBox1.Text);
            double d = double.Parse(textBox2.Text);
            double n = double.Parse(textBox3.Text);

            if (n % 1 == 0) { }
            else
            {
                textBox4.Text += "Число членов арифметической прогрессии введено некорректно";
                return;
            }

            if (n < 0)
            {
                textBox4.Text += "Число членов арифметической прогрессии не может быть отрицательным";
                return;
            }

            double sum = (2 * a1 + d * (n - 1)) * n / 2;

            textBox4.Text += "Сумму членов арифметической прогрессии = " + sum.ToString();
        }
    }
}
