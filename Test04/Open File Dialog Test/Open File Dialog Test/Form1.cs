using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Open_File_Dialog_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            ofd.Title = "Choose File ";
            //ofd.InitialDirectory = "C:\\";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                txtFileName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                txtExtFile.Text = Path.GetExtension(ofd.FileName);
            }
            else { }

        }
    }
}
