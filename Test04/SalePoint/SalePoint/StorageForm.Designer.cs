namespace SalePoint
{
    partial class StorageForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinemize = new TestToolsOnForms.Custom_Button();
            this.btnExit = new TestToolsOnForms.Custom_Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnUpdate = new TestToolsOnForms.Custom_Button();
            this.btnDelet = new TestToolsOnForms.Custom_Button();
            this.btnBack = new TestToolsOnForms.Custom_Button();
            this.btnNext = new TestToolsOnForms.Custom_Button();
            this.txtColor = new TestToolsOnForms.TextBox();
            this.txtQunity = new TestToolsOnForms.TextBox();
            this.txtPrice = new TestToolsOnForms.TextBox();
            this.txtMaterialName = new TestToolsOnForms.TextBox();
            this.txtMaterialNum = new TestToolsOnForms.TextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnMinemize);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(757, 33);
            this.topPanel.TabIndex = 10;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseLeave += new System.EventHandler(this.topPanel_MouseLeave);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Storage Page";
            // 
            // btnMinemize
            // 
            this.btnMinemize.BackColor = System.Drawing.Color.Gold;
            this.btnMinemize.BackGraundColor = System.Drawing.Color.Gold;
            this.btnMinemize.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnMinemize.BorderRadius = 10;
            this.btnMinemize.BorderSize = 0;
            this.btnMinemize.FlatAppearance.BorderSize = 0;
            this.btnMinemize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinemize.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinemize.ForeColor = System.Drawing.Color.Black;
            this.btnMinemize.Location = new System.Drawing.Point(695, 2);
            this.btnMinemize.Name = "btnMinemize";
            this.btnMinemize.Size = new System.Drawing.Size(27, 27);
            this.btnMinemize.TabIndex = 11;
            this.btnMinemize.Text = "-";
            this.btnMinemize.TextColor = System.Drawing.Color.Black;
            this.btnMinemize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackGraundColor = System.Drawing.Color.Red;
            this.btnExit.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(726, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "X";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(537, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Material Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(545, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Materila Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(579, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = " Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(570, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quntity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(580, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Color";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.BackGraundColor = System.Drawing.Color.Gold;
            this.btnUpdate.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdate.BorderRadius = 40;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(580, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 50);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDelet.BackGraundColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDelet.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnDelet.BorderRadius = 40;
            this.btnDelet.BorderSize = 0;
            this.btnDelet.FlatAppearance.BorderSize = 0;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(390, 313);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(165, 50);
            this.btnDelet.TabIndex = 22;
            this.btnDelet.Text = "Delet";
            this.btnDelet.TextColor = System.Drawing.Color.White;
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.BackGraundColor = System.Drawing.Color.Crimson;
            this.btnBack.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBack.BorderRadius = 40;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 50);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Crimson;
            this.btnNext.BackGraundColor = System.Drawing.Color.Crimson;
            this.btnNext.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnNext.BorderRadius = 40;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(200, 313);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 50);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtColor
            // 
            this.txtColor._ReadOnly = false;
            this.txtColor._Text = "";
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtColor.BorderSize = 5;
            this.txtColor.FocusColor = System.Drawing.Color.Gold;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtColor.Location = new System.Drawing.Point(30, 241);
            this.txtColor.MultiLine = false;
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(7);
            this.txtColor.PasswordChar = false;
            this.txtColor.Size = new System.Drawing.Size(398, 36);
            this.txtColor.TabIndex = 15;
            this.txtColor.UnderLinedStyle = true;
            // 
            // txtQunity
            // 
            this.txtQunity._ReadOnly = false;
            this.txtQunity._Text = "";
            this.txtQunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtQunity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtQunity.BorderSize = 5;
            this.txtQunity.FocusColor = System.Drawing.Color.MediumSpringGreen;
            this.txtQunity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtQunity.Location = new System.Drawing.Point(30, 194);
            this.txtQunity.MultiLine = false;
            this.txtQunity.Name = "txtQunity";
            this.txtQunity.Padding = new System.Windows.Forms.Padding(7);
            this.txtQunity.PasswordChar = false;
            this.txtQunity.Size = new System.Drawing.Size(398, 36);
            this.txtQunity.TabIndex = 14;
            this.txtQunity.UnderLinedStyle = true;
            // 
            // txtPrice
            // 
            this.txtPrice._ReadOnly = false;
            this.txtPrice._Text = "";
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPrice.BorderSize = 5;
            this.txtPrice.FocusColor = System.Drawing.Color.HotPink;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtPrice.Location = new System.Drawing.Point(30, 147);
            this.txtPrice.MultiLine = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Size = new System.Drawing.Size(398, 36);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.UnderLinedStyle = true;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName._ReadOnly = false;
            this.txtMaterialName._Text = "";
            this.txtMaterialName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtMaterialName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtMaterialName.BorderSize = 5;
            this.txtMaterialName.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMaterialName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtMaterialName.Location = new System.Drawing.Point(30, 100);
            this.txtMaterialName.MultiLine = false;
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaterialName.PasswordChar = false;
            this.txtMaterialName.Size = new System.Drawing.Size(398, 36);
            this.txtMaterialName.TabIndex = 12;
            this.txtMaterialName.UnderLinedStyle = true;
            // 
            // txtMaterialNum
            // 
            this.txtMaterialNum._ReadOnly = true;
            this.txtMaterialNum._Text = "";
            this.txtMaterialNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtMaterialNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtMaterialNum.BorderSize = 5;
            this.txtMaterialNum.FocusColor = System.Drawing.Color.Crimson;
            this.txtMaterialNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtMaterialNum.Location = new System.Drawing.Point(30, 53);
            this.txtMaterialNum.MultiLine = false;
            this.txtMaterialNum.Name = "txtMaterialNum";
            this.txtMaterialNum.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaterialNum.PasswordChar = false;
            this.txtMaterialNum.Size = new System.Drawing.Size(398, 36);
            this.txtMaterialNum.TabIndex = 11;
            this.txtMaterialNum.UnderLinedStyle = true;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(757, 387);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtQunity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.txtMaterialNum);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private TestToolsOnForms.Custom_Button btnMinemize;
        private TestToolsOnForms.Custom_Button btnExit;
        private TestToolsOnForms.TextBox txtMaterialNum;
        private TestToolsOnForms.TextBox txtMaterialName;
        private TestToolsOnForms.TextBox txtPrice;
        private TestToolsOnForms.TextBox txtQunity;
        private TestToolsOnForms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TestToolsOnForms.Custom_Button btnNext;
        private TestToolsOnForms.Custom_Button btnBack;
        private TestToolsOnForms.Custom_Button btnDelet;
        private TestToolsOnForms.Custom_Button btnUpdate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}