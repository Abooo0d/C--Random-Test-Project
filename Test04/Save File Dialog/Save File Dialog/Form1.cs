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

namespace Save_File_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sfd.Title = "Choose A Location";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.FileName = txt1.Text + ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strpath = sfd.FileName;
                if (Path.GetExtension(sfd.FileName).ToLower() != ".txt")
                {
                    strpath += ".txt";
                }
                StreamWriter sw = new StreamWriter(strpath);
                sw.WriteLine(txt2.Text);
                sw.Close();
            }
            
        }
    }
}
