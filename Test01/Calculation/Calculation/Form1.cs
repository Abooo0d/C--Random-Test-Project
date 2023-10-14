using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float x, z;
        char c = ' ';

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {

            }
            else
            {
                x = float.Parse(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Select();
            if (c == ' ')
            {
                z = x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '+')
            {
                z = z + x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '-')
            {
                z = z - x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '*')
            { 
                z = z * x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            } else if (c == '/')
             {
                z = z / x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }

            }
        private void button4_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Select();
            textBox1.Clear();
            if (c == ' ')
            {
                z = x;
                c = '-';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '+')
            {
                z = z + x;
                c = '-';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '-')
            {
                z = z - x;
                c = '-';
                label1.Text = z.ToString();
            }
            else if (c == '*')
            {
                z = z * x;
                c = '-';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '/')
            {
                z = z / x;
                c = '-';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Select();
            if (c == ' ')
            {
                z = x;
                c = '/';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '+')
            {
                z = z + x;
                c = '+';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '-')
            {
                z = z - x;
                c = '/';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '*')
            {
                z = z * x;
                c = '/';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '/')
            {
                z = z / x;
                c = '/';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Select();
            if (c == ' ')
            {
                if (z == 0)
                {
                    z = 1;
                }
                z = x;
                c = '*';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '+')
            {
                z = z + x;
                c = '*';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '-')
            {
                z = z - x;
                c = '*';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '*')
            {
                z = z * x;
                c = '*';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
            else if (c == '/')
            {
                z = z / x;
                c = '*';
                label1.Text = z.ToString();
                label2.Text = c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Select();
            if (c == ' ')
            { 
                z = x;
                textBox1.Text = z.ToString();
                label1.Text = " ";
                label2.Text = " ";
            }
            else if (c == '+')
            {
                z = z + x;
                c = ' ';
                textBox1.Text = z.ToString();
                label1.Text = " ";
                label2.Text = " ";
            }
            else if (c == '-')
            {
                z = z - x;
                c = ' ';
                textBox1.Text = z.ToString();
                label1.Text = " ";
                label2.Text = " ";
            }
            else if (c == '*')
            {
                z = z * x;
                c = ' ';
                textBox1.Text = z.ToString();
                label1.Text = " ";
                label2.Text = " ";
            }
            else if (c == '/')
            {
                z = z / x;
                c = ' ';
                textBox1.Text = z.ToString();
                label1.Text = " ";
                label2.Text = " ";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox1.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            textBox1.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            textBox1.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            textBox1.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            textBox1.Focus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            textBox1.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            textBox1.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            textBox1.Focus();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            textBox1.Focus();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            z = 0;
            x = 0;
            c = ' ';
            textBox1.Text = " ";
            label1.Text = " ";
            label2.Text = " ";
        }

    }
}
