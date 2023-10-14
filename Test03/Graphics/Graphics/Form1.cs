using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font f = new Font("Tahoma", 2, FontStyle.Bold);
            Pen pp = new Pen(Color.Red, 1);
            Pen p = new Pen(Color.Blue, 1);
            Pen ppp = new Pen(Color.Green, 1);
            /*
            this.CreateGraphics().DrawRectangle(pp, 20, 20, 200, 200);
            this.CreateGraphics().DrawRectangle(pp, 50, 50, 200, 200);
            this.CreateGraphics().DrawLine(pp, 20, 20, 50, 50);
            this.CreateGraphics().DrawLine(pp, 220, 20, 250, 50);
            this.CreateGraphics().DrawLine(pp, 20, 220, 50, 250);
            this.CreateGraphics().DrawLine(pp, 220, 220, 250, 250);
            */
            Point start = new Point(-40, 0);
            Point end = new Point(300, 0);
            for (int i = 0; i <= 150; i += 10)
            {
                this.CreateGraphics().DrawLine(pp, start, end);
                end.Y += 20;
            }
            for (int i = 150; i <= 3000; i += 30)
            {
                this.CreateGraphics().DrawLine(p, start, end);
                end.Y += 70;
            }
            Point start1 = new Point(340,0);
            Point end1 = new Point(0,0);
            for (int i = 0; i <= 30; i += 1)
            {
                this.CreateGraphics().DrawLine(ppp, start1, end1);
                end1.Y += 20;
            }

        }
    }
}
