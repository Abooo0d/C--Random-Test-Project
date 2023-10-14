using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trick_For_TextBox_And_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> a = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            a.Add("aaaa");
            a.Add("bbbb");
            a.Add("cccc");
            a.Add("dddd");
            a.Add("eeee");
            a.Add("ffff");
            textBox1.Tag = a;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //comboBox1.DataSource = new BindingSource(a,null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
