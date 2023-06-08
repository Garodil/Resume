using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibrary2.Library;

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
            else
            {
                string astr = textBox1.Text;
                string bstr = textBox2.Text;
                string cstr = textBox3.Text;
                label2.Text = TriangleSolver(astr, bstr, cstr);
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                label4.Text = "Введите число в поле";
            }
            else
            {
                label4.Text = RoundSolver(textBox4.Text);
            }
        }

    }
}
