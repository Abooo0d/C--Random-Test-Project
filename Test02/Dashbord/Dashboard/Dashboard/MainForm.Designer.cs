namespace Dashboard
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedite = new System.Windows.Forms.Button();
            btnhome = new System.Windows.Forms.Button();
            lblerrorprovider = new System.Windows.Forms.Label();
            this.pnltopborder = new System.Windows.Forms.Panel();
            this.btnplate = new System.Windows.Forms.Button();
            this.btnperson = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlcontaner = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxallprojects = new System.Windows.Forms.ListBox();
            this.lbxsearchresulte = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltopborder.SuspendLayout();
            this.pnlcontaner.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnedite);
            this.panel1.Controls.Add(btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 552);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 282);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 154);
            this.panel2.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblusername.Location = new System.Drawing.Point(33, 119);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(112, 18);
            this.lblusername.TabIndex = 2;
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkFinal.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnadd.Image = global::WorkFinal.Properties.Resources.diagram;
            this.btnadd.Location = new System.Drawing.Point(0, 240);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 42);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.Leave += new System.EventHandler(this.btnadd_Leave);
            // 
            // btnedite
            // 
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnedite.Image = global::WorkFinal.Properties.Resources.calendar;
            this.btnedite.Location = new System.Drawing.Point(0, 198);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(186, 42);
            this.btnedite.TabIndex = 1;
            this.btnedite.Text = "Edite";
            this.btnedite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnedite.UseVisualStyleBackColor = true;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            this.btnedite.Leave += new System.EventHandler(this.btnedite_Leave);
            // 
            // btnhome
            // 
            btnhome.FlatAppearance.BorderSize = 0;
            btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnhome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            btnhome.Image = global::WorkFinal.Properties.Resources.home;
            btnhome.Location = new System.Drawing.Point(0, 156);
            btnhome.Name = "btnhome";
            btnhome.Size = new System.Drawing.Size(186, 42);
            btnhome.TabIndex = 1;
            btnhome.Text = "Home";
            btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += new System.EventHandler(this.btnhome_Click);
            btnhome.Leave += new System.EventHandler(this.btnhome_Leave);
            // 
            // lblerrorprovider
            // 
            lblerrorprovider.AutoSize = true;
            lblerrorprovider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblerrorprovider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            lblerrorprovider.Location = new System.Drawing.Point(6, 498);
            lblerrorprovider.Name = "lblerrorprovider";
            lblerrorprovider.Size = new System.Drawing.Size(0, 12);
            lblerrorprovider.TabIndex = 3;
            // 
            // pnltopborder
            // 
            this.pnltopborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnltopborder.Controls.Add(this.btnplate);
            this.pnltopborder.Controls.Add(this.btnperson);
            this.pnltopborder.Controls.Add(this.txtsearch);
            this.pnltopborder.Controls.Add(this.btnexit);
            this.pnltopborder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopborder.Location = new System.Drawing.Point(186, 0);
            this.pnltopborder.Name = "pnltopborder";
            this.pnltopborder.Size = new System.Drawing.Size(938, 35);
            this.pnltopborder.TabIndex = 13;
            this.pnltopborder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltopborder_MouseDown);
            this.pnltopborder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltopborder_MouseMove);
            this.pnltopborder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltopborder_MouseUp);
            // 
            // btnplate
            // 
            this.btnplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnplate.FlatAppearance.BorderSize = 0;
            this.btnplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplate.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnplate.Location = new System.Drawing.Point(786, 7);
            this.btnplate.Name = "btnplate";
            this.btnplate.Size = new System.Drawing.Size(47, 22);
            this.btnplate.TabIndex = 39;
            this.btnplate.Text = "plate";
            this.btnplate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnplate.UseVisualStyleBackColor = false;
            this.btnplate.Click += new System.EventHandler(this.btnplate_Click);
            // 
            // btnperson
            // 
            this.btnperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnperson.FlatAppearance.BorderSize = 0;
            this.btnperson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnperson.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnperson.Location = new System.Drawing.Point(835, 7);
            this.btnperson.Name = "btnperson";
            this.btnperson.Size = new System.Drawing.Size(51, 22);
            this.btnperson.TabIndex = 38;
            this.btnperson.Text = "person";
            this.btnperson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnperson.UseVisualStyleBackColor = false;
            this.btnperson.Click += new System.EventHandler(this.btnperson_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtsearch.Location = new System.Drawing.Point(537, 10);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(243, 16);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.Text = "Search.";
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnexit.Location = new System.Drawing.Point(905, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 30);
            this.btnexit.TabIndex = 36;
            this.btnexit.Text = "X";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlcontaner
            // 
            this.pnlcontaner.Controls.Add(lblerrorprovider);
            this.pnlcontaner.Location = new System.Drawing.Point(189, 36);
            this.pnlcontaner.Name = "pnlcontaner";
            this.pnlcontaner.Size = new System.Drawing.Size(733, 516);
            this.pnlcontaner.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbxallprojects);
            this.panel4.Controls.Add(this.lbxsearchresulte);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(924, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 517);
            this.panel4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(4, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "All Projects:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Resules:";
            // 
            // lbxallprojects
            // 
            this.lbxallprojects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.lbxallprojects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxallprojects.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbxallprojects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbxallprojects.FormattingEnabled = true;
            this.lbxallprojects.ItemHeight = 17;
            this.lbxallprojects.Location = new System.Drawing.Point(5, 203);
            this.lbxallprojects.Name = "lbxallprojects";
            this.lbxallprojects.Size = new System.Drawing.Size(190, 306);
            this.lbxallprojects.TabIndex = 1;
            this.lbxallprojects.SelectedIndexChanged += new System.EventHandler(this.lbxallprojects_SelectedIndexChanged);
            // 
            // lbxsearchresulte
            // 
            this.lbxsearchresulte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.lbxsearchresulte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxsearchresulte.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbxsearchresulte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbxsearchresulte.FormattingEnabled = true;
            this.lbxsearchresulte.ItemHeight = 17;
            this.lbxsearchresulte.Location = new System.Drawing.Point(4, 42);
            this.lbxsearchresulte.Name = "lbxsearchresulte";
            this.lbxsearchresulte.Size = new System.Drawing.Size(190, 119);
            this.lbxsearchresulte.TabIndex = 0;
            this.lbxsearchresulte.SelectedIndexChanged += new System.EventHandler(this.lbxsearchresulte_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1124, 552);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlcontaner);
            this.Controls.Add(this.pnltopborder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltopborder.ResumeLayout(false);
            this.pnltopborder.PerformLayout();
            this.pnlcontaner.ResumeLayout(false);
            this.pnlcontaner.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnedite;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnltopborder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbxsearchresulte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxallprojects;
        public static System.Windows.Forms.Label lblerrorprovider;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnplate;
        private System.Windows.Forms.Button btnperson;
        private System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.Panel pnlcontaner;
        public static System.Windows.Forms.Button btnhome;
    }
}

