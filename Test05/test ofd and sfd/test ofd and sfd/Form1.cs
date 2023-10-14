using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_ofd_and_sfd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "TestFilter In SFD.";
            sf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //sf.Filter = "png Imges|*.png";
            //sf.Filter = "JPG Images|*.jpg";
            sf.Filter = "PNG &JPG Images|*.png;*.jpg|Text Files|*.txt|All Files|*.*";
            sf.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "testFilter in OFD";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //of.Filter = "png Imges|*.png";
            //of.Filter = "JPG Images|*.jpg";
            of.Filter = "PNG &JPG Images|*.png;*.jpg|Text Files|*.txt|All Files|*.*";
            of.ShowDialog();

        }
    }
}
