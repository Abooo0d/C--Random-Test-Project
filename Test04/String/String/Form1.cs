using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            //To Get The Text Length
            textBox2.Text = textBox1.Text.Length.ToString();
            //To Get The Text Lines Counte
            textBox2.Text = textBox1.Lines.Count().ToString();
            //To Cut Apart From String
            textBox2.Text = textBox1.Text.Substring(0, 50);
            //to Replase An Char To A Nother Char 
            textBox2.Text = textBox1.Text.Replace('@','A');
        }
    }
}
