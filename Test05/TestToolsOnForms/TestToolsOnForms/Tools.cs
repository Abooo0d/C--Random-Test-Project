using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

/*
namespace TestToolsOnForms
{
    
    #region TextBox
    [DefaultEvent("_TextChanged")]
    public partial class Custom_TextBox : TextBox
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocus = false;

        //Constructor
        public Custom_TextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.White;
            this.Size = new Size(150, 30);
            this.ForeColor = Color.DimGray;
        }

        //properties
        [Category("Custom TextBox Properies")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom TextBox Properies")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("Custom TextBox Properies")]
        public bool UnderLinedStyle
        {
            get
            {
                return underLinedStyle;
            }

            set
            {
                underLinedStyle = value;
                Invalidate();
            }
        }
        [Category("Custom TextBox Properies")]
        public bool PassWordChar
        {
            get { return UseSystemPasswordChar; }
            set { UseSystemPasswordChar = value; }
        }

        [Category("Custom TextBox Properies")]
        public bool MultiLine
        {
            get { return Multiline; }
            set { Multiline = value; }
        }
        [Category("Custom TextBox Properies")]
        public override Color BackColor
        {
            get
            {
                return BackColor;
            }

            set
            {
                BackColor = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public override Color ForeColor
        {
            get
            {
                return ForeColor;
            }

            set
            {
                ForeColor = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public override Font Font
        {
            get
            {
                return Font;
            }
            set
            {
                Font = value;
                // if (this.DesignMode)
                //    UpDateControleHeight();
            }
        }
        [Category("Custom TextBox Properies")]
        public string Texts
        {
            get { return Text; }
            set { Text = value; }
        }

        [Category("Custom TextBox Properies")]
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }

            set
            {
                borderFocusColor = value;
            }
        }


        //Overridding Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphic = e.Graphics;

            //Draw Border 
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                if (!isFocus)
                {
                    if (underLinedStyle)//line Style
                        graphic.DrawLine(penBorder, 0, this.Height, this.Width, this.Height);
                    else //Normal Style
                        graphic.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underLinedStyle)//line Style
                        graphic.DrawLine(penBorder, 0, this.Height, this.Width, this.Height);
                    else //Normal Style
                        graphic.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

    }
    #endregion
}
*/