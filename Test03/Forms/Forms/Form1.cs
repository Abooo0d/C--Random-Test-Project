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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public static string s;
        private void button1_Click(object sender, EventArgs e)
        {


            s= textBox1.Text;
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = s;
        }
    }
}
