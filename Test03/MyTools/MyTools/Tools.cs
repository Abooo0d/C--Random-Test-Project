using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace MyTools
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
                return base.BackColor;
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
                if (this.DesignMode)
                    UpDateControleHeight();
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
        private void UpDateControleHeight()
        {
            if (this.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                this.Multiline = true;
                this.MinimumSize = new Size(0, txtHeight);
                this.Multiline = false;
                this.Height = this.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
    #endregion

    #region Button
    public class Custom_Button : Button
    {
        //Fildes
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("RuButton Options")]
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
        [Category("RuButton Options")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                if (borderRadius <= this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                Invalidate();
            }
        }
        [Category("RuButton Options")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        [Category("RuButton Options")]
        public Color BackGraundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("RuButton Options")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constractor
        public Custom_Button()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (borderRadius > 2)  //Rounded Button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button Surface
                    this.Region = new Region(pathSurface);
                    //Draw Surface Border For HD Result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button Border
                    if (borderSize >= 1)
                        //Draw Control Border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else    //Normal Button
            {
                //Button Surface
                this.Region = new Region(rectSurface);
                //Button Border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);

                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Containar_BackColorChanged);
        }

        private void Containar_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }
    }
    #endregion

    #region ProgressBar
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    class Custom_ProgressBar : ProgressBar
    {
        //Constractor
        public Custom_ProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }
        //feilds
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color forebackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefor = "";
        private string symbolAfter = "";
        private bool showMaximum = false;
        //Others
        private bool paintBack = false;
        private bool stopPainting = false;

        //Properties
        [Category("Custom_ProressBar Proberties")]
        public Color ChannelColor
        {
            get
            {
                return channelColor;
            }

            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public Color SliderColor
        {
            get
            {
                return sliderColor;
            }

            set
            {
                sliderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public Color ForeBackColor
        {
            get
            {
                return forebackColor;
            }

            set
            {
                forebackColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public int ChannelHeight
        {
            get
            {
                return channelHeight;
            }

            set
            {
                channelHeight = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public int Sliderheight
        {
            get
            {
                return sliderHeight;
            }

            set
            {
                sliderHeight = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public TextPosition ShowValue
        {
            get
            {
                return showValue;
            }

            set
            {
                showValue = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public string SymbolBefor
        {
            get
            {
                return symbolBefor;
            }

            set
            {
                symbolBefor = value;
                this.Invalidate();
            }
        }
        [Category("Custom_ProressBar Proberties")]
        public string SymbolAfter
        {
            get
            {
                return symbolAfter;
            }

            set
            {
                symbolAfter = value;
                this.Invalidate();
            }
        }

        [Category("Custom_ProressBar Proberties")]
        public bool ShowMaximum
        {
            get
            {
                return showMaximum;
            }

            set
            {
                showMaximum = value;
                this.Invalidate();
            }
        }

        //Paint the BackGroung &Channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintBack == false)
                {
                    //Feilds
                    Graphics graphic = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, channelHeight);
                    using (var brushChannel = new SolidBrush(ChannelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = this.Height - channelHeight;
                        else rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                        //Painting
                        graphic.Clear(this.Parent.BackColor);
                        graphic.FillRectangle(brushChannel, rectChannel);

                        //Stop Painting
                        if (this.DesignMode == false)
                            paintBack = false;
                    }
                }
                if (this.Value == this.Maximum || this.Value == this.Minimum)
                    paintBack = false;
            }
        }
        //PrintSlider
        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                //Fields
                Graphics graphic = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = this.Height - sliderHeight;
                    else rectSlider.Y = this.Height - ((sliderHeight + channelHeight) / 2);

                    //Painting
                    if (sliderWidth > 1)
                        graphic.FillRectangle(brushSlider, rectSlider);
                    if (showValue != TextPosition.None)
                        DrawValueText(graphic, sliderWidth, rectSlider);
                }
            }
            if (this.Value == this.Maximum) stopPainting = true;
            else stopPainting = false;
        }
        //Paint Value Text
        private void DrawValueText(Graphics graphic, int sliderWidth, Rectangle rectSlider)
        {
            string text = symbolBefor + this.Value.ToString() + symbolAfter;
            if (showMaximum) text = text + "/" + SymbolBefor + this.Maximum.ToString() + symbolAfter;
            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTextBack = new SolidBrush(forebackColor))
            using (var textFormat = new StringFormat())
            {
                switch (showValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Right:
                        rectText.X = this.Width - textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Center:
                        rectText.X = (this.Width - textSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        //Clean The Previous Text Surface
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graphic.FillRectangle(brushClear, rect);
                        }
                        break;
                }
                //Painting 
                graphic.FillRectangle(brushTextBack, rectText);
                graphic.DrawString(text, this.Font, brushText, rectText, textFormat);
            }
        }
    }
    #endregion

}
