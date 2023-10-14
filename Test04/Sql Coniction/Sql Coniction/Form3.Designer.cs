namespace Sql_Coniction
{
    partial class Form3
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.matherBordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.my_Final_ProjectDataSet1 = new Sql_Coniction.My_Final_ProjectDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.my_Final_ProjectDataSet = new Sql_Coniction.My_Final_ProjectDataSet();
            this.matherBordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matherBordTableAdapter1 = new Sql_Coniction.My_Final_ProjectDataSet1TableAdapters.MatherBordTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matherBordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Final_ProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_Final_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matherBordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(373, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 83);
            this.button3.TabIndex = 6;
            this.button3.Text = "Last Page ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mather Bords:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ram Slutes ";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matherBordBindingSource1, "Ram_Slutes", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(241, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 31);
            this.textBox4.TabIndex = 19;
            // 
            // matherBordBindingSource1
            // 
            this.matherBordBindingSource1.DataMember = "MatherBord";
            this.matherBordBindingSource1.DataSource = this.my_Final_ProjectDataSet1;
            // 
            // my_Final_ProjectDataSet1
            // 
            this.my_Final_ProjectDataSet1.DataSetName = "My_Final_ProjectDataSet1";
            this.my_Final_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matherBordBindingSource1, "Brand", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(241, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 31);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matherBordBindingSource1, "Name", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(241, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 31);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mather Bord Name:";
            // 
            // my_Final_ProjectDataSet
            // 
            this.my_Final_ProjectDataSet.DataSetName = "My_Final_ProjectDataSet";
            this.my_Final_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matherBordBindingSource
            // 
            this.matherBordBindingSource.DataMember = "MatherBord";
            this.matherBordBindingSource.DataSource = this.my_Final_ProjectDataSet;
            // 
            // matherBordTableAdapter1
            // 
            this.matherBordTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(502, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 267);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 267);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mather Bords";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
          

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private My_Final_ProjectDataSet my_Final_ProjectDataSet;
        private System.Windows.Forms.BindingSource matherBordBindingSource;
        private My_Final_ProjectDataSet1 my_Final_ProjectDataSet1;
        private System.Windows.Forms.BindingSource matherBordBindingSource1;
        private My_Final_ProjectDataSet1TableAdapters.MatherBordTableAdapter matherBordTableAdapter1;
    }
}