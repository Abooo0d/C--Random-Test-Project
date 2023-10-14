using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Provider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Not Allowed To Be Null");
            }
        }
    }
}
