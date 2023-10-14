using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string s = textBox1.Text;
            Font f = new Font("Arial",16,FontStyle.Underline);
            e.Graphics.DrawString(s,f,Brushes.Black,20,20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
