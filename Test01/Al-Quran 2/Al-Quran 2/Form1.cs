using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Al_Quran_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            this.lbl13.Click += new System.EventHandler(this.lbl13_Click);
            this.lbl14.Click += new System.EventHandler(this.lbl14_Click);
            this.lbl15.Click += new System.EventHandler(this.lbl15_Click);
            this.lbl16.Click += new System.EventHandler(this.lbl16_Click);
            this.lbl17.Click += new System.EventHandler(this.lbl17_Click);
            this.lbl18.Click += new System.EventHandler(this.lbl18_Click);
            this.lbl19.Click += new System.EventHandler(this.lbl19_Click);
            this.lbl20.Click += new System.EventHandler(this.lbl20_Click);
            this.lbl21.Click += new System.EventHandler(this.lbl21_Click);
            this.lbl22.Click += new System.EventHandler(this.lbl22_Click);
            this.lbl23.Click += new System.EventHandler(this.lbl23_Click);
            this.lbl24.Click += new System.EventHandler(this.lbl24_Click);
            this.lbl25.Click += new System.EventHandler(this.lbl25_Click);
            this.lbl26.Click += new System.EventHandler(this.lbl26_Click);
            this.lbl27.Click += new System.EventHandler(this.lbl27_Click);
            this.lbl28.Click += new System.EventHandler(this.lbl28_Click);
            this.lbl29.Click += new System.EventHandler(this.lbl29_Click);
            this.lbl30.Click += new System.EventHandler(this.lbl30_Click);
            this.l1.Click += new System.EventHandler(this.l1_Click);
            this.l2.Click += new System.EventHandler(this.l2_Click);
            this.l3.Click += new System.EventHandler(this.l3_Click);
            this.l4.Click += new System.EventHandler(this.l4_Click);
            this.l5.Click += new System.EventHandler(this.l5_Click);
            this.l6.Click += new System.EventHandler(this.l6_Click);
            this.l7.Click += new System.EventHandler(this.l7_Click);
            this.l8.Click += new System.EventHandler(this.l8_Click);
            this.l9.Click += new System.EventHandler(this.l9_Click);
            this.l10.Click += new System.EventHandler(this.l10_Click);
            this.l11.Click += new System.EventHandler(this.l11_Click);
            this.l12.Click += new System.EventHandler(this.l12_Click);
            this.l13.Click += new System.EventHandler(this.l13_Click);
            this.l14.Click += new System.EventHandler(this.l14_Click);
            this.l15.Click += new System.EventHandler(this.l15_Click);
            this.l16.Click += new System.EventHandler(this.l16_Click);
            this.l17.Click += new System.EventHandler(this.l17_Click);
            this.l18.Click += new System.EventHandler(this.l18_Click);
            this.l19.Click += new System.EventHandler(this.l19_Click);
            this.l20.Click += new System.EventHandler(this.l20_Click);
            this.l21.Click += new System.EventHandler(this.l21_Click);
            this.l22.Click += new System.EventHandler(this.l22_Click);
            this.l23.Click += new System.EventHandler(this.l23_Click);
            this.l24.Click += new System.EventHandler(this.l24_Click);
            this.l25.Click += new System.EventHandler(this.l25_Click);
            this.l26.Click += new System.EventHandler(this.l26_Click);
            this.l27.Click += new System.EventHandler(this.l27_Click);
            this.l28.Click += new System.EventHandler(this.l28_Click);
            this.l29.Click += new System.EventHandler(this.l29_Click);
            this.l30.Click += new System.EventHandler(this.l30_Click);
            this.l31.Click += new System.EventHandler(this.l31_Click);
            this.l32.Click += new System.EventHandler(this.l32_Click);
            this.l33.Click += new System.EventHandler(this.l33_Click);
            this.l34.Click += new System.EventHandler(this.l34_Click);
            this.l35.Click += new System.EventHandler(this.l35_Click);
            this.l36.Click += new System.EventHandler(this.l36_Click);
            this.l37.Click += new System.EventHandler(this.l37_Click);
            this.l38.Click += new System.EventHandler(this.l38_Click);
            this.l39.Click += new System.EventHandler(this.l39_Click);
            this.l40.Click += new System.EventHandler(this.l40_Click);
            this.l41.Click += new System.EventHandler(this.l41_Click);
            this.l42.Click += new System.EventHandler(this.l42_Click);
            this.l43.Click += new System.EventHandler(this.l43_Click);
            this.l44.Click += new System.EventHandler(this.l44_Click);
            this.l25.Click += new System.EventHandler(this.l45_Click);
            this.l46.Click += new System.EventHandler(this.l46_Click);
            this.l47.Click += new System.EventHandler(this.l47_Click);
            this.l48.Click += new System.EventHandler(this.l48_Click);
            this.l49.Click += new System.EventHandler(this.l19_Click);
            this.l50.Click += new System.EventHandler(this.l50_Click);
            this.l51.Click += new System.EventHandler(this.l51_Click);
            this.l52.Click += new System.EventHandler(this.l52_Click);
            this.l53.Click += new System.EventHandler(this.l53_Click);
            this.l54.Click += new System.EventHandler(this.l54_Click);
            this.l55.Click += new System.EventHandler(this.l55_Click);
            this.l56.Click += new System.EventHandler(this.l56_Click);
            this.l57.Click += new System.EventHandler(this.l57_Click);
            this.l58.Click += new System.EventHandler(this.l58_Click);
            this.l59.Click += new System.EventHandler(this.l59_Click);
            this.l60.Click += new System.EventHandler(this.l60_Click);
            this.l61.Click += new System.EventHandler(this.l61_Click);
            this.l62.Click += new System.EventHandler(this.l62_Click);
            this.l63.Click += new System.EventHandler(this.l63_Click);
            this.l64.Click += new System.EventHandler(this.l64_Click);
            this.l65.Click += new System.EventHandler(this.l65_Click);
            this.l66.Click += new System.EventHandler(this.l66_Click);
            this.l67.Click += new System.EventHandler(this.l67_Click);
            this.l68.Click += new System.EventHandler(this.l68_Click);
            this.l69.Click += new System.EventHandler(this.l69_Click);
            this.l70.Click += new System.EventHandler(this.l70_Click);
            this.l71.Click += new System.EventHandler(this.l71_Click);
            this.l72.Click += new System.EventHandler(this.l72_Click);
            this.l73.Click += new System.EventHandler(this.l73_Click);
            this.l74.Click += new System.EventHandler(this.l74_Click);
            this.l75.Click += new System.EventHandler(this.l75_Click);
            this.l76.Click += new System.EventHandler(this.l76_Click);
            this.l77.Click += new System.EventHandler(this.l77_Click);
            this.l78.Click += new System.EventHandler(this.l78_Click);
            this.l79.Click += new System.EventHandler(this.l79_Click);
            this.l80.Click += new System.EventHandler(this.l80_Click);
            this.l81.Click += new System.EventHandler(this.l81_Click);
            this.l82.Click += new System.EventHandler(this.l82_Click);
            this.l83.Click += new System.EventHandler(this.l83_Click);
            this.l84.Click += new System.EventHandler(this.l84_Click);
            this.l85.Click += new System.EventHandler(this.l85_Click);
            this.l86.Click += new System.EventHandler(this.l86_Click);
            this.l87.Click += new System.EventHandler(this.l87_Click);
            this.l88.Click += new System.EventHandler(this.l88_Click);
            this.l89.Click += new System.EventHandler(this.l89_Click);
            this.l90.Click += new System.EventHandler(this.l90_Click);
            this.l91.Click += new System.EventHandler(this.l91_Click);
            this.l92.Click += new System.EventHandler(this.l92_Click);
            this.l93.Click += new System.EventHandler(this.l93_Click);
            this.l94.Click += new System.EventHandler(this.l94_Click);
            this.l95.Click += new System.EventHandler(this.l95_Click);
            this.l96.Click += new System.EventHandler(this.l96_Click);
            this.l97.Click += new System.EventHandler(this.l97_Click);
            this.l98.Click += new System.EventHandler(this.l98_Click);
            this.l99.Click += new System.EventHandler(this.l99_Click);
            this.l100.Click += new System.EventHandler(this.l100_Click);
            this.l101.Click += new System.EventHandler(this.l101_Click);
            this.l102.Click += new System.EventHandler(this.l102_Click);
            this.l103.Click += new System.EventHandler(this.l103_Click);
            this.l104.Click += new System.EventHandler(this.l104_Click);
            this.l105.Click += new System.EventHandler(this.l105_Click);
            this.l106.Click += new System.EventHandler(this.l106_Click);
            this.l107.Click += new System.EventHandler(this.l107_Click);
            this.l108.Click += new System.EventHandler(this.l108_Click);
            this.l109.Click += new System.EventHandler(this.l109_Click);
            this.l110.Click += new System.EventHandler(this.l110_Click);
            this.l111.Click += new System.EventHandler(this.l111_Click);
            this.l112.Click += new System.EventHandler(this.l112_Click);
            this.l113.Click += new System.EventHandler(this.l113_Click);
            this.l114.Click += new System.EventHandler(this.l114_Click);
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            this.button.Click += new System.EventHandler(this.button_Click);
            this.frm4.Load += new System.EventHandler(this.frm4_load);
        }
        int i = 1;
        int t = 0;
        //frm1
        // Mane Menue 
        Form frm1 = new Form();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        //End

        //frm2
        //Parts Form 
        Form frm2 = new Form();
        Label lbl1 = new Label();
        Label lbl2 = new Label();
        Label lbl3 = new Label();
        Label lbl4 = new Label();
        Label lbl5 = new Label();
        Label lbl6 = new Label();
        Label lbl7 = new Label();
        Label lbl8 = new Label();
        Label lbl9 = new Label();
        Label lbl10 = new Label();
        Label lbl11 = new Label();
        Label lbl12 = new Label();
        Label lbl13 = new Label();
        Label lbl14 = new Label();
        Label lbl15 = new Label();
        Label lbl16 = new Label();
        Label lbl17 = new Label();
        Label lbl18 = new Label();
        Label lbl19 = new Label();
        Label lbl20 = new Label();
        Label lbl21 = new Label();
        Label lbl22 = new Label();
        Label lbl23 = new Label();
        Label lbl24 = new Label();
        Label lbl25 = new Label();
        Label lbl26 = new Label();
        Label lbl27 = new Label();
        Label lbl28 = new Label();
        Label lbl29 = new Label();
        Label lbl30 = new Label();
        //End

        //frm3
        //Sware Al-Qurane Form 
        Form frm3 = new Form();
        Label l1 = new Label();
        Label l2 = new Label();
        Label l3 = new Label();
        Label l4 = new Label();
        Label l5 = new Label();
        Label l6 = new Label();
        Label l7 = new Label();
        Label l8 = new Label();
        Label l9 = new Label();
        Label l10 = new Label();
        Label l11 = new Label();
        Label l12 = new Label();
        Label l13 = new Label();
        Label l14 = new Label();
        Label l15 = new Label();
        Label l16 = new Label();
        Label l17 = new Label();
        Label l18 = new Label();
        Label l19 = new Label();
        Label l20 = new Label();
        Label l21 = new Label();
        Label l22 = new Label();
        Label l23 = new Label();
        Label l24 = new Label();
        Label l25 = new Label();
        Label l26 = new Label();
        Label l27 = new Label();
        Label l28 = new Label();
        Label l29 = new Label();
        Label l30 = new Label();
        Label l31 = new Label();
        Label l32 = new Label();
        Label l33 = new Label();
        Label l34 = new Label();
        Label l35 = new Label();
        Label l36 = new Label();
        Label l37 = new Label();
        Label l38 = new Label();
        Label l39 = new Label();
        Label l40 = new Label();
        Label l41 = new Label();
        Label l42 = new Label();
        Label l43 = new Label();
        Label l44 = new Label();
        Label l45 = new Label();
        Label l46 = new Label();
        Label l47 = new Label();
        Label l48 = new Label();
        Label l49 = new Label();
        Label l50 = new Label();
        Label l51 = new Label();
        Label l52 = new Label();
        Label l53 = new Label();
        Label l54 = new Label();
        Label l55 = new Label();
        Label l56 = new Label();
        Label l57 = new Label();
        Label l58 = new Label();
        Label l59 = new Label();
        Label l60 = new Label();
        Label l61 = new Label();
        Label l62 = new Label();
        Label l63 = new Label();
        Label l64 = new Label();
        Label l65 = new Label();
        Label l66 = new Label();
        Label l67 = new Label();
        Label l68 = new Label();
        Label l69 = new Label();
        Label l70 = new Label();
        Label l71 = new Label();
        Label l72 = new Label();
        Label l73 = new Label();
        Label l74 = new Label();
        Label l75 = new Label();
        Label l76 = new Label();
        Label l77 = new Label();
        Label l78 = new Label();
        Label l79 = new Label();
        Label l80 = new Label();
        Label l81 = new Label();
        Label l82 = new Label();
        Label l83 = new Label();
        Label l84 = new Label();
        Label l85 = new Label();
        Label l86 = new Label();
        Label l87 = new Label();
        Label l88 = new Label();
        Label l89 = new Label();
        Label l90 = new Label();
        Label l91 = new Label();
        Label l92 = new Label();
        Label l93 = new Label();
        Label l94 = new Label();
        Label l95 = new Label();
        Label l96 = new Label();
        Label l97 = new Label();
        Label l98 = new Label();
        Label l99 = new Label();
        Label l100 = new Label();
        Label l101 = new Label();
        Label l102 = new Label();
        Label l103 = new Label();
        Label l104 = new Label();
        Label l105 = new Label();
        Label l106 = new Label();
        Label l107 = new Label();
        Label l108 = new Label();
        Label l109 = new Label();
        Label l110 = new Label();
        Label l111 = new Label();
        Label l112 = new Label();
        Label l113 = new Label();
        Label l114 = new Label();
        //End

        //frm4
        //Saves Form 
        Form frm4 = new Form();
        Label lb1 = new Label();
        Label lb2 = new Label();
        Label lb3 = new Label();
        Label lb4 = new Label();
        Label lb5 = new Label();
        Label lb6 = new Label();
        Label lb7 = new Label();
        Label lb8 = new Label();
        Label lb9 = new Label();
        Label lb10 = new Label();
        //End

        //frm5
        //Saves Option1 Form
        Form frm5 = new Form();
        Button bt1 = new Button();
        Button bt2 = new Button();
        //End

        //frm6
        //Saves Option2Form
        Form frm6 = new Form();
        Label label1 = new Label();
        Label label2 = new Label();
        TextBox textbox1 = new TextBox();
        Button button  = new Button();
        //End

        //Form1
        //Al-Qurane Secreen 
        private void Form1_Load(object sender, EventArgs e)
        {
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            this.Hide();
            frm1.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            frm1.StartPosition = FormStartPosition.CenterScreen;
            frm1.Size = new Size(400, 520);
            frm1.BackColor = Color.DimGray;
            frm1.MaximizeBox = false;
            frm1.MinimizeBox = false;
            frm1.MaximumSize = new Size(400, 520);
            frm1.MinimumSize = new Size(400, 520);
            frm1.Icon = this.Icon;
            if (t == 0)
            {
                frm1.Text = "القرأن";
            }
            else if (t == 1)
            {
                frm1.Text = "Al Quran ";
            }
            btn1.FlatStyle = FlatStyle.Popup;
            btn2.FlatStyle = FlatStyle.Popup;
            btn3.FlatStyle = FlatStyle.Popup;
            btn4.FlatStyle = FlatStyle.Popup;
            btn5.FlatStyle = FlatStyle.Popup;
            btn6.FlatStyle = FlatStyle.Popup;
            btn1.BackColor = Color.Gray;
            btn2.BackColor = Color.Gray;
            btn3.BackColor = Color.Gray;
            btn4.BackColor = Color.Gray;
            btn5.BackColor = Color.Gray;
            btn6.BackColor = Color.Gray;
            btn1.Height = 75;
            btn1.Width = 250;
            btn3.Height = 75;
            btn3.Width = 250;
            btn4.Height = 75;
            btn4.Width = 250;
            btn2.Height = 75;
            btn2.Width = 120;
            btn5.Height = 75;
            btn5.Width = 120;
            btn6.Height = 75;
            btn6.Width = 250;
            btn1.Text = "إبدأ";
            btn2.Text = "اللغة";
            btn3.Text = "الأجزاء";
            btn4.Text = "السور";
            btn5.Text = "خروج ";
            btn6.Text = "المحفوظات ";
            frm1.Controls.Add(btn1);
            frm1.Controls.Add(btn2);
            frm1.Controls.Add(btn3);
            frm1.Controls.Add(btn4);
            frm1.Controls.Add(btn5);
            frm1.Controls.Add(btn6);
            btn1.Top = 35;
            btn2.Top = 375;
            btn3.Top = 290;
            btn4.Top = 205;
            btn5.Top = 375;
            btn6.Top = 120;
            btn1.Left = 75;
            btn2.Left = 205;
            btn3.Left = 75;
            btn4.Left = 75;
            btn5.Left = 75;
            btn6.Left = 75;
            frm1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (i % 2 != 0)
            {
                if (i >= 0)
                {
                    i -= 4;
                    if (File.Exists("image//" + i + ".png"))
                    {
                        pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                        i++;
                    }
                }
            }
            if (i % 2 == 0)
            {
                if (i >= 0)
                {

                    if (File.Exists("image//" + i + ".png"))
                    {
                        pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                        i++;
                    }
                }
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (i % 2 != 0)
            {
                if (i <= 604)
                {
                    if (File.Exists("image//" + i + ".png"))
                    {
                        pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                        i++;
                    }
                }
            }
            if (i % 2 == 0)
            {
                if (i <= 604)
                {
                    if (File.Exists("image//" + i + ".png"))
                    {
                        pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                        i++;
                    }
                }
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.ShowDialog();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            frm5.BackColor = Color.DimGray;
            frm5.Font = this.Font;
            frm5.Size = new Size(320, 270);
            frm5.MinimumSize = new Size(320, 270);
            frm5.MaximumSize = new Size(320, 270);
            frm5.MaximizeBox = false;
            frm5.MinimizeBox = false;
            frm5.AutoScroll = false;
            if (t == 0)
            {
                frm5.Text = "الحفظ ";
            }
            else if (t == 1)
            {
                frm5.Text = "Saving ";
            }
            frm5.Icon = this.Icon;
            frm5.StartPosition = FormStartPosition.CenterScreen;


            bt1.BackColor = Color.Gray;
            bt1.Size = new Size(250, 75);
            bt1.Font = frm5.Font;
            bt1.Location = new Point(25, 25);
            bt1.Font = this.Font;
            bt1.FlatStyle = FlatStyle.Popup;
            if (t == 0)
            {
                bt1.Text = "حفظ ";
                bt1.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            else if (t == 1)
            {
                bt1.Text = "Save ";
                bt1.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            bt2.BackColor = Color.Gray;
            bt2.Size = new Size(250, 75);
            bt2.Font = frm5.Font;
            bt2.Location = new Point(25, 125);
            bt2.Font = this.Font;
            bt2.FlatStyle = FlatStyle.Popup;
            if (t == 0)
            {
                bt2.Text = "المحفوظات ";
                bt2.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            else if (t == 1)
            {
                bt2.Text = "The Saves ";
                bt2.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            frm5.Controls.Add(bt1);
            frm5.Controls.Add(bt2);
            frm5.ShowDialog();
        }
        //End

        //frm1
        //The Main Menu 
        private void btn1_Click(object sender, EventArgs e)
        {
            i = 1;
            if (File.Exists("image//" + i + ".png"))
            {
                pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                i++;
            }
            if (File.Exists("image//" + i + ".png"))
            {
                pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                i++;
            }
            Application.OpenForms[0].Show();
            frm1.Close();

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (t == 0)
            {
                btn1.Text = "Start";
                btn2.Text = "Language";
                btn3.Text = "Al-Ajzaa";
                btn4.Text = "Al-Sowar";
                btn5.Text = "Exit";
                btn6.Text = "The Saves ";
                t = 1;
            }
            else if (t == 1)
            {
                btn1.Text = "إبدأ";
                btn2.Text = "اللغة";
                btn3.Text = "الأجزاء";
                btn4.Text = "السور ";
                btn5.Text = "خروج ";
                btn6.Text = "المحفوظات ";
                t = 0;
            }

        }
        private void btn3_Click(object sender, EventArgs e)
        {

            frm2.Size = new Size(630, 700);
            frm2.MaximumSize = new Size(630, 700);
            frm2.MinimumSize = new Size(630, 700);
            frm2.BackColor = this.BackColor;
            frm2.Icon = this.Icon;
            frm2.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            frm2.AutoScroll = true;
            frm2.StartPosition = FormStartPosition.CenterScreen;
            frm2.Icon = this.Icon;
            if (t == 0)
            {
                frm2.Text = "الأجزاء ";
            }
            else if (t == 1)
            {
                frm2.Text = "The Parts ";
            }
            frm2.Controls.Add(lbl1);
            frm2.Controls.Add(lbl2);
            frm2.Controls.Add(lbl3);
            frm2.Controls.Add(lbl4);
            frm2.Controls.Add(lbl5);
            frm2.Controls.Add(lbl6);
            frm2.Controls.Add(lbl7);
            frm2.Controls.Add(lbl8);
            frm2.Controls.Add(lbl9);
            frm2.Controls.Add(lbl10);
            frm2.Controls.Add(lbl11);
            frm2.Controls.Add(lbl12);
            frm2.Controls.Add(lbl13);
            frm2.Controls.Add(lbl14);
            frm2.Controls.Add(lbl15);
            frm2.Controls.Add(lbl16);
            frm2.Controls.Add(lbl17);
            frm2.Controls.Add(lbl18);
            frm2.Controls.Add(lbl19);
            frm2.Controls.Add(lbl20);
            frm2.Controls.Add(lbl21);
            frm2.Controls.Add(lbl22);
            frm2.Controls.Add(lbl23);
            frm2.Controls.Add(lbl24);
            frm2.Controls.Add(lbl25);
            frm2.Controls.Add(lbl26);
            frm2.Controls.Add(lbl27);
            frm2.Controls.Add(lbl28);
            frm2.Controls.Add(lbl29);
            frm2.Controls.Add(lbl30);
            lbl1.Size = new Size(270, 100);
            lbl2.Size = new Size(270, 100);
            lbl3.Size = new Size(270, 100);
            lbl4.Size = new Size(270, 100);
            lbl5.Size = new Size(270, 100);
            lbl6.Size = new Size(270, 100);
            lbl7.Size = new Size(270, 100);
            lbl8.Size = new Size(270, 100);
            lbl9.Size = new Size(270, 100);
            lbl10.Size = new Size(270, 100);
            lbl11.Size = new Size(270, 100);
            lbl12.Size = new Size(270, 100);
            lbl13.Size = new Size(270, 100);
            lbl14.Size = new Size(270, 100);
            lbl15.Size = new Size(270, 100);
            lbl16.Size = new Size(270, 100);
            lbl17.Size = new Size(270, 100);
            lbl18.Size = new Size(270, 100);
            lbl19.Size = new Size(270, 100);
            lbl20.Size = new Size(270, 100);
            lbl21.Size = new Size(270, 100);
            lbl22.Size = new Size(270, 100);
            lbl23.Size = new Size(270, 100);
            lbl24.Size = new Size(270, 100);
            lbl25.Size = new Size(270, 100);
            lbl26.Size = new Size(270, 100);
            lbl27.Size = new Size(270, 100);
            lbl28.Size = new Size(270, 100);
            lbl29.Size = new Size(270, 100);
            lbl30.Size = new Size(270, 100);
            lbl1.Location = new Point(20, 10);
            lbl2.Location = new Point(310, 10);
            lbl3.Location = new Point(20, 120);
            lbl4.Location = new Point(310, 120);
            lbl5.Location = new Point(20, 230);
            lbl6.Location = new Point(310, 230);
            lbl7.Location = new Point(20, 340);
            lbl8.Location = new Point(310, 340);
            lbl9.Location = new Point(20, 450);
            lbl10.Location = new Point(310, 450);
            lbl11.Location = new Point(20, 560);
            lbl12.Location = new Point(310, 560);
            lbl13.Location = new Point(20, 670);
            lbl14.Location = new Point(310, 670);
            lbl15.Location = new Point(20, 780);
            lbl16.Location = new Point(310, 780);
            lbl17.Location = new Point(20, 890);
            lbl18.Location = new Point(310, 890);
            lbl19.Location = new Point(20, 1000);
            lbl20.Location = new Point(310, 1000);
            lbl21.Location = new Point(20, 1110);
            lbl22.Location = new Point(310, 1110);
            lbl23.Location = new Point(20, 1220);
            lbl24.Location = new Point(310, 1220);
            lbl25.Location = new Point(20, 1330);
            lbl26.Location = new Point(310, 1330);
            lbl27.Location = new Point(20, 1440);
            lbl28.Location = new Point(310, 1440);
            lbl29.Location = new Point(20, 1550);
            lbl30.Location = new Point(310, 1550);
            lbl1.BackColor = Color.Gray;
            lbl2.BackColor = Color.Gray;
            lbl3.BackColor = Color.Gray;
            lbl4.BackColor = Color.Gray;
            lbl5.BackColor = Color.Gray;
            lbl6.BackColor = Color.Gray;
            lbl7.BackColor = Color.Gray;
            lbl8.BackColor = Color.Gray;
            lbl9.BackColor = Color.Gray;
            lbl10.BackColor = Color.Gray;
            lbl11.BackColor = Color.Gray;
            lbl12.BackColor = Color.Gray;
            lbl13.BackColor = Color.Gray;
            lbl14.BackColor = Color.Gray;
            lbl15.BackColor = Color.Gray;
            lbl16.BackColor = Color.Gray;
            lbl17.BackColor = Color.Gray;
            lbl18.BackColor = Color.Gray;
            lbl19.BackColor = Color.Gray;
            lbl20.BackColor = Color.Gray;
            lbl21.BackColor = Color.Gray;
            lbl22.BackColor = Color.Gray;
            lbl23.BackColor = Color.Gray;
            lbl24.BackColor = Color.Gray;
            lbl25.BackColor = Color.Gray;
            lbl26.BackColor = Color.Gray;
            lbl27.BackColor = Color.Gray;
            lbl28.BackColor = Color.Gray;
            lbl29.BackColor = Color.Gray;
            lbl30.BackColor = Color.Gray;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            lbl6.TextAlign = ContentAlignment.MiddleCenter;
            lbl7.TextAlign = ContentAlignment.MiddleCenter;
            lbl8.TextAlign = ContentAlignment.MiddleCenter;
            lbl9.TextAlign = ContentAlignment.MiddleCenter;
            lbl10.TextAlign = ContentAlignment.MiddleCenter;
            lbl11.TextAlign = ContentAlignment.MiddleCenter;
            lbl12.TextAlign = ContentAlignment.MiddleCenter;
            lbl13.TextAlign = ContentAlignment.MiddleCenter;
            lbl14.TextAlign = ContentAlignment.MiddleCenter;
            lbl15.TextAlign = ContentAlignment.MiddleCenter;
            lbl16.TextAlign = ContentAlignment.MiddleCenter;
            lbl17.TextAlign = ContentAlignment.MiddleCenter;
            lbl18.TextAlign = ContentAlignment.MiddleCenter;
            lbl19.TextAlign = ContentAlignment.MiddleCenter;
            lbl20.TextAlign = ContentAlignment.MiddleCenter;
            lbl21.TextAlign = ContentAlignment.MiddleCenter;
            lbl22.TextAlign = ContentAlignment.MiddleCenter;
            lbl23.TextAlign = ContentAlignment.MiddleCenter;
            lbl24.TextAlign = ContentAlignment.MiddleCenter;
            lbl25.TextAlign = ContentAlignment.MiddleCenter;
            lbl26.TextAlign = ContentAlignment.MiddleCenter;
            lbl27.TextAlign = ContentAlignment.MiddleCenter;
            lbl28.TextAlign = ContentAlignment.MiddleCenter;
            lbl29.TextAlign = ContentAlignment.MiddleCenter;
            lbl30.TextAlign = ContentAlignment.MiddleCenter;
            if (t == 0)
            {
                lbl1.Text = "الجزء الأول ";
                lbl2.Text = "الجزء الثاني ";
                lbl3.Text = "الجزء الثالث ";
                lbl4.Text = "الجزء الرابع ";
                lbl5.Text = "الجزء الخامس ";
                lbl6.Text = "الجزء السادس ";
                lbl7.Text = "الجزء السابع ";
                lbl8.Text = "الجزء الثامن ";
                lbl9.Text = "الجزء التاسع ";
                lbl10.Text = "الجزء العاشر ";
                lbl11.Text = "الجزء الحادي عشر ";
                lbl12.Text = "الجزء الثاني عشر ";
                lbl13.Text = "الجزء الثالث عشر ";
                lbl14.Text = "الجزء الرابع عشر ";
                lbl15.Text = "الجزء الخامس عشر ";
                lbl16.Text = "الجزء السادس عشر ";
                lbl17.Text = "الجزء السابع عشر ";
                lbl18.Text = "الجزء الثامن عشر ";
                lbl19.Text = "الجزء التاسع عشر ";
                lbl20.Text = "الجزء العشرون ";
                lbl21.Text = "الجزء الحادي والعشرون ";
                lbl22.Text = "الجزء الثاني والعشرون ";
                lbl23.Text = "الجزء الثالث والعشرون ";
                lbl24.Text = "الجزء الرابع والعشرون ";
                lbl25.Text = "الجزء الخامس والعشرون ";
                lbl26.Text = "الجزء السادس والعشرون ";
                lbl27.Text = "الجزء السابع والعشرون ";
                lbl28.Text = "الجزء الثامن والعشرون ";
                lbl29.Text = "الجزء التاسع والعشرون ";
                lbl30.Text = "الجزء الثلاثون ";

            }
            else if (t == 1)
            {
                lbl1.Text = "Part One ";
                lbl2.Text = "Part Two ";
                lbl3.Text = "Part Three ";
                lbl4.Text = "Part Four ";
                lbl5.Text = "Part Five ";
                lbl6.Text = "Part Six ";
                lbl7.Text = "Part Seven ";
                lbl8.Text = "Part Eight ";
                lbl9.Text = "Part Nine ";
                lbl10.Text = "Part Ten";
                lbl11.Text = "Part Eleven ";
                lbl12.Text = "Part Twelve ";
                lbl13.Text = "Part Thirteen ";
                lbl14.Text = "Part Fourteen ";
                lbl15.Text = "Part Fiveteen ";
                lbl16.Text = "Part SixTeen ";
                lbl17.Text = "Part Seventeen ";
                lbl18.Text = "Part Eighteen ";
                lbl19.Text = "Part Nineteen";
                lbl20.Text = "Part Twenty ";
                lbl21.Text = "Part Twenty One ";
                lbl22.Text = "Part Twenty Two";
                lbl23.Text = "Part Twenty Three ";
                lbl24.Text = "Part Twenty Four ";
                lbl25.Text = "Part Twenty Five ";
                lbl26.Text = "Part Twenty Six ";
                lbl27.Text = "Part Twenty Seven ";
                lbl28.Text = "Part Twenty Eight ";
                lbl29.Text = "Part Twenty Nine ";
                lbl30.Text = "Part Thirty ";
            }
            frm2.Show();
            frm1.Hide();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            frm3.BackColor = Color.DimGray;
            frm3.Size = new Size(549, 600);
            frm3.AutoScroll = true;
            frm3.MaximizeBox = false;
            frm3.MinimizeBox = false;
            frm3.MaximumSize = new Size(549, 600);
            frm3.MinimumSize = new Size(549, 600);
            frm3.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            frm3.StartPosition = FormStartPosition.CenterScreen;
            if (t == 0)
            {
                frm3.Text = "السور ";
            }
            else if (t == 1)
            {
                frm3.Text = "The Verses ";
            }
            frm3.Icon = this.Icon;
            frm3.Controls.Add(l1);
            frm3.Controls.Add(l2);
            frm3.Controls.Add(l3);
            frm3.Controls.Add(l4);
            frm3.Controls.Add(l5);
            frm3.Controls.Add(l6);
            frm3.Controls.Add(l7);
            frm3.Controls.Add(l8);
            frm3.Controls.Add(l9);
            frm3.Controls.Add(l10);
            frm3.Controls.Add(l11);
            frm3.Controls.Add(l12);
            frm3.Controls.Add(l13);
            frm3.Controls.Add(l14);
            frm3.Controls.Add(l15);
            frm3.Controls.Add(l16);
            frm3.Controls.Add(l17);
            frm3.Controls.Add(l18);
            frm3.Controls.Add(l19);
            frm3.Controls.Add(l20);
            frm3.Controls.Add(l21);
            frm3.Controls.Add(l22);
            frm3.Controls.Add(l23);
            frm3.Controls.Add(l24);
            frm3.Controls.Add(l25);
            frm3.Controls.Add(l26);
            frm3.Controls.Add(l27);
            frm3.Controls.Add(l28);
            frm3.Controls.Add(l29);
            frm3.Controls.Add(l30);
            frm3.Controls.Add(l31);
            frm3.Controls.Add(l32);
            frm3.Controls.Add(l33);
            frm3.Controls.Add(l34);
            frm3.Controls.Add(l35);
            frm3.Controls.Add(l36);
            frm3.Controls.Add(l37);
            frm3.Controls.Add(l38);
            frm3.Controls.Add(l39);
            frm3.Controls.Add(l40);
            frm3.Controls.Add(l41);
            frm3.Controls.Add(l42);
            frm3.Controls.Add(l43);
            frm3.Controls.Add(l44);
            frm3.Controls.Add(l45);
            frm3.Controls.Add(l46);
            frm3.Controls.Add(l47);
            frm3.Controls.Add(l48);
            frm3.Controls.Add(l49);
            frm3.Controls.Add(l50);
            frm3.Controls.Add(l51);
            frm3.Controls.Add(l52);
            frm3.Controls.Add(l53);
            frm3.Controls.Add(l54);
            frm3.Controls.Add(l55);
            frm3.Controls.Add(l56);
            frm3.Controls.Add(l57);
            frm3.Controls.Add(l58);
            frm3.Controls.Add(l59);
            frm3.Controls.Add(l60);
            frm3.Controls.Add(l61);
            frm3.Controls.Add(l62);
            frm3.Controls.Add(l63);
            frm3.Controls.Add(l64);
            frm3.Controls.Add(l65);
            frm3.Controls.Add(l66);
            frm3.Controls.Add(l67);
            frm3.Controls.Add(l68);
            frm3.Controls.Add(l69);
            frm3.Controls.Add(l70);
            frm3.Controls.Add(l71);
            frm3.Controls.Add(l72);
            frm3.Controls.Add(l73);
            frm3.Controls.Add(l74);
            frm3.Controls.Add(l75);
            frm3.Controls.Add(l76);
            frm3.Controls.Add(l77);
            frm3.Controls.Add(l78);
            frm3.Controls.Add(l79);
            frm3.Controls.Add(l80);
            frm3.Controls.Add(l81);
            frm3.Controls.Add(l82);
            frm3.Controls.Add(l83);
            frm3.Controls.Add(l84);
            frm3.Controls.Add(l85);
            frm3.Controls.Add(l86);
            frm3.Controls.Add(l87);
            frm3.Controls.Add(l88);
            frm3.Controls.Add(l89);
            frm3.Controls.Add(l90);
            frm3.Controls.Add(l91);
            frm3.Controls.Add(l92);
            frm3.Controls.Add(l93);
            frm3.Controls.Add(l94);
            frm3.Controls.Add(l95);
            frm3.Controls.Add(l96);
            frm3.Controls.Add(l97);
            frm3.Controls.Add(l98);
            frm3.Controls.Add(l99);
            frm3.Controls.Add(l100);
            frm3.Controls.Add(l101);
            frm3.Controls.Add(l102);
            frm3.Controls.Add(l103);
            frm3.Controls.Add(l104);
            frm3.Controls.Add(l105);
            frm3.Controls.Add(l106);
            frm3.Controls.Add(l107);
            frm3.Controls.Add(l108);
            frm3.Controls.Add(l109);
            frm3.Controls.Add(l110);
            frm3.Controls.Add(l111);
            frm3.Controls.Add(l112);
            frm3.Controls.Add(l113);
            frm3.Controls.Add(l114);
            if (t == 0)
            {
                l1.Text = "سورة الفاتحة ";
                l2.Text = "سورة البقرة ";
                l3.Text = "سورة أل عمران ";
                l4.Text = "سورة النساء ";
                l5.Text = "سورة المائدة ";
                l6.Text = "سورة الأنعام ";
                l7.Text = "سورة الأعراف ";
                l8.Text = "سورة الأنفال";
                l9.Text = "سورة التوبة ";
                l10.Text = "سورة يونس";
                l11.Text = "سورة هود";
                l12.Text = "سورة يوسف ";
                l13.Text = "سورة الرعد";
                l14.Text = "سورة إبراهيم";
                l15.Text = "سورة الحجر ";
                l16.Text = "سورة النحل ";
                l17.Text = "سورة الإسراء ";
                l18.Text = "سورة الكهف ";
                l19.Text = "سورة مريم ";
                l20.Text = "سورة طه ";
                l21.Text = "سورة الأنبياء ";
                l22.Text = "سورة الحج ";
                l23.Text = "سورة المؤمنين ";
                l24.Text = "سورة النور ";
                l25.Text = "سورة الفرقان ";
                l26.Text = "سورة الشعراء ";
                l27.Text = "سورة النمل ";
                l28.Text = "سورة القصص ";
                l29.Text = "سورة العنكبوت ";
                l30.Text = "سورة الروم ";
                l31.Text = "سورة لقمان ";
                l32.Text = "سورة السجدة ";
                l33.Text = "سورة الأحزاب ";
                l34.Text = "سورة سبأ ";
                l35.Text = "سورة فاطر ";
                l36.Text = "سورة يس ";
                l37.Text = "سورة الصافات ";
                l38.Text = "سورة ص";
                l39.Text = "سورة الزمر ";
                l40.Text = "سورة غافر ";
                l41.Text = "سورة فصلت ";
                l42.Text = "سورة الشورى ";
                l43.Text = "سورة الزخرف ";
                l44.Text = "سوروة الدخان ";
                l45.Text = "سورة الجاثية ";
                l46.Text = "سورة الأحقاف ";
                l47.Text = "سورة محمد ";
                l48.Text = "سورة الفتح ";
                l49.Text = "سورة الحجرات ";
                l50.Text = "سورة ق ";
                l51.Text = "سورة الذاريات ";
                l52.Text = "سورة الطور ";
                l53.Text = "سورة النجم ";
                l54.Text = "سورة القمر ";
                l55.Text = "سورة الرحمن ";
                l56.Text = "سورة الواقعة ";
                l57.Text = "سورة الحديد ";
                l58.Text = "سورة المجادلة ";
                l59.Text = "سورة الحشر ";
                l60.Text = "سورة الممتحنة ";
                l61.Text = "سورة الصف ";
                l62.Text = "سورة الجمعة ";
                l63.Text = "سورة المنافقون ";
                l64.Text = "سورة التغابن ";
                l65.Text = "سورة الطلاق ";
                l66.Text = "سورة التحريم ";
                l67.Text = "سورة الملك ";
                l68.Text = "سورة القلم ";
                l69.Text = "سورة الحاقة ";
                l70.Text = "سورة المعارج ";
                l71.Text = "سورة نوح ";
                l72.Text = "سورة الجن ";
                l73.Text = "سورة المزمل ";
                l74.Text = "سورة المدثر ";
                l75.Text = "سورة القيامة ";
                l76.Text = "سورة الإنسان ";
                l77.Text = "سورة المرسلات ";
                l78.Text = "سورة النبأ ";
                l79.Text = "سورة النازعات ";
                l80.Text = "سورة عبس ";
                l81.Text = "سورة التكوير ";
                l82.Text = "سورة الإنفطار ";
                l83.Text = "سورة المطففين ";
                l84.Text = "سورة الإنشقاق ";
                l85.Text = "سورة البروج ";
                l86.Text = "سورة الطارق ";
                l87.Text = "سورة الأعلى ";
                l88.Text = "سورة الغاشية ";
                l89.Text = "سورة الفجر ";
                l90.Text = "سورة البلد ";
                l91.Text = "سورة الشمس  ";
                l92.Text = "سورة الليل ";
                l93.Text = "سورة الضحى ";
                l94.Text = "سورة الشرح ";
                l95.Text = "سورة التين ";
                l96.Text = "سورة العلق ";
                l97.Text = "سورة القدر ";
                l98.Text = "سورة البينة ";
                l99.Text = "سورة الزلزلة ";
                l100.Text = "سورة العاديات ";
                l101.Text = "سورة القارعة ";
                l102.Text = "سورة التكاثر ";
                l103.Text = "سورة العصر ";
                l104.Text = "سورة الهمزة ";
                l105.Text = "سورة الفيل ";
                l106.Text = "سورة قريش ";
                l107.Text = "سورة الماعون ";
                l108.Text = "سورة الكوثر ";
                l109.Text = "سورة الكافرون ";
                l110.Text = "سورة النصر ";
                l111.Text = "سورة المسد ";
                l112.Text = "سورة الإخلاص ";
                l113.Text = "سورة الفلق ";
                l114.Text = "سورة الناس ";
            }
            else if (t == 1)
            {
                l1.Text = "1";
                l2.Text = "";
                l3.Text = "";
                l4.Text = "";
                l5.Text = "";
                l6.Text = "";
                l7.Text = "";
                l8.Text = "";
                l9.Text = "";
                l10.Text = "";
                l11.Text = "";
                l12.Text = "";
                l13.Text = "";
                l14.Text = "";
                l15.Text = "";
                l16.Text = "";
                l17.Text = "";
                l18.Text = "";
                l19.Text = "";
                l20.Text = "";
                l21.Text = "";
                l22.Text = "";
                l23.Text = "";
                l24.Text = "";
                l25.Text = "";
                l26.Text = "";
                l27.Text = "";
                l28.Text = "";
                l29.Text = "";
                l30.Text = "";
                l31.Text = "";
                l32.Text = "";
                l33.Text = "";
                l34.Text = "";
                l35.Text = "";
                l36.Text = "";
                l37.Text = "";
                l38.Text = "";
                l39.Text = "";
                l40.Text = "";
                l41.Text = "";
                l42.Text = "";
                l43.Text = "";
                l44.Text = "";
                l45.Text = "";
                l46.Text = "";
                l47.Text = "";
                l48.Text = "";
                l49.Text = "";
                l50.Text = "";
                l51.Text = "";
                l52.Text = "";
                l53.Text = "";
                l54.Text = "";
                l55.Text = "";
                l56.Text = "";
                l57.Text = "";
                l58.Text = "";
                l59.Text = "";
                l60.Text = "";
                l61.Text = "";
                l62.Text = "";
                l63.Text = "";
                l64.Text = "";
                l65.Text = "";
                l66.Text = "";
                l67.Text = "";
                l68.Text = "";
                l69.Text = "";
                l70.Text = "";
                l71.Text = "";
                l72.Text = "";
                l73.Text = "";
                l74.Text = "";
                l75.Text = "";
                l76.Text = "";
                l77.Text = "";
                l78.Text = "";
                l79.Text = "";
                l80.Text = "";
                l81.Text = "";
                l82.Text = "";
                l83.Text = "";
                l84.Text = "";
                l85.Text = "";
                l86.Text = "";
                l87.Text = "";
                l88.Text = "";
                l89.Text = "";
                l90.Text = "";
                l91.Text = "";
                l92.Text = "";
                l93.Text = "";
                l94.Text = "";
                l95.Text = "";
                l96.Text = "";
                l97.Text = "";
                l98.Text = "";
                l99.Text = "";
                l100.Text = "";
                l101.Text = "";
                l102.Text = "";
                l103.Text = "";
                l104.Text = "";
                l105.Text = "";
                l106.Text = "";
                l107.Text = "";
                l108.Text = "";
                l109.Text = "";
                l110.Text = "";
                l111.Text = "";
                l112.Text = "";
                l113.Text = "";
                l114.Text = "";
            }
            l1.BackColor = Color.Gray;
            l2.BackColor = Color.Gray;
            l3.BackColor = Color.Gray;
            l4.BackColor = Color.Gray;
            l5.BackColor = Color.Gray;
            l6.BackColor = Color.Gray;
            l7.BackColor = Color.Gray;
            l8.BackColor = Color.Gray;
            l9.BackColor = Color.Gray;
            l10.BackColor = Color.Gray;
            l11.BackColor = Color.Gray;
            l12.BackColor = Color.Gray;
            l13.BackColor = Color.Gray;
            l14.BackColor = Color.Gray;
            l15.BackColor = Color.Gray;
            l16.BackColor = Color.Gray;
            l17.BackColor = Color.Gray;
            l18.BackColor = Color.Gray;
            l19.BackColor = Color.Gray;
            l20.BackColor = Color.Gray;
            l21.BackColor = Color.Gray;
            l22.BackColor = Color.Gray;
            l23.BackColor = Color.Gray;
            l24.BackColor = Color.Gray;
            l25.BackColor = Color.Gray;
            l26.BackColor = Color.Gray;
            l27.BackColor = Color.Gray;
            l28.BackColor = Color.Gray;
            l29.BackColor = Color.Gray;
            l30.BackColor = Color.Gray;
            l31.BackColor = Color.Gray;
            l32.BackColor = Color.Gray;
            l33.BackColor = Color.Gray;
            l34.BackColor = Color.Gray;
            l35.BackColor = Color.Gray;
            l36.BackColor = Color.Gray;
            l37.BackColor = Color.Gray;
            l38.BackColor = Color.Gray;
            l39.BackColor = Color.Gray;
            l40.BackColor = Color.Gray;
            l41.BackColor = Color.Gray;
            l42.BackColor = Color.Gray;
            l43.BackColor = Color.Gray;
            l44.BackColor = Color.Gray;
            l45.BackColor = Color.Gray;
            l46.BackColor = Color.Gray;
            l47.BackColor = Color.Gray;
            l48.BackColor = Color.Gray;
            l49.BackColor = Color.Gray;
            l50.BackColor = Color.Gray;
            l51.BackColor = Color.Gray;
            l52.BackColor = Color.Gray;
            l53.BackColor = Color.Gray;
            l54.BackColor = Color.Gray;
            l55.BackColor = Color.Gray;
            l56.BackColor = Color.Gray;
            l57.BackColor = Color.Gray;
            l58.BackColor = Color.Gray;
            l59.BackColor = Color.Gray;
            l60.BackColor = Color.Gray;
            l61.BackColor = Color.Gray;
            l62.BackColor = Color.Gray;
            l63.BackColor = Color.Gray;
            l64.BackColor = Color.Gray;
            l65.BackColor = Color.Gray;
            l66.BackColor = Color.Gray;
            l67.BackColor = Color.Gray;
            l68.BackColor = Color.Gray;
            l69.BackColor = Color.Gray;
            l70.BackColor = Color.Gray;
            l71.BackColor = Color.Gray;
            l72.BackColor = Color.Gray;
            l73.BackColor = Color.Gray;
            l74.BackColor = Color.Gray;
            l75.BackColor = Color.Gray;
            l76.BackColor = Color.Gray;
            l77.BackColor = Color.Gray;
            l78.BackColor = Color.Gray;
            l79.BackColor = Color.Gray;
            l80.BackColor = Color.Gray;
            l81.BackColor = Color.Gray;
            l82.BackColor = Color.Gray;
            l83.BackColor = Color.Gray;
            l84.BackColor = Color.Gray;
            l85.BackColor = Color.Gray;
            l86.BackColor = Color.Gray;
            l87.BackColor = Color.Gray;
            l88.BackColor = Color.Gray;
            l89.BackColor = Color.Gray;
            l90.BackColor = Color.Gray;
            l91.BackColor = Color.Gray;
            l90.BackColor = Color.Gray;
            l92.BackColor = Color.Gray;
            l93.BackColor = Color.Gray;
            l94.BackColor = Color.Gray;
            l95.BackColor = Color.Gray;
            l96.BackColor = Color.Gray;
            l97.BackColor = Color.Gray;
            l98.BackColor = Color.Gray;
            l99.BackColor = Color.Gray;
            l100.BackColor = Color.Gray;
            l101.BackColor = Color.Gray;
            l102.BackColor = Color.Gray;
            l103.BackColor = Color.Gray;
            l104.BackColor = Color.Gray;
            l105.BackColor = Color.Gray;
            l106.BackColor = Color.Gray;
            l107.BackColor = Color.Gray;
            l108.BackColor = Color.Gray;
            l109.BackColor = Color.Gray;
            l110.BackColor = Color.Gray;
            l111.BackColor = Color.Gray;
            l112.BackColor = Color.Gray;
            l113.BackColor = Color.Gray;
            l114.BackColor = Color.Gray;

            l1.Size = new Size(120, 70);
            l2.Size = new Size(120, 70);
            l3.Size = new Size(120, 70);
            l4.Size = new Size(120, 70);
            l5.Size = new Size(120, 70);
            l6.Size = new Size(120, 70);
            l7.Size = new Size(120, 70);
            l8.Size = new Size(120, 70);
            l9.Size = new Size(120, 70);
            l10.Size = new Size(120, 70);
            l11.Size = new Size(120, 70);
            l12.Size = new Size(120, 70);
            l13.Size = new Size(120, 70);
            l14.Size = new Size(120, 70);
            l15.Size = new Size(120, 70);
            l16.Size = new Size(120, 70);
            l17.Size = new Size(120, 70);
            l18.Size = new Size(120, 70);
            l19.Size = new Size(120, 70);
            l20.Size = new Size(120, 70);
            l21.Size = new Size(120, 70);
            l22.Size = new Size(120, 70);
            l23.Size = new Size(120, 70);
            l24.Size = new Size(120, 70);
            l25.Size = new Size(120, 70);
            l26.Size = new Size(120, 70);
            l27.Size = new Size(120, 70);
            l28.Size = new Size(120, 70);
            l29.Size = new Size(120, 70);
            l30.Size = new Size(120, 70);
            l31.Size = new Size(120, 70);
            l32.Size = new Size(120, 70);
            l33.Size = new Size(120, 70);
            l34.Size = new Size(120, 70);
            l35.Size = new Size(120, 70);
            l36.Size = new Size(120, 70);
            l37.Size = new Size(120, 70);
            l38.Size = new Size(120, 70);
            l39.Size = new Size(120, 70);
            l40.Size = new Size(120, 70);
            l41.Size = new Size(120, 70);
            l42.Size = new Size(120, 70);
            l43.Size = new Size(120, 70);
            l44.Size = new Size(120, 70);
            l45.Size = new Size(120, 70);
            l46.Size = new Size(120, 70);
            l47.Size = new Size(120, 70);
            l48.Size = new Size(120, 70);
            l49.Size = new Size(120, 70);
            l50.Size = new Size(120, 70);
            l51.Size = new Size(120, 70);
            l52.Size = new Size(120, 70);
            l53.Size = new Size(120, 70);
            l54.Size = new Size(120, 70);
            l55.Size = new Size(120, 70);
            l56.Size = new Size(120, 70);
            l57.Size = new Size(120, 70);
            l58.Size = new Size(120, 70);
            l59.Size = new Size(120, 70);
            l60.Size = new Size(120, 70);
            l61.Size = new Size(120, 70);
            l62.Size = new Size(120, 70);
            l63.Size = new Size(120, 70);
            l64.Size = new Size(120, 70);
            l65.Size = new Size(120, 70);
            l66.Size = new Size(120, 70);
            l67.Size = new Size(120, 70);
            l68.Size = new Size(120, 70);
            l69.Size = new Size(120, 70);
            l70.Size = new Size(120, 70);
            l71.Size = new Size(120, 70);
            l72.Size = new Size(120, 70);
            l73.Size = new Size(120, 70);
            l74.Size = new Size(120, 70);
            l75.Size = new Size(120, 70);
            l76.Size = new Size(120, 70);
            l77.Size = new Size(120, 70);
            l78.Size = new Size(120, 70);
            l79.Size = new Size(120, 70);
            l80.Size = new Size(120, 70);
            l81.Size = new Size(120, 70);
            l82.Size = new Size(120, 70);
            l83.Size = new Size(120, 70);
            l84.Size = new Size(120, 70);
            l85.Size = new Size(120, 70);
            l86.Size = new Size(120, 70);
            l87.Size = new Size(120, 70);
            l88.Size = new Size(120, 70);
            l89.Size = new Size(120, 70);
            l90.Size = new Size(120, 70);
            l91.Size = new Size(120, 70);
            l92.Size = new Size(120, 70);
            l93.Size = new Size(120, 70);
            l94.Size = new Size(120, 70);
            l95.Size = new Size(120, 70);
            l96.Size = new Size(120, 70);
            l97.Size = new Size(120, 70);
            l98.Size = new Size(120, 70);
            l99.Size = new Size(120, 70);
            l100.Size = new Size(120, 70);
            l101.Size = new Size(120, 70);
            l102.Size = new Size(120, 70);
            l103.Size = new Size(120, 70);
            l104.Size = new Size(120, 70);
            l105.Size = new Size(120, 70);
            l106.Size = new Size(120, 70);
            l107.Size = new Size(120, 70);
            l108.Size = new Size(120, 70);
            l109.Size = new Size(120, 70);
            l110.Size = new Size(120, 70);
            l111.Size = new Size(120, 70);
            l112.Size = new Size(120, 70);
            l113.Size = new Size(120, 70);
            l114.Size = new Size(120, 70);
            l1.TextAlign = ContentAlignment.MiddleCenter;
            l2.TextAlign = ContentAlignment.MiddleCenter;
            l3.TextAlign = ContentAlignment.MiddleCenter;
            l4.TextAlign = ContentAlignment.MiddleCenter;
            l5.TextAlign = ContentAlignment.MiddleCenter;
            l6.TextAlign = ContentAlignment.MiddleCenter;
            l7.TextAlign = ContentAlignment.MiddleCenter;
            l8.TextAlign = ContentAlignment.MiddleCenter;
            l9.TextAlign = ContentAlignment.MiddleCenter;
            l10.TextAlign = ContentAlignment.MiddleCenter;
            l11.TextAlign = ContentAlignment.MiddleCenter;
            l12.TextAlign = ContentAlignment.MiddleCenter;
            l13.TextAlign = ContentAlignment.MiddleCenter;
            l14.TextAlign = ContentAlignment.MiddleCenter;
            l15.TextAlign = ContentAlignment.MiddleCenter;
            l16.TextAlign = ContentAlignment.MiddleCenter;
            l17.TextAlign = ContentAlignment.MiddleCenter;
            l18.TextAlign = ContentAlignment.MiddleCenter;
            l19.TextAlign = ContentAlignment.MiddleCenter;
            l20.TextAlign = ContentAlignment.MiddleCenter;
            l21.TextAlign = ContentAlignment.MiddleCenter;
            l22.TextAlign = ContentAlignment.MiddleCenter;
            l23.TextAlign = ContentAlignment.MiddleCenter;
            l24.TextAlign = ContentAlignment.MiddleCenter;
            l25.TextAlign = ContentAlignment.MiddleCenter;
            l26.TextAlign = ContentAlignment.MiddleCenter;
            l27.TextAlign = ContentAlignment.MiddleCenter;
            l28.TextAlign = ContentAlignment.MiddleCenter;
            l29.TextAlign = ContentAlignment.MiddleCenter;
            l30.TextAlign = ContentAlignment.MiddleCenter;
            l31.TextAlign = ContentAlignment.MiddleCenter;
            l32.TextAlign = ContentAlignment.MiddleCenter;
            l33.TextAlign = ContentAlignment.MiddleCenter;
            l34.TextAlign = ContentAlignment.MiddleCenter;
            l35.TextAlign = ContentAlignment.MiddleCenter;
            l36.TextAlign = ContentAlignment.MiddleCenter;
            l37.TextAlign = ContentAlignment.MiddleCenter;
            l38.TextAlign = ContentAlignment.MiddleCenter;
            l39.TextAlign = ContentAlignment.MiddleCenter;
            l40.TextAlign = ContentAlignment.MiddleCenter;
            l41.TextAlign = ContentAlignment.MiddleCenter;
            l42.TextAlign = ContentAlignment.MiddleCenter;
            l43.TextAlign = ContentAlignment.MiddleCenter;
            l44.TextAlign = ContentAlignment.MiddleCenter;
            l45.TextAlign = ContentAlignment.MiddleCenter;
            l46.TextAlign = ContentAlignment.MiddleCenter;
            l47.TextAlign = ContentAlignment.MiddleCenter;
            l48.TextAlign = ContentAlignment.MiddleCenter;
            l49.TextAlign = ContentAlignment.MiddleCenter;
            l50.TextAlign = ContentAlignment.MiddleCenter;
            l51.TextAlign = ContentAlignment.MiddleCenter;
            l52.TextAlign = ContentAlignment.MiddleCenter;
            l53.TextAlign = ContentAlignment.MiddleCenter;
            l54.TextAlign = ContentAlignment.MiddleCenter;
            l55.TextAlign = ContentAlignment.MiddleCenter;
            l56.TextAlign = ContentAlignment.MiddleCenter;
            l57.TextAlign = ContentAlignment.MiddleCenter;
            l58.TextAlign = ContentAlignment.MiddleCenter;
            l59.TextAlign = ContentAlignment.MiddleCenter;
            l60.TextAlign = ContentAlignment.MiddleCenter;
            l61.TextAlign = ContentAlignment.MiddleCenter;
            l62.TextAlign = ContentAlignment.MiddleCenter;
            l63.TextAlign = ContentAlignment.MiddleCenter;
            l64.TextAlign = ContentAlignment.MiddleCenter;
            l65.TextAlign = ContentAlignment.MiddleCenter;
            l66.TextAlign = ContentAlignment.MiddleCenter;
            l67.TextAlign = ContentAlignment.MiddleCenter;
            l68.TextAlign = ContentAlignment.MiddleCenter;
            l69.TextAlign = ContentAlignment.MiddleCenter;
            l70.TextAlign = ContentAlignment.MiddleCenter;
            l71.TextAlign = ContentAlignment.MiddleCenter;
            l72.TextAlign = ContentAlignment.MiddleCenter;
            l73.TextAlign = ContentAlignment.MiddleCenter;
            l74.TextAlign = ContentAlignment.MiddleCenter;
            l75.TextAlign = ContentAlignment.MiddleCenter;
            l76.TextAlign = ContentAlignment.MiddleCenter;
            l77.TextAlign = ContentAlignment.MiddleCenter;
            l78.TextAlign = ContentAlignment.MiddleCenter;
            l79.TextAlign = ContentAlignment.MiddleCenter;
            l80.TextAlign = ContentAlignment.MiddleCenter;
            l81.TextAlign = ContentAlignment.MiddleCenter;
            l82.TextAlign = ContentAlignment.MiddleCenter;
            l83.TextAlign = ContentAlignment.MiddleCenter;
            l84.TextAlign = ContentAlignment.MiddleCenter;
            l85.TextAlign = ContentAlignment.MiddleCenter;
            l86.TextAlign = ContentAlignment.MiddleCenter;
            l87.TextAlign = ContentAlignment.MiddleCenter;
            l88.TextAlign = ContentAlignment.MiddleCenter;
            l89.TextAlign = ContentAlignment.MiddleCenter;
            l90.TextAlign = ContentAlignment.MiddleCenter;
            l91.TextAlign = ContentAlignment.MiddleCenter;
            l92.TextAlign = ContentAlignment.MiddleCenter;
            l93.TextAlign = ContentAlignment.MiddleCenter;
            l94.TextAlign = ContentAlignment.MiddleCenter;
            l95.TextAlign = ContentAlignment.MiddleCenter;
            l96.TextAlign = ContentAlignment.MiddleCenter;
            l97.TextAlign = ContentAlignment.MiddleCenter;
            l98.TextAlign = ContentAlignment.MiddleCenter;
            l99.TextAlign = ContentAlignment.MiddleCenter;
            l100.TextAlign = ContentAlignment.MiddleCenter;
            l101.TextAlign = ContentAlignment.MiddleCenter;
            l102.TextAlign = ContentAlignment.MiddleCenter;
            l103.TextAlign = ContentAlignment.MiddleCenter;
            l104.TextAlign = ContentAlignment.MiddleCenter;
            l105.TextAlign = ContentAlignment.MiddleCenter;
            l106.TextAlign = ContentAlignment.MiddleCenter;
            l107.TextAlign = ContentAlignment.MiddleCenter;
            l108.TextAlign = ContentAlignment.MiddleCenter;
            l109.TextAlign = ContentAlignment.MiddleCenter;
            l110.TextAlign = ContentAlignment.MiddleCenter;
            l111.TextAlign = ContentAlignment.MiddleCenter;
            l112.TextAlign = ContentAlignment.MiddleCenter;
            l113.TextAlign = ContentAlignment.MiddleCenter;
            l114.TextAlign = ContentAlignment.MiddleCenter;
            l1.Location = new Point(7, 7);
            l2.Location = new Point(134, 7);
            l3.Location = new Point(261, 7);
            l4.Location = new Point(388, 7);
            l5.Location = new Point(7, 84);
            l6.Location = new Point(134, 84);
            l7.Location = new Point(261, 84);
            l8.Location = new Point(388, 84);
            l9.Location = new Point(7, 161);
            l10.Location = new Point(134, 161);
            l11.Location = new Point(261, 161);
            l12.Location = new Point(388, 161);
            l13.Location = new Point(7, 238);
            l14.Location = new Point(134, 238);
            l15.Location = new Point(261, 238);
            l16.Location = new Point(388, 238);
            l17.Location = new Point(7, 315);
            l18.Location = new Point(134, 315);
            l19.Location = new Point(261, 315);
            l20.Location = new Point(388, 315);
            l21.Location = new Point(7, 392);
            l22.Location = new Point(134, 392);
            l23.Location = new Point(261, 392);
            l24.Location = new Point(388, 392);
            l25.Location = new Point(7, 469);
            l26.Location = new Point(134, 469);
            l27.Location = new Point(261, 469);
            l28.Location = new Point(388, 469);
            l29.Location = new Point(7, 546);
            l30.Location = new Point(134, 546);
            l31.Location = new Point(261, 546);
            l32.Location = new Point(388, 546);
            l33.Location = new Point(7, 623);
            l34.Location = new Point(134, 623);
            l35.Location = new Point(261, 623);
            l36.Location = new Point(388, 623);
            l37.Location = new Point(7, 700);
            l38.Location = new Point(134, 700);
            l39.Location = new Point(261, 700);
            l40.Location = new Point(388, 700);
            l41.Location = new Point(7, 777);
            l42.Location = new Point(134, 777);
            l43.Location = new Point(261, 777);
            l44.Location = new Point(388, 777);
            l45.Location = new Point(7, 854);
            l46.Location = new Point(134, 854);
            l47.Location = new Point(261, 854);
            l48.Location = new Point(388, 854);
            l49.Location = new Point(7, 931);
            l50.Location = new Point(134, 931);
            l51.Location = new Point(261, 931);
            l52.Location = new Point(388, 931);
            l53.Location = new Point(7, 1008);
            l54.Location = new Point(134, 1005);
            l55.Location = new Point(261, 1008);
            l56.Location = new Point(388, 1008);
            l57.Location = new Point(7, 1085);
            l58.Location = new Point(134, 1085);
            l59.Location = new Point(261, 1085);
            l60.Location = new Point(388, 1085);
            l61.Location = new Point(7, 1162);
            l62.Location = new Point(134, 1162);
            l63.Location = new Point(261, 1162);
            l64.Location = new Point(388, 1162);
            l65.Location = new Point(7, 1239);
            l66.Location = new Point(134, 1239);
            l67.Location = new Point(261, 1239);
            l68.Location = new Point(388, 1239);
            l69.Location = new Point(7, 1316);
            l70.Location = new Point(134, 1316);
            l71.Location = new Point(261, 1316);
            l72.Location = new Point(388, 1316);
            l73.Location = new Point(7, 1393);
            l74.Location = new Point(134, 1393);
            l75.Location = new Point(261, 1393);
            l76.Location = new Point(388, 1393);
            l77.Location = new Point(7, 1470);
            l78.Location = new Point(134, 1470);
            l79.Location = new Point(261, 1470);
            l80.Location = new Point(388, 1470);
            l81.Location = new Point(7, 1547);
            l82.Location = new Point(134, 1547);
            l83.Location = new Point(261, 1547);
            l84.Location = new Point(388, 1547);
            l85.Location = new Point(7, 1624);
            l86.Location = new Point(134, 1624);
            l87.Location = new Point(261, 1624);
            l88.Location = new Point(388, 1624);
            l89.Location = new Point(7, 1701);
            l90.Location = new Point(134, 1701);
            l91.Location = new Point(261, 1701);
            l92.Location = new Point(388, 1701);
            l93.Location = new Point(7, 1778);
            l94.Location = new Point(134, 1778);
            l95.Location = new Point(261, 1778);
            l96.Location = new Point(388, 1778);
            l97.Location = new Point(7, 1855);
            l98.Location = new Point(134, 1855);
            l99.Location = new Point(261, 1855);
            l100.Location = new Point(388, 1855);
            l101.Location = new Point(7, 1932);
            l102.Location = new Point(134, 1932);
            l103.Location = new Point(261, 1932);
            l104.Location = new Point(388, 1932);
            l105.Location = new Point(7, 2009);
            l106.Location = new Point(134, 2009);
            l107.Location = new Point(261, 2009);
            l108.Location = new Point(388, 2009);
            l109.Location = new Point(7, 2086);
            l110.Location = new Point(134, 2086);
            l111.Location = new Point(261, 2086);
            l112.Location = new Point(388, 2086);
            l113.Location = new Point(134, 2163);
            l114.Location = new Point(261, 2163);
            frm3.Show();
            frm2.Hide(); ;

        }
        private void btn5_Click(object sender, EventArgs e)
        {
            frm1.Close();
            frm2.Close();
            frm3.Close();
            frm4.Close();
            frm5.Close();
            frm6.Close();
            this.Close();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            frm4.ShowDialog();
        }
        //frm2 
        //The Partes
        private void lbl1_Click(object sender, EventArgs e)
        {
            i = 1;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm1.Close();
            frm2.Hide();


        }
        private void lbl2_Click(object sender, EventArgs e)
        {

            i = 21;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl3_Click(object sender, EventArgs e)
        {

            i = 41;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl4_Click(object sender, EventArgs e)
        {

            i = 61;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl5_Click(object sender, EventArgs e)
        {

            i = 81;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl6_Click(object sender, EventArgs e)
        {

            i = 101;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl7_Click(object sender, EventArgs e)
        {

            i = 121;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl8_Click(object sender, EventArgs e)
        {

            i = 141;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();
        }
        private void lbl9_Click(object sender, EventArgs e)
        {
            i = 161;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl10_Click(object sender, EventArgs e)
        {
            i = 181;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl11_Click(object sender, EventArgs e)
        {
            i = 201;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl12_Click(object sender, EventArgs e)
        {
            i = 221;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl13_Click(object sender, EventArgs e)
        {
            i = 241;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl14_Click(object sender, EventArgs e)
        {
            i = 261;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl15_Click(object sender, EventArgs e)
        {
            i = 281;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl16_Click(object sender, EventArgs e)
        {
            i = 301;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl17_Click(object sender, EventArgs e)
        {
            i = 321;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl18_Click(object sender, EventArgs e)
        {
            i = 341;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl19_Click(object sender, EventArgs e)
        {
            i = 361;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl20_Click(object sender, EventArgs e)
        {
            i = 381;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl21_Click(object sender, EventArgs e)
        {
            i = 401;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl22_Click(object sender, EventArgs e)
        {
            i = 421;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl23_Click(object sender, EventArgs e)
        {
            i = 441;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl24_Click(object sender, EventArgs e)
        {
            i = 461;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl25_Click(object sender, EventArgs e)
        {
            i = 481;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl26_Click(object sender, EventArgs e)
        {
            i = 501;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl27_Click(object sender, EventArgs e)
        {
            i = 521;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl28_Click(object sender, EventArgs e)
        {
            i = 541;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl29_Click(object sender, EventArgs e)
        {
            i = 561;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        private void lbl30_Click(object sender, EventArgs e)
        {
            i = 581;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }
            }
            Application.OpenForms[0].Show();
            frm2.Close();
            frm1.Hide();

        }
        //frm3
        //Al-Sware Form
        private void l1_Click(object sender, EventArgs e)
        {
            i = 1;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l2_Click(object sender, EventArgs e)
        {

            i = 1;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l3_Click(object sender, EventArgs e)
        {

            i = 49;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l4_Click(object sender, EventArgs e)
        {

            i = 77;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l5_Click(object sender, EventArgs e)
        {
            i = 105;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l6_Click(object sender, EventArgs e)
        {
            i = 127;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l7_Click(object sender, EventArgs e)
        {
            i = 151;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l8_Click(object sender, EventArgs e)
        {
            i = 177;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l9_Click(object sender, EventArgs e)
        {
            i = 187;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l10_Click(object sender, EventArgs e)
        {
            i = 207;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l11_Click(object sender, EventArgs e)
        {
            i = 221;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l12_Click(object sender, EventArgs e)
        {
            i = 235;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l13_Click(object sender, EventArgs e)
        {
            i = 249;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l14_Click(object sender, EventArgs e)
        {
            i = 255;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l15_Click(object sender, EventArgs e)
        {
            i = 261;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l16_Click(object sender, EventArgs e)
        {
            i = 267;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l17_Click(object sender, EventArgs e)
        {
            i = 281;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l18_Click(object sender, EventArgs e)
        {
            i = 293;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l19_Click(object sender, EventArgs e)
        {
            i = 305;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l20_Click(object sender, EventArgs e)
        {
            i = 311;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l21_Click(object sender, EventArgs e)
        {
            i = 321;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l22_Click(object sender, EventArgs e)
        {
            i = 75;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l23_Click(object sender, EventArgs e)
        {
            i = 331;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l24_Click(object sender, EventArgs e)
        {
            i = 349;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l25_Click(object sender, EventArgs e)
        {
            i = 359;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l26_Click(object sender, EventArgs e)
        {
            i = 367;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l27_Click(object sender, EventArgs e)
        {
            i = 377;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l28_Click(object sender, EventArgs e)
        {
            i = 385;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l29_Click(object sender, EventArgs e)
        {
            i = 395;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l30_Click(object sender, EventArgs e)
        {
            i = 403;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l31_Click(object sender, EventArgs e)
        {
            i = 411;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l32_Click(object sender, EventArgs e)
        {
            i = 415;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l33_Click(object sender, EventArgs e)
        {
            i = 417;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l34_Click(object sender, EventArgs e)
        {
            i = 427;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l35_Click(object sender, EventArgs e)
        {
            i = 433;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l36_Click(object sender, EventArgs e)
        {
            i = 439;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l37_Click(object sender, EventArgs e)
        {
            i = 445;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l38_Click(object sender, EventArgs e)
        {
            i = 453;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l39_Click(object sender, EventArgs e)
        {
            i = 457;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l40_Click(object sender, EventArgs e)
        {
            i = 467;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l41_Click(object sender, EventArgs e)
        {
            i = 477;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l42_Click(object sender, EventArgs e)
        {
            i = 483;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l43_Click(object sender, EventArgs e)
        {
            i = 489;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l44_Click(object sender, EventArgs e)
        {
            i = 495;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l45_Click(object sender, EventArgs e)
        {
            i = 499;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l46_Click(object sender, EventArgs e)
        {
            i = 501;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l47_Click(object sender, EventArgs e)
        {
            i = 507;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l48_Click(object sender, EventArgs e)
        {
            i = 511;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l49_Click(object sender, EventArgs e)
        {
            i = 515;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l50_Click(object sender, EventArgs e)
        {
            i = 517;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l51_Click(object sender, EventArgs e)
        {
            i = 519;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l52_Click(object sender, EventArgs e)
        {
            i = 523;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l53_Click(object sender, EventArgs e)
        {
            i = 525;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l54_Click(object sender, EventArgs e)
        {
            i = 527;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l55_Click(object sender, EventArgs e)
        {
            i = 531;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l56_Click(object sender, EventArgs e)
        {
            i = 533;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l57_Click(object sender, EventArgs e)
        {
            i = 537;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l58_Click(object sender, EventArgs e)
        {
            i = 541;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l59_Click(object sender, EventArgs e)
        {
            i = 545;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l60_Click(object sender, EventArgs e)
        {
            i = 549;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l61_Click(object sender, EventArgs e)
        {
            i = 551;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l62_Click(object sender, EventArgs e)
        {
            i = 553;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l63_Click(object sender, EventArgs e)
        {
            i = 553;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l64_Click(object sender, EventArgs e)
        {
            i = 555;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l65_Click(object sender, EventArgs e)
        {
            i = 557;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l66_Click(object sender, EventArgs e)
        {
            i = 559;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l67_Click(object sender, EventArgs e)
        {
            i = 561;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l68_Click(object sender, EventArgs e)
        {
            i = 563;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l69_Click(object sender, EventArgs e)
        {
            i = 565;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l70_Click(object sender, EventArgs e)
        {
            i = 567;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l71_Click(object sender, EventArgs e)
        {
            i = 569;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l72_Click(object sender, EventArgs e)
        {
            i = 571;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l73_Click(object sender, EventArgs e)
        {
            i = 573;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l74_Click(object sender, EventArgs e)
        {
            i = 575;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l75_Click(object sender, EventArgs e)
        {
            i = 577;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l76_Click(object sender, EventArgs e)
        {
            i = 577;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l77_Click(object sender, EventArgs e)
        {
            i = 579;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Hide();
        }
        private void l78_Click(object sender, EventArgs e)
        {
            i = 581;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l79_Click(object sender, EventArgs e)
        {
            i = 583;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l80_Click(object sender, EventArgs e)
        {
            i = 585;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l81_Click(object sender, EventArgs e)
        {
            i = 585;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l82_Click(object sender, EventArgs e)
        {
            i = 587;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l83_Click(object sender, EventArgs e)
        {
            i = 587;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l84_Click(object sender, EventArgs e)
        {
            i = 589;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l85_Click(object sender, EventArgs e)
        {
            i = 589;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l86_Click(object sender, EventArgs e)
        {
            i = 591;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l87_Click(object sender, EventArgs e)
        {
            i = 591;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l88_Click(object sender, EventArgs e)
        {
            i = 591;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l89_Click(object sender, EventArgs e)
        {
            i = 593;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l90_Click(object sender, EventArgs e)
        {
            i = 593;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l91_Click(object sender, EventArgs e)
        {
            i = 595;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l92_Click(object sender, EventArgs e)
        {
            i = 595;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l93_Click(object sender, EventArgs e)
        {
            i = 595;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l94_Click(object sender, EventArgs e)
        {
            i = 597;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l95_Click(object sender, EventArgs e)
        {
            i = 597;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l96_Click(object sender, EventArgs e)
        {
            i = 597;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l97_Click(object sender, EventArgs e)
        {
            i = 597;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l98_Click(object sender, EventArgs e)
        {
            i = 597;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l99_Click(object sender, EventArgs e)
        {
            i = 599;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l100_Click(object sender, EventArgs e)
        {
            i = 599;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l101_Click(object sender, EventArgs e)
        {
            i = 599;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l102_Click(object sender, EventArgs e)
        {
            i = 599;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l103_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l104_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l105_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l106_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l107_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l108_Click(object sender, EventArgs e)
        {
            i = 601;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l109_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l110_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l111_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l112_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l113_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        private void l114_Click(object sender, EventArgs e)
        {
            i = 603;
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox2.Image = Image.FromFile("image//" + i + ".png");
                    i++;
                }

            }
            if (i <= 604)
            {
                if (File.Exists("image//" + i + ".png"))
                {
                    pictureBox1.Image = Image.FromFile("image//" + i + ".png");
                }
            }
            Application.OpenForms[0].Show();
            frm3.Close();
            frm1.Close();
        }
        //frm5
        //Saves Form 
        private void frm4_load(object Sender, EventArgs e)
        {
            if (t == 0)
            {
                frm4.Text = "المحفوظات ";
            }
            else if (t == 1)
            {
                frm4.Text = "Saves";
            }
            frm4.Size = new Size(375, 500);
            frm4.MaximumSize = new Size(375, 500);
            frm4.MinimumSize = new Size(375, 500);
            frm4.MaximizeBox = false;
            frm4.MinimizeBox = false;
            frm4.BackColor = Color.DimGray;
            frm4.Font = new Font("Modern No. 20", 22, FontStyle.Bold, GraphicsUnit.Pixel);
            frm4.AutoScroll = true;
            frm4.StartPosition = FormStartPosition.CenterScreen;
            frm4.Controls.Add(lb1);
            frm4.Controls.Add(lb2);
            frm4.Controls.Add(lb3);
            frm4.Controls.Add(lb4);
            frm4.Controls.Add(lb5);
            frm4.Controls.Add(lb6);
            frm4.Controls.Add(lb7);
            frm4.Controls.Add(lb8);
            frm4.Controls.Add(lb9);
            frm4.Controls.Add(lb10);
            lb1.Size = new Size(300, 100);
            lb2.Size = new Size(300, 100);
            lb3.Size = new Size(300, 100);
            lb4.Size = new Size(300, 100);
            lb5.Size = new Size(300, 100);
            lb6.Size = new Size(300, 100);
            lb7.Size = new Size(300, 100);
            lb8.Size = new Size(300, 100);
            lb9.Size = new Size(300, 100);
            lb10.Size = new Size(300, 100);
            lb1.BackColor = Color.Gray;
            lb2.BackColor = Color.Gray;
            lb3.BackColor = Color.Gray;
            lb4.BackColor = Color.Gray;
            lb5.BackColor = Color.Gray;
            lb6.BackColor = Color.Gray;
            lb7.BackColor = Color.Gray;
            lb8.BackColor = Color.Gray;
            lb9.BackColor = Color.Gray;
            lb10.BackColor = Color.Gray;
            lb1.Location = new Point(25, 7);
            lb2.Location = new Point(25, 114);
            lb3.Location = new Point(25, 221);
            lb4.Location = new Point(25, 328);
            lb5.Location = new Point(25, 435);
            lb6.Location = new Point(25, 542);
            lb7.Location = new Point(25, 649);
            lb8.Location = new Point(25, 756);
            lb9.Location = new Point(25, 863);
            lb10.Location = new Point(25, 970);
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            lb4.TextAlign = ContentAlignment.MiddleCenter;
            lb5.TextAlign = ContentAlignment.MiddleCenter;
            lb6.TextAlign = ContentAlignment.MiddleCenter;
            lb7.TextAlign = ContentAlignment.MiddleCenter;
            lb8.TextAlign = ContentAlignment.MiddleCenter;
            lb9.TextAlign = ContentAlignment.MiddleCenter;
            lb10.TextAlign = ContentAlignment.MiddleCenter;
            frm4.Show();
            StreamReader sr = new StreamReader("Data.txt");
            string line = sr.ReadToEnd();
            sr.Close();
            string[] s = line.Split(',');
            lb1.Text =  s[0].ToString() + "  " + s[1].ToString();
            lb2.Text = s[2].ToString() + "  " + s[3].ToString();
            lb3.Text = s[4].ToString() + "  " + s[5].ToString();
            lb4.Text = s[6].ToString() + "  " + s[7].ToString();
            lb5.Text = s[8].ToString() + "  " + s[9].ToString();
            lb6.Text = s[10].ToString() + "  " + s[11].ToString();
            lb7.Text = s[12].ToString() + "  " + s[13].ToString();
            lb8.Text = s[14].ToString() + "  " + s[15].ToString();
            lb9.Text = s[16].ToString() + "  " + s[17].ToString();
            lb10.Text = s[18].ToString() + "  " + s[19].ToString();
        
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            frm6.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            if (t == 0)
            {
                frm6.Text = "الحفظ ";
            }
            else if (t == 1)
            {
                frm6.Text = "The Saving ";
            }
            frm6.StartPosition = FormStartPosition.CenterScreen;
            frm6.BackColor = Color.DimGray;
            frm6.Size = new Size(400,300);
            frm6.MaximumSize = new Size(400,300);
            frm6.MinimumSize = new Size(400,300);
            frm6.MaximizeBox = false;
            frm6.MinimizeBox = false;
            frm6.Icon = this.Icon;
            frm6.Font = this.Font;
            frm6.Controls.Add(label1);
            frm6.Controls.Add(label2);
            frm6.Controls.Add(textbox1);
            frm6.Controls.Add(button);
            label1.Location = new Point(80, 75);
            label1.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            if (t == 0)
            {
                label1.Text = "الصفحة " + i + ":";

            }
            else if (t == 1)
            {
                label1.Text = "The Page " + i + ":";
            }
            label2.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(210, 50);
            if (t == 0)
            {
                label2.Text = "الاسم";
            }
            else if (t == 1)
            {
                label2.Text = "The Name:";
            }
            textbox1.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            textbox1.Location = new Point(210, 75);

            button.Font = new Font("Modern No. 20", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            button.BackColor = Color.Gray;
            button.Size = new Size(126, 60);
            button.Location = new Point(127,125);
            button.FlatStyle = FlatStyle.Popup;
            if (t == 0)
            {
                button.Text = "حفظ ";
            }
            else if (t == 1)
            {
                button.Text = "Save ";
            }
           
            frm6.ShowDialog();
            frm5.Close();
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            frm4.ShowDialog();
        }
        private void button_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Data.txt");
            string swd = i.ToString() + ","
                        + textbox1.Text + ",";
            sw.WriteLine(swd);
            sw.Close();
        
        }
    }

}
