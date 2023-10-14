using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print__Invioce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(string thenumber)
        {
            txtqty.Text = txtqty.Text + thenumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtqty.Select();
           
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            numbers(((Button)sender).Text);
            txtqty.Select();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtqty.Text.Contains(".")) { }
            else if (txtqty.Text.Trim() == "")
            {
                txtqty.Text = "0.";
            }
            else { numbers(((Button)sender).Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtqty.Text.Length > 1)
            {
                string thevalue = txtqty.Text.Substring(0, txtqty.Text.Length - 1);
                txtqty.Text = thevalue;
            }
            else{txtqty.Text = "";}
            txtqty.Select();
        }
        float total = 0;
        private void btnc1_Click(object sender, EventArgs e)
        {
            float qty=0;
            string s = ((Button)sender).Tag.ToString();
            float t = float.Parse(s);
            string tqty = txtqty.Text.Trim();
            if (tqty == "")
            {
                qty = 1;
                string mat = ((Button)sender).Text;
                string qtys = qty.ToString();
                string sprise =s;
                string subprise = (t * qty) + "";
                object[] ro = { mat, qtys, sprise, subprise };
                dgv1.Rows.Add(ro);
                total =total+ float.Parse(subprise);
                lbltotal.Text = total.ToString();
                lblsubprise.Text = subprise;
                txtqty.Text = "";

               
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.Khaki;
                    }
                    else
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            else if (float.Parse(tqty) > 0)
            {
                qty = float.Parse(tqty);
                string mat = ((Button)sender).Text;
                string qtys = qty.ToString();
                string sprise = s;
                string subprise = (t * qty) + "";
                object[] ro = { mat, qtys, sprise, subprise };
                total = total + float.Parse(subprise);
                lbltotal.Text = total.ToString();
                txtqty.Text = "";
                dgv1.Rows.Add(ro);
                txtqty.Text = "";
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Select();
            if (e.KeyChar == (char)Keys.NumPad0)
            {
                btn0.PerformClick();
            }
                
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد إلغاء الطلب", "تأكيد",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2,MessageBoxOptions.RtlReading) == DialogResult.OK)
            {
                for (int i = dgv1.Rows.Count - 1; i >= 0; i--)
                {
                    dgv1.Rows.RemoveAt(i);
                    lbltotal.Text = "0";
                }
            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void editeprise_Click(object sender, EventArgs e)
        {
            int i = dgv1.Rows.Count - 1;
            dgv1.Rows[i].Cells[2].Value = txtqty.Text;
            lblsubprise.Text = txtqty.Text;
            txtqty.Text = "";
            string subp = dgv1.Rows[i].Cells[2].Value.ToString();
            string subqty = dgv1.Rows[i].Cells[1].Value.ToString();
            dgv1.Rows[i].Cells[3].Value = float.Parse(subp) * float.Parse(subqty);
            float w = 0;
            for (int y = 0; y < dgv1.Rows.Count; y++)
            {
                string r = dgv1.Rows[y].Cells[3].Value.ToString();
                w = w + float.Parse(r);
            }
            lbltotal.Text = w.ToString();
            
            
        }
        private void editeqty_Click(object sender, EventArgs e)
        {
            int i = dgv1.Rows.Count - 1;
            dgv1.Rows[i].Cells[1].Value = txtqty.Text;
            txtqty.Text = "";
            string subp = dgv1.Rows[i].Cells[2].Value.ToString();
            string subqty = dgv1.Rows[i].Cells[1].Value.ToString();
            dgv1.Rows[i].Cells[3].Value = float.Parse(subp) * float.Parse(subqty);
            float w = 0;
            for (int y = 0; y < dgv1.Rows.Count; y++)
            {
                string r = dgv1.Rows[y].Cells[3].Value.ToString();
                w = w + float.Parse(r);
            }
            lbltotal.Text = w.ToString();


        }
    }
}
