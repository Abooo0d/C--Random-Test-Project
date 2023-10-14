using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePoint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public bool Dragging = false;
        public Point startpoint = new Point(0, 0);
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void custom_Button3_Click(object sender, EventArgs e)
        {
            SalePointForm salepoint = new SalePointForm();
            salepoint.Show();
            this.Hide();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseLeave(object sender, EventArgs e)
        {
            Dragging = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);

            }
        }

        private void custom_Button2_Click(object sender, EventArgs e)
        {
            StorageForm storage = new StorageForm();
            this.Hide();
            storage.Show();
        }
    }
}
