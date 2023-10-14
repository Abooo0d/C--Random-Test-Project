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

namespace Test_Action_On_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = new DialogResult();
            string f1 = "", f2 = "";
            dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (File.Exists(of.FileName))
                {
                    f1 = of.FileName;
                }
            }
            else
            {
                MessageBox.Show("Plese Choose A File");
                return;
            }
            SaveFileDialog sf = new SaveFileDialog();
            string f = Path.GetFileName(f1);
            sf.FileName = f;
            dr = sf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                f2 = sf.FileName;
            }
            else
            {
                MessageBox.Show("Please Choose A Loxation To Copy Your File");
                return;
            }
            File.Copy(f1, f2);


        }
    }
}
