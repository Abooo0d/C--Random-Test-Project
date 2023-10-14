using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTools
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

        private void ruButton3_Click(object sender, EventArgs e)
        {
            custom_ProgressBar1.Value = 0;
            timer1.Start();
        }

        private void custom_ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (custom_ProgressBar1.Value < custom_ProgressBar1.Maximum)
                custom_ProgressBar1.Value++;
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
