namespace TestToolsOnForms
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
            this.custom_TextBox1 = new TestToolsOnForms.TextBox();
            this.userControl11 = new TestToolsOnForms.TextBox();
            this.SuspendLayout();
            // 
            // custom_TextBox1
            // 
            this.custom_TextBox1._Text = "abod";
            this.custom_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.custom_TextBox1.BorderColor = System.Drawing.Color.Magenta;
            this.custom_TextBox1.BorderSize = 7;
            this.custom_TextBox1.FocusColor = System.Drawing.Color.Crimson;
            this.custom_TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_TextBox1.Location = new System.Drawing.Point(12, 135);
            this.custom_TextBox1.MultiLine = true;
            this.custom_TextBox1.Name = "custom_TextBox1";
            this.custom_TextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.custom_TextBox1.PasswordChar = true;
            this.custom_TextBox1.Size = new System.Drawing.Size(250, 81);
            this.custom_TextBox1.TabIndex = 1;
            this.custom_TextBox1.UnderLinedStyle = true;
            // 
            // userControl11
            // 
            this.userControl11._Text = "";
            this.userControl11.BackColor = System.Drawing.SystemColors.Window;
            this.userControl11.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userControl11.BorderSize = 5;
            this.userControl11.FocusColor = System.Drawing.Color.HotPink;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(12, 65);
            this.userControl11.MultiLine = false;
            this.userControl11.Name = "userControl11";
            this.userControl11.Padding = new System.Windows.Forms.Padding(7);
            this.userControl11.PasswordChar = false;
            this.userControl11.Size = new System.Drawing.Size(250, 31);
            this.userControl11.TabIndex = 0;
            this.userControl11.UnderLinedStyle = true;
            this.userControl11._TextChanged += new System.EventHandler(this.userControl11__TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.custom_TextBox1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox userControl11;
        private TextBox custom_TextBox1;
    }
}

