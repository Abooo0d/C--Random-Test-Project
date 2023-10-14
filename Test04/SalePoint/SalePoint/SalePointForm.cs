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
    public partial class SalePointForm : Form
    {
        public SalePointForm()
        {
            InitializeComponent();
        }
        public bool Dragging = false;
        public Point startpoint = new Point(0,0);
        public bool ismax = true;
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            
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
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

       

        private void custom_Button2_Click(object sender, EventArgs e)
        {

        }

        /*

         private void pnltopborder_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            startpoint = new Point(e.X, e.Y);
        }
        private void pnltopborder_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        private void pnltopborder_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
        */
    }
}
