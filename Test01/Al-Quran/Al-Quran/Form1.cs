using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Quran
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"image\1.png");
            pictureBox1.Image = Image.FromFile(@"image\2.png");
        }
    }
}
