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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Edit Button 
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.worktb.Rows[Form1.i]["Plate_Name"] = textBox1.Text;
                Form1.worktb.Rows[Form1.i]["Clinte_Name"] = textBox2.Text;
                Form1.worktb.Rows[Form1.i]["Last_Use"] = textBox3.Text;
                Form1.worktb.Rows[Form1.i]["Pallet_Num"] = textBox4.Text;
                Form1.worktb.Rows[Form1.i]["Box_Num"] = textBox5.Text;
                Form1.workDa.Update(Form1.worktb);
                MessageBox.Show("The Recorde Has Been Updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms[0].Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        //Cansle Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Form1.s1.ToString();
                textBox2.Text = Form1.s2.ToString();
                textBox3.Text = Form1.s3.ToString();
                textBox4.Text = Form1.s4.ToString();
                textBox5.Text = Form1.s5.ToString();
                button6.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.Select();
                textBox1.Text = Form1.s1.ToString();
                textBox2.Text = Form1.s2.ToString();
                textBox3.Text = Form1.s3.ToString();
                textBox4.Text = Form1.s4.ToString();
                textBox5.Text = Form1.s5.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Application.OpenForms[0].Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.s1)
            { }
            else { button6.Enabled = true; }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == Form1.s2)
            { }
            else { button6.Enabled = true; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == Form1.s3)
            { }
            else { button6.Enabled = true; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == Form1.s4)
            { }
            else { button6.Enabled = true; }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == Form1.s5)
            { }
            else { button6.Enabled = true; }
        }
    }
}
