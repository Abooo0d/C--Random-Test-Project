namespace My_Programe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnphoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 35);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "Insert An ID Here");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(442, 35);
            this.textBox2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox2, "Insert A Name Here");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Addreas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(442, 35);
            this.textBox3.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox3, "Insert An Addreas Here");
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Location = new System.Drawing.Point(8, 209);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(135, 52);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnadd, "Click Here To Add A New Pirsone ");
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfind.Location = new System.Drawing.Point(149, 209);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(135, 52);
            this.btnfind.TabIndex = 7;
            this.btnfind.Text = "Find";
            this.toolTip1.SetToolTip(this.btnfind, "Insert An ID And Click Here To Find The Pirsone ");
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshow.Location = new System.Drawing.Point(290, 267);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(135, 52);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "ShowAll";
            this.toolTip1.SetToolTip(this.btnshow, "Click Here Show Up All Data");
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Location = new System.Drawing.Point(431, 265);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(135, 54);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnexit, "Click Here To Exit ");
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pirsone Data";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfirst.Location = new System.Drawing.Point(290, 209);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(135, 52);
            this.btnfirst.TabIndex = 11;
            this.btnfirst.Text = "First One";
            this.toolTip1.SetToolTip(this.btnfirst, "Click Here To Show First Person  ");
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnback.Enabled = false;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(149, 267);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(135, 52);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.toolTip1.SetToolTip(this.btnback, "Click Here To Show Last One ");
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnext.Enabled = false;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Location = new System.Drawing.Point(8, 267);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(135, 52);
            this.btnnext.TabIndex = 13;
            this.btnnext.Text = "Next";
            this.toolTip1.SetToolTip(this.btnnext, "Click Here To Show Next one ");
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlast.Location = new System.Drawing.Point(431, 209);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(135, 52);
            this.btnlast.TabIndex = 14;
            this.btnlast.Text = "Last One ";
            this.toolTip1.SetToolTip(this.btnlast, "Click Here To Show Last Pirsone ");
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnphoto
            // 
            this.btnphoto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnphoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphoto.Location = new System.Drawing.Point(573, 264);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(179, 54);
            this.btnphoto.TabIndex = 16;
            this.btnphoto.Text = "Choose A Photo";
            this.toolTip1.SetToolTip(this.btnphoto, "Click Here To Choose A Photo");
            this.btnphoto.UseVisualStyleBackColor = false;
            this.btnphoto.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(572, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fillToolStripMenuItem.Text = "Fille";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aboutToolStripMenuItem.Text = "More";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.infoToolStripMenuItem.Text = "About";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(764, 330);
            this.Controls.Add(this.btnphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnphoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}

