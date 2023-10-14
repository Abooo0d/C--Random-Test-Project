using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.s = textBox1.Text;
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.s;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
