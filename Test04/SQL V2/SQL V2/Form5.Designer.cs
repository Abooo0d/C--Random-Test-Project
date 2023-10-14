namespace SQL_V2
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.my_Final_ProjectDataSet = new SQL_V2.My_Final_ProjectDataSet();
            this.readySetupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ready_SetupsTableAdapter = new SQL_V2.My_Final_ProjectDataSetTableAdapters.Ready_SetupsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_Final_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readySetupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 298);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ready Setups:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "RAM:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "Hard_Disc", true));
            this.textBox5.Location = new System.Drawing.Point(294, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(219, 31);
            this.textBox5.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "RAM", true));
            this.textBox7.Location = new System.Drawing.Point(294, 212);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(219, 31);
            this.textBox7.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hard Disc Cpacity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "CPU Name:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "Graphic_Card_Name", true));
            this.textBox6.Location = new System.Drawing.Point(294, 175);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(219, 31);
            this.textBox6.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "CPU_Name", true));
            this.textBox4.Location = new System.Drawing.Point(294, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 31);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "MatherBord_Name", true));
            this.textBox3.Location = new System.Drawing.Point(294, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 31);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "Brand", true));
            this.textBox2.Location = new System.Drawing.Point(294, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 31);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readySetupsBindingSource, "ID", true));
            this.textBox1.Location = new System.Drawing.Point(294, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 31);
            this.textBox1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Graphic Card Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "MatherBord Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Setup ID:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(425, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 83);
            this.button3.TabIndex = 18;
            this.button3.Text = "First Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(152, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 83);
            this.button2.TabIndex = 17;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 83);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // my_Final_ProjectDataSet
            // 
            this.my_Final_ProjectDataSet.DataSetName = "My_Final_ProjectDataSet";
            this.my_Final_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readySetupsBindingSource
            // 
            this.readySetupsBindingSource.DataMember = "Ready_Setups";
            this.readySetupsBindingSource.DataSource = this.my_Final_ProjectDataSet;
            // 
            // ready_SetupsTableAdapter
            // 
            this.ready_SetupsTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(553, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(553, 414);
            this.MinimumSize = new System.Drawing.Size(553, 414);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_Final_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readySetupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private My_Final_ProjectDataSet my_Final_ProjectDataSet;
        private System.Windows.Forms.BindingSource readySetupsBindingSource;
        private My_Final_ProjectDataSetTableAdapters.Ready_SetupsTableAdapter ready_SetupsTableAdapter;
    }
}