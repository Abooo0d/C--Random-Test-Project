using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradient_Brush_Fill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //First Way
            Point p1 = new Point(0,0);
            Point p2 = new Point(500,20);
            LinearGradientBrush gb = new LinearGradientBrush(p1,p2,Color.LightGray,Color.DimGray);
            this.CreateGraphics().FillPie(gb, 150, 150, 300, 300, 0, 360);
            //this.CreateGraphics().FillRectangle(gb, 0, 0, this.Width, this.Height); 

            //Secound Way
            Rectangle re = new Rectangle(20, 20, 200, 150);
            LinearGradientBrush gb2 = new LinearGradientBrush(re, Color.LightGray, Color.DimGray, LinearGradientMode.BackwardDiagonal);
            this.CreateGraphics().FillRectangle(gb2,20,20,200,150);
        }
    }
}