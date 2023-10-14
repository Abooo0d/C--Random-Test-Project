using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Dashboard
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        public static string name;
        private bool Dragging = false;
        private Point startpoint = new Point(0, 0);
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Data.txt");
            string line;
            bool finde = false;
            if (txtuser.Text.Trim() == "" || txtpassword.Text.Trim() == "")
            {
                lblerrorprovidor.Text = "please make sure to insert poth filde!!";
            }
            else
            {
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] person = line.Split(',');
                        if (person[0] == txtuser.Text && person[1] == txtpassword.Text)
                        {
                            finde = true;
                            break;
                        }
                    }
                } while (line != null);
                if (finde)
                {
                    name = txtuser.Text;
                    sr.Close();
                    Hide();
                    MainForm m = new MainForm();
                    m.Show();
                }
                else
                {
                    lblerrorprovidor.Text = "make sure th user name and the password are correct";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpassword.Clear();
            txtuser.Select();
            lblerrorprovidor.Text = "";
        }
    }
}
