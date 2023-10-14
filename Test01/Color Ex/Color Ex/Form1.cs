using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void co()
        {
            int a = tba.Value;
            txta.Text = tba.Value.ToString();
            int r = tbr.Value;
            txtr.Text = tbr.Value.ToString();
            int g = tbg.Value;
            txtg.Text = tbg.Value.ToString();
            int b = tbb.Value;
            txtb.Text = tbb.Value.ToString();
            pictureBox1.BackColor = Color.FromArgb(a, r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tba_Scroll(object sender, EventArgs e)
        {
            co();
        }

        private void tbr_Scroll(object sender, EventArgs e)
        {
            co();
        }

        private void tbg_Scroll(object sender, EventArgs e)
        {
            co();
        }

        private void tbb_Scroll(object sender, EventArgs e)
        {
            co();
        }

        private void btnma_Click(object sender, EventArgs e)
        {
            if (tba.Value >= 5)
                tba.Value -= 5;
            co();
        }

        private void bynmr_Click(object sender, EventArgs e)
        {
            if (tbr.Value >= 5)
                tbr.Value -= 5;
            co();
        }

        private void btnmg_Click(object sender, EventArgs e)
        {
            if (tbg.Value >= 5)
                tbg.Value -= 5;
            co();
        }

        private void btnmb_Click(object sender, EventArgs e)
        {
            if (tbb.Value >= 5)
                tbb.Value -= 5;
            co();
        }
        private void btnpa_Click_1(object sender, EventArgs e)
        {

            if (tba.Value <= 250)
                tba.Value += 5;
            co();
        }

        private void btnpr_Click(object sender, EventArgs e)
        {
            if (tbr.Value <= 250)
                tbr.Value += 5;
            co();
        }

        private void btnpg_Click(object sender, EventArgs e)
        {
            if (tbg.Value <= 250)
                tbg.Value += 5;
            co();
        }

        private void btnpb_Click(object sender, EventArgs e)
        {
            if (tbb.Value <= 250)
                tbb.Value += 5;
            co();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {

            }
            else
            {
                int ta = int.Parse(txta.Text);
                if (ta > 0 && ta <= 255)
                {
                    tba.Value = int.Parse(txta.Text);
                    co();
                }
            }
        }
        private void txtr_TextChanged(object sender, EventArgs e)
        {
            if (txtr.Text == "")
            {

            }
            else
            {
                int tr = int.Parse(txtr.Text);
                if (tr > 0 && tr <= 255)
                {
                    tbr.Value = int.Parse(txtr.Text);
                    co();
                }
            }
        }

        private void txtg_TextChanged(object sender, EventArgs e)
        {
            if (txtg.Text == "")
            {

            }
            else {
                int tg = int.Parse(txtg.Text);
                if (tg > 0 && tg <= 255)
                {
                    tbg.Value = int.Parse(txtg.Text);
                    co();
                }
            }
        } 

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (txtb.Text == "")
            {

            }
            else
            {
                int tb = int.Parse(txtb.Text);
                if (tb > 0 && tb <= 255)
                {
                    tbb.Value = int.Parse(txtb.Text);
                    co();
                }
            }
        }
    }
}
