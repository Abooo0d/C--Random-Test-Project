namespace Text_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxfonts = new System.Windows.Forms.ComboBox();
            this.numfontsize = new System.Windows.Forms.NumericUpDown();
            this.cbbold = new System.Windows.Forms.CheckBox();
            this.cbitalic = new System.Windows.Forms.CheckBox();
            this.cbunderline = new System.Windows.Forms.CheckBox();
            this.pgreen = new System.Windows.Forms.Panel();
            this.pred = new System.Windows.Forms.Panel();
            this.pwhite = new System.Windows.Forms.Panel();
            this.pblue = new System.Windows.Forms.Panel();
            this.pgray = new System.Windows.Forms.Panel();
            this.pfuchsia = new System.Windows.Forms.Panel();
            this.pwellow = new System.Windows.Forms.Panel();
            this.pblack = new System.Windows.Forms.Panel();
            this.btncolordialog = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rbbackground = new System.Windows.Forms.RadioButton();
            this.rbtext = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numfontsize)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxfonts
            // 
            this.cbxfonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxfonts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxfonts.FormattingEnabled = true;
            this.cbxfonts.Location = new System.Drawing.Point(6, 50);
            this.cbxfonts.Margin = new System.Windows.Forms.Padding(2);
            this.cbxfonts.Name = "cbxfonts";
            this.cbxfonts.Size = new System.Drawing.Size(276, 27);
            this.cbxfonts.TabIndex = 0;
            this.cbxfonts.SelectedIndexChanged += new System.EventHandler(this.cbxfonts_SelectedIndexChanged);
            // 
            // numfontsize
            // 
            this.numfontsize.Location = new System.Drawing.Point(303, 51);
            this.numfontsize.Margin = new System.Windows.Forms.Padding(2);
            this.numfontsize.Name = "numfontsize";
            this.numfontsize.Size = new System.Drawing.Size(39, 27);
            this.numfontsize.TabIndex = 1;
            this.numfontsize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numfontsize.ValueChanged += new System.EventHandler(this.cbxfonts_SelectedIndexChanged);
            // 
            // cbbold
            // 
            this.cbbold.AutoSize = true;
            this.cbbold.Checked = true;
            this.cbbold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbbold.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbold.Location = new System.Drawing.Point(367, 11);
            this.cbbold.Margin = new System.Windows.Forms.Padding(2);
            this.cbbold.Name = "cbbold";
            this.cbbold.Size = new System.Drawing.Size(64, 23);
            this.cbbold.TabIndex = 2;
            this.cbbold.Text = "Bold";
            this.cbbold.UseVisualStyleBackColor = true;
            this.cbbold.CheckedChanged += new System.EventHandler(this.cbxfonts_SelectedIndexChanged);
            // 
            // cbitalic
            // 
            this.cbitalic.AutoSize = true;
            this.cbitalic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitalic.Location = new System.Drawing.Point(435, 13);
            this.cbitalic.Margin = new System.Windows.Forms.Padding(2);
            this.cbitalic.Name = "cbitalic";
            this.cbitalic.Size = new System.Drawing.Size(62, 23);
            this.cbitalic.TabIndex = 3;
            this.cbitalic.Text = "Italic";
            this.cbitalic.UseVisualStyleBackColor = true;
            this.cbitalic.CheckedChanged += new System.EventHandler(this.cbxfonts_SelectedIndexChanged);
            // 
            // cbunderline
            // 
            this.cbunderline.AutoSize = true;
            this.cbunderline.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunderline.Location = new System.Drawing.Point(518, 13);
            this.cbunderline.Margin = new System.Windows.Forms.Padding(2);
            this.cbunderline.Name = "cbunderline";
            this.cbunderline.Size = new System.Drawing.Size(105, 23);
            this.cbunderline.TabIndex = 4;
            this.cbunderline.Text = "Under Line";
            this.cbunderline.UseVisualStyleBackColor = true;
            this.cbunderline.CheckedChanged += new System.EventHandler(this.cbxfonts_SelectedIndexChanged);
            // 
            // pgreen
            // 
            this.pgreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgreen.BackColor = System.Drawing.Color.Green;
            this.pgreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgreen.Location = new System.Drawing.Point(808, 4);
            this.pgreen.Margin = new System.Windows.Forms.Padding(2);
            this.pgreen.Name = "pgreen";
            this.pgreen.Size = new System.Drawing.Size(35, 33);
            this.pgreen.TabIndex = 5;
            this.pgreen.Click += new System.EventHandler(this.pred_Click);
            // 
            // pred
            // 
            this.pred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pred.BackColor = System.Drawing.Color.Red;
            this.pred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pred.Location = new System.Drawing.Point(769, 4);
            this.pred.Margin = new System.Windows.Forms.Padding(2);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(35, 33);
            this.pred.TabIndex = 6;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // pwhite
            // 
            this.pwhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwhite.BackColor = System.Drawing.Color.White;
            this.pwhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwhite.Location = new System.Drawing.Point(808, 43);
            this.pwhite.Margin = new System.Windows.Forms.Padding(2);
            this.pwhite.Name = "pwhite";
            this.pwhite.Size = new System.Drawing.Size(35, 33);
            this.pwhite.TabIndex = 8;
            this.pwhite.Click += new System.EventHandler(this.pred_Click);
            // 
            // pblue
            // 
            this.pblue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pblue.BackColor = System.Drawing.Color.Blue;
            this.pblue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblue.Location = new System.Drawing.Point(769, 43);
            this.pblue.Margin = new System.Windows.Forms.Padding(2);
            this.pblue.Name = "pblue";
            this.pblue.Size = new System.Drawing.Size(35, 33);
            this.pblue.TabIndex = 7;
            this.pblue.Click += new System.EventHandler(this.pred_Click);
            // 
            // pgray
            // 
            this.pgray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgray.BackColor = System.Drawing.Color.Gray;
            this.pgray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgray.Location = new System.Drawing.Point(886, 43);
            this.pgray.Margin = new System.Windows.Forms.Padding(2);
            this.pgray.Name = "pgray";
            this.pgray.Size = new System.Drawing.Size(35, 33);
            this.pgray.TabIndex = 12;
            this.pgray.Click += new System.EventHandler(this.pred_Click);
            // 
            // pfuchsia
            // 
            this.pfuchsia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pfuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.pfuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfuchsia.Location = new System.Drawing.Point(886, 4);
            this.pfuchsia.Margin = new System.Windows.Forms.Padding(2);
            this.pfuchsia.Name = "pfuchsia";
            this.pfuchsia.Size = new System.Drawing.Size(35, 33);
            this.pfuchsia.TabIndex = 11;
            this.pfuchsia.Click += new System.EventHandler(this.pred_Click);
            // 
            // pwellow
            // 
            this.pwellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwellow.BackColor = System.Drawing.Color.Yellow;
            this.pwellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwellow.Location = new System.Drawing.Point(847, 43);
            this.pwellow.Margin = new System.Windows.Forms.Padding(2);
            this.pwellow.Name = "pwellow";
            this.pwellow.Size = new System.Drawing.Size(35, 33);
            this.pwellow.TabIndex = 10;
            this.pwellow.Click += new System.EventHandler(this.pred_Click);
            // 
            // pblack
            // 
            this.pblack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pblack.BackColor = System.Drawing.Color.Black;
            this.pblack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblack.Location = new System.Drawing.Point(847, 4);
            this.pblack.Margin = new System.Windows.Forms.Padding(2);
            this.pblack.Name = "pblack";
            this.pblack.Size = new System.Drawing.Size(35, 33);
            this.pblack.TabIndex = 9;
            this.pblack.Click += new System.EventHandler(this.pred_Click);
            // 
            // btncolordialog
            // 
            this.btncolordialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncolordialog.BackColor = System.Drawing.Color.Aqua;
            this.btncolordialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncolordialog.Location = new System.Drawing.Point(924, 3);
            this.btncolordialog.Margin = new System.Windows.Forms.Padding(2);
            this.btncolordialog.Name = "btncolordialog";
            this.btncolordialog.Size = new System.Drawing.Size(75, 73);
            this.btncolordialog.TabIndex = 13;
            this.btncolordialog.Text = "Colors";
            this.btncolordialog.UseVisualStyleBackColor = false;
            this.btncolordialog.Click += new System.EventHandler(this.btncolordialog_Click);
            // 
            // rtxt
            // 
            this.rtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt.Location = new System.Drawing.Point(0, 0);
            this.rtxt.Margin = new System.Windows.Forms.Padding(2);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(1001, 431);
            this.rtxt.TabIndex = 14;
            this.rtxt.Text = resources.GetString("rtxt.Text");
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.rtxt);
            this.panel9.Location = new System.Drawing.Point(0, 80);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1003, 433);
            this.panel9.TabIndex = 15;
            // 
            // rbbackground
            // 
            this.rbbackground.AutoSize = true;
            this.rbbackground.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbackground.Location = new System.Drawing.Point(640, 11);
            this.rbbackground.Margin = new System.Windows.Forms.Padding(2);
            this.rbbackground.Name = "rbbackground";
            this.rbbackground.Size = new System.Drawing.Size(125, 23);
            this.rbbackground.TabIndex = 16;
            this.rbbackground.Text = "BackGround";
            this.rbbackground.UseVisualStyleBackColor = true;
            this.rbbackground.CheckedChanged += new System.EventHandler(this.rbbackground_CheckedChanged);
            // 
            // rbtext
            // 
            this.rbtext.AutoSize = true;
            this.rbtext.Checked = true;
            this.rbtext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtext.Location = new System.Drawing.Point(640, 45);
            this.rbtext.Margin = new System.Windows.Forms.Padding(2);
            this.rbtext.Name = "rbtext";
            this.rbtext.Size = new System.Drawing.Size(65, 23);
            this.rbtext.TabIndex = 17;
            this.rbtext.TabStop = true;
            this.rbtext.Text = "Text";
            this.rbtext.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Font Family";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1003, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtext);
            this.Controls.Add(this.rbbackground);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btncolordialog);
            this.Controls.Add(this.pgray);
            this.Controls.Add(this.pfuchsia);
            this.Controls.Add(this.pwellow);
            this.Controls.Add(this.pblack);
            this.Controls.Add(this.pwhite);
            this.Controls.Add(this.pblue);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.pgreen);
            this.Controls.Add(this.cbunderline);
            this.Controls.Add(this.cbitalic);
            this.Controls.Add(this.cbbold);
            this.Controls.Add(this.numfontsize);
            this.Controls.Add(this.cbxfonts);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numfontsize)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxfonts;
        private System.Windows.Forms.NumericUpDown numfontsize;
        private System.Windows.Forms.CheckBox cbbold;
        private System.Windows.Forms.CheckBox cbitalic;
        private System.Windows.Forms.CheckBox cbunderline;
        private System.Windows.Forms.Panel pgreen;
        private System.Windows.Forms.Panel pred;
        private System.Windows.Forms.Panel pwhite;
        private System.Windows.Forms.Panel pblue;
        private System.Windows.Forms.Panel pgray;
        private System.Windows.Forms.Panel pfuchsia;
        private System.Windows.Forms.Panel pwellow;
        private System.Windows.Forms.Panel pblack;
        private System.Windows.Forms.Button btncolordialog;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton rbbackground;
        private System.Windows.Forms.RadioButton rbtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

