using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                textBox1.Select();
                Form1.workNr = Form1.worktb.NewRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.workNr["Id"] = Form1.worktb.Rows.Count + 1;
                Form1.workNr["Plate_Name"] = textBox1.Text;
                Form1.workNr["Clinte_Name"] = textBox2.Text;
                Form1.workNr["Last_Use"] = textBox3.Text; 
                Form1.workNr["Pallet_Num"] = textBox4.Text;
                Form1.workNr["Box_Num"] = textBox5.Text; 
                Form1.worktb.Rows.Add(Form1.workNr);
                Form1.workDa.Update(Form1.worktb);
                Form1.i = Form1.worktb.Rows.Count - 1;
                MessageBox.Show("The Record Has Been Added.", "Done ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms[0].Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
