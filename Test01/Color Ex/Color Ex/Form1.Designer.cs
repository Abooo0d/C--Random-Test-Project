namespace Color_Ex
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
            this.tba = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbr = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbg = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbb = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnma = new System.Windows.Forms.Button();
            this.bynmr = new System.Windows.Forms.Button();
            this.btnmg = new System.Windows.Forms.Button();
            this.btnmb = new System.Windows.Forms.Button();
            this.btnpa = new System.Windows.Forms.Button();
            this.btnpr = new System.Windows.Forms.Button();
            this.btnpg = new System.Windows.Forms.Button();
            this.btnpb = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txta = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txtg = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(160, 15);
            this.tba.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tba.Maximum = 255;
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(653, 45);
            this.tba.TabIndex = 0;
            this.tba.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tba.Scroll += new System.EventHandler(this.tba_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "R:";
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(160, 62);
            this.tbr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbr.Maximum = 255;
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(653, 45);
            this.tbr.TabIndex = 2;
            this.tbr.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "G:";
            // 
            // tbg
            // 
            this.tbg.Location = new System.Drawing.Point(160, 108);
            this.tbg.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbg.Maximum = 255;
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(653, 45);
            this.tbg.TabIndex = 4;
            this.tbg.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbg.Scroll += new System.EventHandler(this.tbg_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "B:";
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(160, 151);
            this.tbb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbb.Maximum = 255;
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(653, 45);
            this.tbb.TabIndex = 6;
            this.tbb.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbb.Scroll += new System.EventHandler(this.tbb_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 78);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnma
            // 
            this.btnma.Location = new System.Drawing.Point(108, 20);
            this.btnma.Name = "btnma";
            this.btnma.Size = new System.Drawing.Size(42, 31);
            this.btnma.TabIndex = 9;
            this.btnma.Text = "-";
            this.btnma.UseVisualStyleBackColor = true;
            this.btnma.Click += new System.EventHandler(this.btnma_Click);
            // 
            // bynmr
            // 
            this.bynmr.Location = new System.Drawing.Point(108, 67);
            this.bynmr.Name = "bynmr";
            this.bynmr.Size = new System.Drawing.Size(42, 31);
            this.bynmr.TabIndex = 10;
            this.bynmr.Text = "-";
            this.bynmr.UseVisualStyleBackColor = true;
            this.bynmr.Click += new System.EventHandler(this.bynmr_Click);
            // 
            // btnmg
            // 
            this.btnmg.Location = new System.Drawing.Point(108, 113);
            this.btnmg.Name = "btnmg";
            this.btnmg.Size = new System.Drawing.Size(42, 31);
            this.btnmg.TabIndex = 11;
            this.btnmg.Text = "-";
            this.btnmg.UseVisualStyleBackColor = true;
            this.btnmg.Click += new System.EventHandler(this.btnmg_Click);
            // 
            // btnmb
            // 
            this.btnmb.Location = new System.Drawing.Point(108, 156);
            this.btnmb.Name = "btnmb";
            this.btnmb.Size = new System.Drawing.Size(42, 31);
            this.btnmb.TabIndex = 12;
            this.btnmb.Text = "-";
            this.btnmb.UseVisualStyleBackColor = true;
            this.btnmb.Click += new System.EventHandler(this.btnmb_Click);
            // 
            // btnpa
            // 
            this.btnpa.Location = new System.Drawing.Point(823, 20);
            this.btnpa.Name = "btnpa";
            this.btnpa.Size = new System.Drawing.Size(42, 31);
            this.btnpa.TabIndex = 13;
            this.btnpa.Text = "+";
            this.btnpa.UseVisualStyleBackColor = true;
            this.btnpa.Click += new System.EventHandler(this.btnpa_Click_1);
            // 
            // btnpr
            // 
            this.btnpr.Location = new System.Drawing.Point(823, 67);
            this.btnpr.Name = "btnpr";
            this.btnpr.Size = new System.Drawing.Size(42, 31);
            this.btnpr.TabIndex = 14;
            this.btnpr.Text = "+";
            this.btnpr.UseVisualStyleBackColor = true;
            this.btnpr.Click += new System.EventHandler(this.btnpr_Click);
            // 
            // btnpg
            // 
            this.btnpg.Location = new System.Drawing.Point(823, 113);
            this.btnpg.Name = "btnpg";
            this.btnpg.Size = new System.Drawing.Size(42, 31);
            this.btnpg.TabIndex = 15;
            this.btnpg.Text = "+";
            this.btnpg.UseVisualStyleBackColor = true;
            this.btnpg.Click += new System.EventHandler(this.btnpg_Click);
            // 
            // btnpb
            // 
            this.btnpb.Location = new System.Drawing.Point(823, 156);
            this.btnpb.Name = "btnpb";
            this.btnpb.Size = new System.Drawing.Size(42, 31);
            this.btnpb.TabIndex = 16;
            this.btnpb.Text = "+";
            this.btnpb.UseVisualStyleBackColor = true;
            this.btnpb.Click += new System.EventHandler(this.btnpb_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(51, 20);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(48, 31);
            this.txta.TabIndex = 17;
            this.txta.Text = "0";
            this.txta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(54, 67);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(48, 31);
            this.txtr.TabIndex = 18;
            this.txtr.Text = "0";
            this.txtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtr.TextChanged += new System.EventHandler(this.txtr_TextChanged);
            // 
            // txtg
            // 
            this.txtg.Location = new System.Drawing.Point(54, 113);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(48, 31);
            this.txtg.TabIndex = 19;
            this.txtg.Text = "0";
            this.txtg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtg.TextChanged += new System.EventHandler(this.txtg_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(54, 156);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(48, 31);
            this.txtb.TabIndex = 20;
            this.txtb.Text = "0";
            this.txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 312);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtg);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btnpb);
            this.Controls.Add(this.btnpg);
            this.Controls.Add(this.btnpr);
            this.Controls.Add(this.btnpa);
            this.Controls.Add(this.btnmb);
            this.Controls.Add(this.btnmg);
            this.Controls.Add(this.bynmr);
            this.Controls.Add(this.btnma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnma;
        private System.Windows.Forms.Button bynmr;
        private System.Windows.Forms.Button btnmg;
        private System.Windows.Forms.Button btnmb;
        private System.Windows.Forms.Button btnpa;
        private System.Windows.Forms.Button btnpr;
        private System.Windows.Forms.Button btnpg;
        private System.Windows.Forms.Button btnpb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.TextBox txtb;
    }
}

