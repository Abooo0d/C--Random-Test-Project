using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace TestToolsOnForms
{
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
