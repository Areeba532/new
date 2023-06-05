using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double NUM1;
        Double NUM2;
        String result;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            display.Text += '1';
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            display.Text += '2';
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            display.Text += '3';
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            display.Text += '4';
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            display.Text += '5';
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            display.Text += '6';
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            display.Text += '7';
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            display.Text += '8';
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            display.Text += '9';
        }
        private void dot_Click(object sender, EventArgs e)
        {
            display.Text += '.';
        }
        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += '0';
        }


        private void display_TextChanged(object sender, EventArgs e)
        {

        }
        private void mul_Click(object sender, EventArgs e)
        {
            NUM1 = Convert.ToDouble(display.Text);
            op = 'x';
            display.Clear();
        }
        private void add_Click(object sender, EventArgs e)
        {
            NUM1 = Convert.ToDouble(display.Text);
            op = '+';
            display.Clear();
        }
        private void div_Click(object sender, EventArgs e)
        {
            NUM1 = Convert.ToDouble(display.Text);
            op = '/';
            display.Clear();
        }
        private void sub_Click(object sender, EventArgs e)
        {
            NUM1 = Convert.ToDouble(display.Text);
            op = '-';
            display.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NUM2 = Convert.ToDouble(display.Text);
            switch (op)
            {
                case '+':
                    result = Convert.ToString(NUM1+NUM2);
                    break;  
                case '-':
                    result = Convert.ToString(NUM1-NUM2);
                    break;
                case '*':
                    result = Convert.ToString(NUM1*NUM2);
                    break;
                case '/':
                    result = Convert.ToString(NUM1/NUM2);
                    break;
            }
            display.Text = result;  
        }
    }
}
