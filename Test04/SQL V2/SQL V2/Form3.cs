using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_V2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_Final_ProjectDataSet.MatherBord' table. You can move, or remove it, as needed.
            this.matherBordTableAdapter.Fill(this.my_Final_ProjectDataSet.MatherBord);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.matherBordBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.matherBordBindingSource.Position++;
        }
    }
}
