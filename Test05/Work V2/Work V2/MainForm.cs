using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_V2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cercularbutton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cercularbutton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(-11, 27);
        }

        private void cercularbutton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(-11,147);
        }

        private void cercularbutton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(-10, 267);
        }
    }
}
