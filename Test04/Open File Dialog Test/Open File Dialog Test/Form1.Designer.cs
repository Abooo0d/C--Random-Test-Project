namespace Open_File_Dialog_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnchoose = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(135, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(408, 31);
            this.txtPath.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(135, 49);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(408, 31);
            this.txtFileName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name ";
            // 
            // txtExtFile
            // 
            this.txtExtFile.Location = new System.Drawing.Point(135, 86);
            this.txtExtFile.Name = "txtExtFile";
            this.txtExtFile.Size = new System.Drawing.Size(408, 31);
            this.txtExtFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ext File ";
            // 
            // btnchoose
            // 
            this.btnchoose.Location = new System.Drawing.Point(47, 156);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(163, 38);
            this.btnchoose.TabIndex = 6;
            this.btnchoose.Text = "Choose File ";
            this.btnchoose.UseVisualStyleBackColor = true;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 227);
            this.Controls.Add(this.btnchoose);
            this.Controls.Add(this.txtExtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchoose;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

