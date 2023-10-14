using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Coniction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4 ();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
