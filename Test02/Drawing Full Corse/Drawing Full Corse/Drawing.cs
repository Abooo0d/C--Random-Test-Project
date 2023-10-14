using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Full_Corse
{
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            Point p1 = new Point(20, 20);
            Point p2 = new Point(200, 20);
            this.CreateGraphics().DrawLine(Pens.Black, p1, p2);
        }

        private void btnlines_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            Point p1 = new Point(20, 20);
            Point p2 = new Point(200, 20);
            Point p3 = new Point(200, 200);
            Point p4 = new Point(250, 200);
            Point[] Allp = { p1, p2, p3, p4 };
            this.CreateGraphics().DrawLines(Pens.Black,Allp);
        }

        private void btnrec_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            this.CreateGraphics().DrawRectangle(Pens.Red, 20, 20, 300, 100);
            this.CreateGraphics().DrawRectangle(Pens.Brown, 340, 20, 300, 220);
            this.CreateGraphics().FillRectangle(Brushes.DarkGray, 20, 140, 300, 100);
        }

        private void btnellips_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            this.CreateGraphics().DrawEllipse(Pens.DarkBlue,20,20,200,250);
            this.CreateGraphics().FillEllipse(Brushes.DarkBlue, 270, 20, 200, 250);
        }

        private void btnpie_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            this.CreateGraphics().DrawPie(Pens.Black, 20, 20, 200, 200, 0, 360);
            this.CreateGraphics().FillPie(Brushes.Black, 240, 20, 200, 200, 90, 180);
        }

        private void btnpoligon_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            Point p1 = new Point(20,100);
            Point p2 = new Point(70,20);
            Point p3 = new Point(70,60);
            Point p4 = new Point(170,60);
            Point p5 = new Point(170,140);
            Point p6 = new Point(70,140);
            Point p7 = new Point(70,180);
            Point[] Allp = { p1, p2, p3, p4, p5, p6, p7 };
            this.CreateGraphics().DrawPolygon(Pens.Black,Allp);
            Point p8 = new Point(120, 200);
            Point p9 = new Point(170, 120);
            Point p10 = new Point(170, 160);
            Point p11 = new Point(270, 160);
            Point p12 = new Point(270, 240);
            Point p13 = new Point(170, 240);
            Point p14 = new Point(170, 280);
            Point[] Allp2 = {p8,p9,p10,p11,p12,p13,p14 };
            this.CreateGraphics().FillPolygon(Brushes.Black, Allp2);
        }

        private void btnstr_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            Font f = new Font("Arial",100,FontStyle.Bold);
            this.CreateGraphics().DrawString("Welcome",f,Brushes.Black,20,20);
        }

        private void btncurve_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            Point p1 = new Point(20, 100);
            Point p2 = new Point(70, 20);
            Point p3 = new Point(70, 60);
            Point p4 = new Point(170, 60);
            Point p5 = new Point(170, 140);
            Point p6 = new Point(70, 140);
            Point p7 = new Point(70, 180);
            Point[] Allp = { p1, p2, p3, p4, p5, p6, p7 };
            this.CreateGraphics().DrawClosedCurve(Pens.Black,Allp);

            Point p100 = new Point(220, 100);
            Point p200 = new Point(270, 20);
            Point p300 = new Point(270, 60);
            Point p400 = new Point(370, 60);
            Point p500 = new Point(370, 140);
            Point p600 = new Point(270, 140);
            Point p700 = new Point(270, 180);
            Point[] Allp1 = { p100, p200, p300, p400, p500, p600, p700 };
            this.CreateGraphics().DrawCurve(Pens.Black, Allp1);

            Point p8 = new Point(120, 200);
            Point p9 = new Point(170, 120);
            Point p10 = new Point(170, 160);
            Point p11 = new Point(270, 160);
            Point p12 = new Point(270, 240);
            Point p13 = new Point(170, 240);
            Point p14 = new Point(170, 280);
            Point[] Allp2 = { p8, p9, p10, p11, p12, p13, p14 };
            this.CreateGraphics().FillClosedCurve(Brushes.Black, Allp2);

        }

        private void btnarc_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.Aqua);
            this.CreateGraphics().DrawArc(Pens.Black,20,20,250,250,0,270);
        }
    }
}
