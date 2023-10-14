namespace Drawing_Full_Corse
{
    partial class Drawing
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
            this.btnline = new System.Windows.Forms.Button();
            this.btnlines = new System.Windows.Forms.Button();
            this.btnrec = new System.Windows.Forms.Button();
            this.btnellips = new System.Windows.Forms.Button();
            this.btnpie = new System.Windows.Forms.Button();
            this.btnpoligon = new System.Windows.Forms.Button();
            this.btnstr = new System.Windows.Forms.Button();
            this.btncurve = new System.Windows.Forms.Button();
            this.btnarc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnline
            // 
            this.btnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnline.Location = new System.Drawing.Point(12, 310);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(105, 44);
            this.btnline.TabIndex = 0;
            this.btnline.Text = "Line";
            this.btnline.UseVisualStyleBackColor = false;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnlines
            // 
            this.btnlines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlines.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlines.Location = new System.Drawing.Point(12, 366);
            this.btnlines.Name = "btnlines";
            this.btnlines.Size = new System.Drawing.Size(105, 44);
            this.btnlines.TabIndex = 1;
            this.btnlines.Text = "Lines";
            this.btnlines.UseVisualStyleBackColor = false;
            this.btnlines.Click += new System.EventHandler(this.btnlines_Click);
            // 
            // btnrec
            // 
            this.btnrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrec.Location = new System.Drawing.Point(123, 310);
            this.btnrec.Name = "btnrec";
            this.btnrec.Size = new System.Drawing.Size(105, 44);
            this.btnrec.TabIndex = 2;
            this.btnrec.Text = "Rectangle";
            this.btnrec.UseVisualStyleBackColor = false;
            this.btnrec.Click += new System.EventHandler(this.btnrec_Click);
            // 
            // btnellips
            // 
            this.btnellips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnellips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnellips.Location = new System.Drawing.Point(123, 366);
            this.btnellips.Name = "btnellips";
            this.btnellips.Size = new System.Drawing.Size(105, 44);
            this.btnellips.TabIndex = 3;
            this.btnellips.Text = "Ellipse";
            this.btnellips.UseVisualStyleBackColor = false;
            this.btnellips.Click += new System.EventHandler(this.btnellips_Click);
            // 
            // btnpie
            // 
            this.btnpie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnpie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpie.Location = new System.Drawing.Point(234, 310);
            this.btnpie.Name = "btnpie";
            this.btnpie.Size = new System.Drawing.Size(105, 44);
            this.btnpie.TabIndex = 3;
            this.btnpie.Text = "Pie";
            this.btnpie.UseVisualStyleBackColor = false;
            this.btnpie.Click += new System.EventHandler(this.btnpie_Click);
            // 
            // btnpoligon
            // 
            this.btnpoligon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnpoligon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpoligon.Location = new System.Drawing.Point(234, 366);
            this.btnpoligon.Name = "btnpoligon";
            this.btnpoligon.Size = new System.Drawing.Size(105, 44);
            this.btnpoligon.TabIndex = 4;
            this.btnpoligon.Text = "Poligon";
            this.btnpoligon.UseVisualStyleBackColor = false;
            this.btnpoligon.Click += new System.EventHandler(this.btnpoligon_Click);
            // 
            // btnstr
            // 
            this.btnstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnstr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstr.Location = new System.Drawing.Point(345, 310);
            this.btnstr.Name = "btnstr";
            this.btnstr.Size = new System.Drawing.Size(105, 44);
            this.btnstr.TabIndex = 5;
            this.btnstr.Text = "String";
            this.btnstr.UseVisualStyleBackColor = false;
            this.btnstr.Click += new System.EventHandler(this.btnstr_Click);
            // 
            // btncurve
            // 
            this.btncurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncurve.Location = new System.Drawing.Point(345, 366);
            this.btncurve.Name = "btncurve";
            this.btncurve.Size = new System.Drawing.Size(105, 44);
            this.btncurve.TabIndex = 6;
            this.btncurve.Text = "Curves";
            this.btncurve.UseVisualStyleBackColor = false;
            this.btncurve.Click += new System.EventHandler(this.btncurve_Click);
            // 
            // btnarc
            // 
            this.btnarc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnarc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnarc.Location = new System.Drawing.Point(456, 310);
            this.btnarc.Name = "btnarc";
            this.btnarc.Size = new System.Drawing.Size(105, 44);
            this.btnarc.TabIndex = 7;
            this.btnarc.Text = "Arc";
            this.btnarc.UseVisualStyleBackColor = false;
            this.btnarc.Click += new System.EventHandler(this.btnarc_Click);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(787, 422);
            this.Controls.Add(this.btnarc);
            this.Controls.Add(this.btncurve);
            this.Controls.Add(this.btnstr);
            this.Controls.Add(this.btnpoligon);
            this.Controls.Add(this.btnpie);
            this.Controls.Add(this.btnellips);
            this.Controls.Add(this.btnrec);
            this.Controls.Add(this.btnlines);
            this.Controls.Add(this.btnline);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Drawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnlines;
        private System.Windows.Forms.Button btnrec;
        private System.Windows.Forms.Button btnellips;
        private System.Windows.Forms.Button btnpie;
        private System.Windows.Forms.Button btnpoligon;
        private System.Windows.Forms.Button btnstr;
        private System.Windows.Forms.Button btncurve;
        private System.Windows.Forms.Button btnarc;
    }
}

