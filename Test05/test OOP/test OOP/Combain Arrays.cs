using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace test_OOP
{
    class Combain_Arrays
    {
        public int[] Sum(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Count()];
            for (int i = 0; i < arr3.Count(); i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            return arr3;
        }
        public void printSum(int[] arr1, int[] arr2)
        {
            int[] arr3 = Sum(arr1, arr2);
            foreach (int i in arr3)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("");
        }
        public static string personeinfo()
        {
            Form frm1 = new Form();
            Label lbl1 = new Label();
            Label lbl2 = new Label();
            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();
            Button btn1 = new Button();
            Button btn2 = new Button();
            PictureBox pic1 = new PictureBox();
            string name="", pass="";

            frm1.Text = "Please Insert Your Information:";
            frm1.Font = new Font("Tahoma", 12);
            frm1.Size = new Size(350, 400);
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm1.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - frm1.Height) / 2);
            frm1.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm1.MinimizeBox = false;
            frm1.MaximizeBox = false;

            lbl1.Text = "Name:";
            lbl1.Location = new Point(15, 220);
            lbl1.AutoSize = true;

            lbl2.Text = "Password:";
            lbl2.Location = new Point(15, 270);
            lbl2.AutoSize = true;

            txt1.Location = new Point(100, 220);
            txt1.BorderStyle = BorderStyle.FixedSingle;
            txt1.TextAlign = HorizontalAlignment.Center;
            txt1.Size = new Size(210, 30);
            txt1.KeyDown += delegate (object mysender, KeyEventArgs mye) {
                if (mye.KeyCode == Keys.Enter)
                {
                    txt2.Focus();
                }
            };

            txt2.Location = new Point(100, 270);
            txt2.BorderStyle = BorderStyle.FixedSingle;
            txt2.TextAlign = HorizontalAlignment.Center;
            txt2.Size = new Size(210, 30);
            txt2.PasswordChar = '*';
            txt2.KeyDown += delegate (object mysender, KeyEventArgs mye)
            {
                if (mye.KeyCode == Keys.Enter)
                {
                    btn1.PerformClick();
                }
            };
            btn1.Size = new Size(60, 30);
            btn1.Location = new Point(65, 310);
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.BackColor = Color.Cyan;
            btn1.Text = "OK";
            btn1.SendToBack();
            btn1.Click += delegate
                {
                    if (txt1.Text.Trim() == "")
                    {
                        txt1.Focus();
                    }
                    else if (txt2.Text.Trim() == "")
                    {
                        txt2.Focus();
                    }
                    else
                    {
                        name = txt1.Text;
                        pass = txt2.Text;
                        frm1.Close();
                    }

                };

            btn2.Size = new Size(60, 30);
            btn2.Location = new Point(180, 310);
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.BackColor = Color.LightGray;
            btn2.Text = "Cancel";
            btn2.Click += delegate {
                frm1.Close();
            };

            pic1.Size = new Size(150, 150);
            pic1.Location = new Point((frm1.Width-pic1.Width-20)/2, 50);
            pic1.Image = Image.FromFile("DSC_2328.JPG");
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.BorderStyle = BorderStyle.FixedSingle;

            frm1.Controls.Add(lbl1);
            frm1.Controls.Add(lbl2);
            frm1.Controls.Add(txt1);
            frm1.Controls.Add(txt2);
            frm1.Controls.Add(btn1);
            frm1.Controls.Add(btn2);
            frm1.Controls.Add(pic1);
            frm1.ShowDialog();
            string AllData = name + ";"+ pass;
            return AllData;
        }
    } 
}
