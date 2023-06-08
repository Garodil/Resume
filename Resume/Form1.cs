using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox3.Text))
            {
                label2.Text = "Введите числа в поля";

            }
            else Check();

        }

        private void Check()
        {
            string astr = textBox1.Text;
            string bstr = textBox2.Text;
            string cstr = textBox3.Text;
            bool resulta = double.TryParse(astr, out double a);
            bool resultb = double.TryParse(bstr, out double b);
            bool resultc = double.TryParse(cstr, out double c);

            if (resulta && resultb && resultc)
            {
                Result(a, b, c);
            }
            else label2.Text = "Проверье числа в полях, возможно вы разделили десятичные знаки точкой, а не запятой, либо в ваши числа просочились буквы";
        }

        private void Result(double a, double b, double c)
        {

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            if (Double.IsNaN(S))
            {
                label2.Text = "Такого треугольника нет";
            }
            else label2.Text = S.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                label4.Text = "Введите число в поле";
            }
            else Check2();
        }

        private void Check2()
        {
            string rstr = textBox4.Text;
            bool resultr = double.TryParse(rstr, out double r);
            if (resultr)
            {
                Result2(r);
            }
            else label4.Text = "Проверье число в поле, возможно вы разделили десятичные знаки точкой, а не запятой, либо в ваше число просочились буквы";
        }

        private void Result2(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            if (Double.IsNaN(S))
            {
                label4.Text = "Такого окружности нет";
            }
            else label4.Text = S.ToString();
        }
    }
}
