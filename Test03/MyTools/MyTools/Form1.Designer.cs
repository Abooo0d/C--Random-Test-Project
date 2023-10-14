namespace MyTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customTextBox2 = new MyTools.Custom_TextBox();
            this.customTextBox1 = new MyTools.Custom_TextBox();
            this.custom_ProgressBar1 = new MyTools.Custom_ProgressBar();
            this.ruButton3 = new MyTools.Custom_Button();
            this.ruButton2 = new MyTools.Custom_Button();
            this.ruButton1 = new MyTools.Custom_Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(125, 159);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.MultiLine = true;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7);
           // this.customTextBox2.PasswordChar = true;
            this.customTextBox2.Size = new System.Drawing.Size(246, 48);
            this.customTextBox2.TabIndex = 6;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderLinedStyle = false;
           
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderSize = 6;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(202, 37);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.MultiLine = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(7);
           // this.customTextBox1.PasswordChar = false;
            this.customTextBox1.Size = new System.Drawing.Size(215, 31);
            this.customTextBox1.TabIndex = 5;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderLinedStyle = true;
            // 
            // custom_ProgressBar1
            // 
            this.custom_ProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.custom_ProgressBar1.ChannelHeight = 30;
            this.custom_ProgressBar1.ForeBackColor = System.Drawing.Color.Pink;
            this.custom_ProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.custom_ProgressBar1.Location = new System.Drawing.Point(46, 204);
            this.custom_ProgressBar1.Name = "custom_ProgressBar1";
            this.custom_ProgressBar1.ShowMaximum = true;
            this.custom_ProgressBar1.ShowValue = MyTools.TextPosition.Sliding;
            this.custom_ProgressBar1.Size = new System.Drawing.Size(278, 47);
            this.custom_ProgressBar1.SliderColor = System.Drawing.Color.Crimson;
            this.custom_ProgressBar1.Sliderheight = 20;
            this.custom_ProgressBar1.SymbolAfter = "";
            this.custom_ProgressBar1.SymbolBefor = "";
            this.custom_ProgressBar1.TabIndex = 4;
            this.custom_ProgressBar1.Click += new System.EventHandler(this.custom_ProgressBar1_Click);
            // 
            // ruButton3
            // 
            this.ruButton3.BackColor = System.Drawing.SystemColors.Control;
            this.ruButton3.BackGraundColor = System.Drawing.SystemColors.Control;
            this.ruButton3.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ruButton3.BorderRadius = 15;
            this.ruButton3.BorderSize = 2;
            this.ruButton3.FlatAppearance.BorderSize = 0;
            this.ruButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ruButton3.Location = new System.Drawing.Point(115, 297);
            this.ruButton3.Name = "ruButton3";
            this.ruButton3.Size = new System.Drawing.Size(150, 40);
            this.ruButton3.TabIndex = 2;
            this.ruButton3.Text = "ruButton3";
            this.ruButton3.TextColor = System.Drawing.Color.MidnightBlue;
            this.ruButton3.UseVisualStyleBackColor = false;
            this.ruButton3.Click += new System.EventHandler(this.ruButton3_Click);
            // 
            // ruButton2
            // 
            this.ruButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ruButton2.BackGraundColor = System.Drawing.Color.MediumSlateBlue;
            this.ruButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ruButton2.BorderRadius = 40;
            this.ruButton2.BorderSize = 0;
            this.ruButton2.FlatAppearance.BorderSize = 0;
            this.ruButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruButton2.ForeColor = System.Drawing.Color.White;
            this.ruButton2.Location = new System.Drawing.Point(244, 79);
            this.ruButton2.Name = "ruButton2";
            this.ruButton2.Size = new System.Drawing.Size(150, 40);
            this.ruButton2.TabIndex = 1;
            this.ruButton2.Text = "ruButton2";
            this.ruButton2.TextColor = System.Drawing.Color.White;
            this.ruButton2.UseVisualStyleBackColor = false;
            // 
            // ruButton1
            // 
            this.ruButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ruButton1.BackGraundColor = System.Drawing.Color.MediumSlateBlue;
            this.ruButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ruButton1.BorderRadius = 58;
            this.ruButton1.BorderSize = 0;
            this.ruButton1.FlatAppearance.BorderSize = 0;
            this.ruButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruButton1.ForeColor = System.Drawing.Color.White;
            this.ruButton1.Location = new System.Drawing.Point(98, 37);
            this.ruButton1.Name = "ruButton1";
            this.ruButton1.Size = new System.Drawing.Size(60, 58);
            this.ruButton1.TabIndex = 0;
            this.ruButton1.Text = "ruButton1";
            this.ruButton1.TextColor = System.Drawing.Color.White;
            this.ruButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 349);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.custom_ProgressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ruButton3);
            this.Controls.Add(this.ruButton2);
            this.Controls.Add(this.ruButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Button ruButton1;
        private Custom_Button ruButton2;
        private Custom_Button ruButton3;
        private System.Windows.Forms.Button button1;
        private Custom_ProgressBar custom_ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Custom_TextBox customTextBox1;
        private Custom_TextBox customTextBox2;
    }
}

