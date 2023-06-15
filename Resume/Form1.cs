using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

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
            string astr = textBox1.Text;
            string bstr = textBox2.Text;
            string cstr = textBox3.Text;

            Figure triangle = new Figure(astr, bstr, cstr);
            label2.Text = triangle.FigureSolver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure round = new Figure(textBox4.Text);
            label4.Text = round.FigureSolver();
        }

    }
}
