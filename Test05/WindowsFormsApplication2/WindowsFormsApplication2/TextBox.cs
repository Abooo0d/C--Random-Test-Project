using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestToolsOnForms
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color focusColor = Color.HotPink;
        private System.Windows.Forms.TextBox textBox1;
        private bool isFocused = false;
        //Constructor
        public TextBox()
        {
            InitializeComponent();
        }
        //Events
        public event EventHandler _TextChanged;
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
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public bool MultiLine
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
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
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpDateControleHeight();
            }
        }
        [Category("Custom TextBox Properies")]
        public string _Text
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
               textBox1.Text = value;
            }
        }
        [Category("Custom TextBox Properies")]
        public Color FocusColor
        {
            get
            {
                return focusColor;
            }

            set
            {
                focusColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphic = e.Graphics;

            //Draw Border 
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underLinedStyle)//line Style
                        graphic.DrawLine(penBorder, 0, this.Height, this.Width, this.Height);
                    else //Normal Style
                        graphic.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = focusColor;
                    if (underLinedStyle)//line Style
                        graphic.DrawLine(penBorder, 0, this.Height, this.Width, this.Height);
                    else //Normal Style
                        graphic.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpDateControleHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpDateControleHeight();
        }
        private void UpDateControleHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height+1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 13);
            this.textBox1.TabIndex = 0;
            // 
            // TextBox
            // 
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}