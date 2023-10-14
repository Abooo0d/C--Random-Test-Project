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
namespace My_Programe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pleas Insert An ID And Try Again ", "Id Messing");
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please Insert A Name And Try Again ", "Name Messing");
                textBox2.Focus();
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please Insert An Addreas And Try Again ", "Addres Messing");
                textBox3.Focus();
            }
            else if (pictureBox1.Image == null)
            {
                DialogResult dr = MessageBox.Show("Plese Choose an Image And Try Again", "The  Image Is Messing", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    of.Filter = "Images|*.jpg;*.png;*.gif";
                    DialogResult Dr = new DialogResult();
                    dr = of.ShowDialog();
                    if (Dr == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(of.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Please Choose An Image","Image Messing");
                    }
                }
                else if (dr == DialogResult.Cancel)
                {

                }
            }
            else
            {
                StreamReader sr = new StreamReader("Data.txt");
                string srr = sr.ReadToEnd();
                sr.Close();
                if (srr.Contains(textBox1.Text + ","))
                {
                    MessageBox.Show("This Person Is Already Added", "Error");
                }
                else
                {
                    StreamWriter sw = new StreamWriter("Data.txt", true);
                    string s = textBox1.Text + "," +
                               textBox2.Text + "," +
                               textBox3.Text + ",";
                    sw.WriteLine(s);
                    sw.Close();
                    if (pictureBox1.Image != null)
                    {
                        if (Directory.Exists("img"))
                            pictureBox1.Image.Save("img/" + textBox1.Text + ".jpg");
                        else
                        {
                            Directory.CreateDirectory("img");
                            pictureBox1.Image.Save("img/" + textBox1.Text + ".jpg");
                        }
                    }
                    else
                    {

                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    pictureBox1.Image = null;
                    textBox1.Focus();
                   

                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                textBox3.Clear();
                if (textBox1.Text.Trim() != "")
                {
                    StreamReader sr = new StreamReader("Data.txt");
                    string line;
                    bool found = false;
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] arrdata = line.Split(',');
                            if (arrdata[0] == textBox1.Text)
                            {
                                textBox1.Text = arrdata[0];
                                textBox2.Text = arrdata[1];
                                textBox3.Text = arrdata[2];
                                string img = "img/" + arrdata[0].Trim() + ".jpg";
                                if (File.Exists(img))
                                {
                                    pictureBox1.Image = Image.FromFile(img);
                                }
                                found = true;
                                break;
                            }
                        }
                    } while (line != null);
                    sr.Close();
                    if (!found)
                    {
                        MessageBox.Show("This Person Is Not Found Chenge The ID And Try Again!", "Error");
                        textBox1.Focus();
                        textBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Insert An ID To Find The Person", "Error");
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm1 = new Form();
                frm1.Font = this.Font;
                frm1.Text = "All Data";
                frm1.StartPosition = FormStartPosition.CenterScreen;
                frm1.Icon = this.Icon;
                frm1.MaximizeBox = false;
                frm1.MinimizeBox = false;
                frm1.Size = this.Size;
                frm1.Width = 480;
                frm1.AutoScroll = true;
                int mytop = 7;
                StreamReader sr = new StreamReader("Data.txt");
                string line = sr.ReadToEnd(); ;
                string[] s = line.Split(',');
                sr.Close();
                int counter = s.Count() - 1;
                int i = 0;
                try
                {
                    do
                    {
                        if (i < counter)
                        {
                            TextBox txt1 = new TextBox();
                            txt1.Width = 300;
                            txt1.Top = mytop;
                            txt1.Left = 7;
                            txt1.Text = s[i];

                            TextBox txt2 = new TextBox();
                            txt2.Width = 300;
                            txt2.Top = mytop + 42;
                            txt2.Left = 7;
                            txt2.Text = s[i + 1];

                            TextBox txt3 = new TextBox();
                            txt3.Width = 300;
                            txt3.Top = mytop + 84;
                            txt3.Left = 7;
                            txt3.Text = s[i + 2];

                            PictureBox pic = new PictureBox();
                            pic.Size = new Size(120, 120);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Top = mytop;
                            pic.Left = 314;
                            pic.BorderStyle = BorderStyle.Fixed3D;
                            string img = "img/" + s[i].Trim() + ".jpg";
                            if (File.Exists(img))
                            {
                                pic.Image = Image.FromFile(img);
                            }
                            frm1.Controls.Add(txt1);
                            frm1.Controls.Add(txt2);
                            frm1.Controls.Add(txt3);
                            frm1.Controls.Add(pic);
                            mytop += 150;
                            i += 3;
                        }
                    }
                    while (i < counter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                frm1.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
                StreamReader sr = new StreamReader("Data.txt");
                String Line = sr.ReadToEnd();
                sr.Close();
                String[] s = Line.Split(',');
                int i = s.Count();
                int m = int.Parse(s[i - 4]) + 1;
                textBox1.Text = m.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string first = sr.ReadLine();
                string[] ID = first.Split(',');
                sr.Close();
                    textBox1.Text = ID[0];
                    textBox2.Text = ID[1];
                    textBox3.Text = ID[2];
                    string img = "img/" + ID[0].Trim() + ".jpg";
                    if (File.Exists(img))
                    {
                        pictureBox1.Image = Image.FromFile(img);
                    }                             
            } catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            { 
                int a = 0;
                StreamReader sr = new StreamReader("Data.txt");
                string s = sr.ReadToEnd();
                string[] g = s.Split(',');
                sr.Close();
                int n = g.Count();
                if (textBox1.Text.Trim() == "")
                {
                    textBox1.Text = g[0];
                    textBox2.Text = g[1];
                    textBox3.Text = g[2];
                    string img = "img/" + g[0].Trim() + ".jpg";
                    a += 3;
                    if (File.Exists(img))
                    {
                        pictureBox1.Image = Image.FromFile(img.Trim());
                    }
                    else
                    {
                       
                    }
                }
                else if(textBox1.Text.Trim()!="")
                {
                    for (int i = 0; i <= n - 1; i+=3) 
                    {
                        if (textBox1.Text == g[i])
                        {
                            a = i + 3;
                            break;
                        }
                    }
                    if (a <= n-2) 
                    {
                        textBox1.Text = g[a];
                        textBox2.Text = g[a + 1];
                        textBox3.Text = g[a + 2];
                        string img = "img/"+g[a].Trim()+".jpg";
                        img = img.Trim();
                        if (File.Exists(img))
                        {
                            pictureBox1.Image = Image.FromFile(img);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        a += 3;
                    }
                    else
                    {
                        MessageBox.Show("It Is last Value", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string f = sr.ReadToEnd();
                sr.Close();
                string[] c = f.Split(',');
                if (textBox1.Text.Trim() == "")
                {
                    int v = c.Count();
                    textBox1.Text = c[v - 4];
                    textBox2.Text = c[v - 3];
                    textBox3.Text = c[v - 2];
                    string img = "img/" + c[v - 4].Trim() + ".jpg";
                    if (File.Exists(img))
                    {
                        pictureBox1.Image = Image.FromFile(img);
                    }
                    else
                    {
                      
                    }

                }
                else if (textBox1.Text.Trim() != "")
                {
                    int j = 0;
                    int v = c.Count();
                    for (int i = v - 1; i <= v - 1; i--)
                    {
                        if (textBox1.Text == c[i])
                        {
                            j = i;
                            break;
                        }
                    }
                    if (j > 0)
                    {
                        textBox1.Text = c[j - 3];
                        textBox2.Text = c[j - 2];
                        textBox3.Text = c[j - 1];
                        string img = "img/" + c[j - 3].Trim() + ".jpg";
                        if (File.Exists(img))
                        {
                            pictureBox1.Image = Image.FromFile(img);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        j -= 3;
                    }
                    else if (j <= 0) 
                    {
                        MessageBox.Show("It Is First value ", "Error");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string f = sr.ReadToEnd();
                sr.Close();
                string[] c = f.Split(',');
                int v = c.Count();
                textBox1.Text = c[v - 4];
                textBox2.Text = c[v - 3];
                textBox3.Text = c[v - 2];
                string img = "img/" + c[v - 4].Trim() + ".jpg";

                if (File.Exists(img))
                {
                    pictureBox1.Image = Image.FromFile(img);
                }
                else
                {

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            of.Filter="Images|*.jpg;*.png;*.gif";
            DialogResult dr = new DialogResult();
            dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
            else
            {
                MessageBox.Show("Please Choose An Image");
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            textBox1.Focus();
        }
    }
}
