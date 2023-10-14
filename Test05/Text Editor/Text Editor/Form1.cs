using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setfont()
        {
            string fontfamily = "Tahoma";
            if (cbxfonts.SelectedIndex > -1) fontfamily = cbxfonts.SelectedItem.ToString();

            FontStyle fontstyle = FontStyle.Regular;
            if (cbbold.Checked) fontstyle = fontstyle | FontStyle.Bold;
            if (cbitalic.Checked) fontstyle = fontstyle | FontStyle.Italic;
            if (cbunderline.Checked) fontstyle = fontstyle | FontStyle.Underline;

            int fontsize =(int)numfontsize.Value;

            Font f = new Font(fontfamily, fontsize, fontstyle);
            rtxt.SelectionFont = f;

        }
        private void setColor(Color color)
        {
            if (rbtext.Checked)
                rtxt.SelectionColor = color;
            else
                rtxt.SelectionBackColor = color;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily ff in FontFamily.Families)
            {
                cbxfonts.Items.Add(ff.Name);
            }
            cbxfonts.SelectedItem = "Tahoma";
        }

        private void rbbackground_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void cbxfonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void pred_Click(object sender, EventArgs e)
        {
            setColor(((Panel)sender).BackColor);
        }

        private void btncolordialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                setColor(cd.Color);
            }
        }
    }
}
