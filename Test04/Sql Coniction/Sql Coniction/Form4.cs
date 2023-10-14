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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
