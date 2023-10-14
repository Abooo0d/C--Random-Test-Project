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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
                // TODO: This line of code loads data into the 'my_Final_ProjectDataSet.Ready_Setups' table. You can move, or remove it, as needed.
                this.ready_SetupsTableAdapter.Fill(this.my_Final_ProjectDataSet.Ready_Setups);
            
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.readySetupsBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.readySetupsBindingSource.Position++;
        }
    }
}
