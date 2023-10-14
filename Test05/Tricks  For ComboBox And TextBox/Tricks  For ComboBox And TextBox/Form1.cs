using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tricks__For_ComboBox_And_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> a = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoCompleteSource = a.ToString(); 
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
