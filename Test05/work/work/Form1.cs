using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace work
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
            int nHeightEllipse

     );
        public static SqlConnection workCon;
        public static SqlDataAdapter workDa;
        public static SqlCommandBuilder workCom;
        public static DataTable worktb = new DataTable();
        public static DataRow workNr;
        public static int i = 0;
        public static string s1, s2, s3, s4, s5;
        public static List<int> a = new List<int>();

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void ShowCurentCord()
        {
            try
            {
                if (worktb.Rows.Count == 0)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    comboBox3.Items.Clear();
                    comboBox3.Text = "";
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
                else
                {
                    listBox1.Items.Clear();
                    textBox1.Text = worktb.Rows[i]["Plate_Name"].ToString();
                    textBox2.Text = worktb.Rows[i]["Clinte_Name"].ToString();
                    textBox3.Text = worktb.Rows[i]["Last_Use"].ToString();
                    textBox4.Text = worktb.Rows[i]["Pallet_Num"].ToString();
                    textBox5.Text = worktb.Rows[i]["Box_Num"].ToString();
                    for (int w = 0; w < worktb.Rows.Count; w++)
                    {
                        if (comboBox3.Items.Contains(worktb.Rows[w]["Pallet_Num"]))
                        {

                        }
                        else
                        {
                            comboBox3.Items.Add(worktb.Rows[w]["Pallet_Num"]);
                        }
                    }
                    for (int t = 0; t < worktb.Rows.Count; t++)
                    {
                        string r = worktb.Rows[t]["Plate_name"] + "   (" + worktb.Rows[t]["Clinte_Name"] + ")".ToString();
                        listBox1.Items.Add(r);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                button3.Select();
                workCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Work1.mdf;Integrated Security=True");
                workCon.Open();
                workDa = new SqlDataAdapter("Select * from plate_information", workCon);
                workCom = new SqlCommandBuilder(workDa);
                workDa.Fill(worktb);
                this.ShowCurentCord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox1.Enabled = false;
                comboBox3.Text = "";
                listBox2.Items.Clear();
                if (i < worktb.Rows.Count - 1)
                {
                    i++;
                    this.ShowCurentCord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (worktb.Rows.Count > 0)
                {
                    a.Clear();
                    listBox2.Items.Clear();
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    comboBox3.Text = "";
                    listBox2.Enabled = true;
                    int c = worktb.Rows.Count;
                    string q;
                    string s = textBox2.Text;
                    for (int y = 0; y < worktb.Rows.Count; y++)
                    {
                        q = worktb.Rows[y]["Clinte_Name"].ToString();
                        if (q == s)
                        {
                            listBox2.Items.Add(worktb.Rows[y]["Plate_Name"]);
                            a.Add(y);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ther Is No Record Inserted To Search In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Text = "";
                comboBox3.Items.Clear();
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox2.Enabled = false;
                this.ShowCurentCord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (worktb.Rows.Count == 0)
                {
                    MessageBox.Show("Ther Is No Recorde To Be Deleted", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    comboBox3.Text = "";
                    DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        for (int g = i; g <= worktb.Rows.Count - 1; g++)
                        {
                            if (g == worktb.Rows.Count - 1)
                            {
                                worktb.Rows[g].Delete();
                                break;
                            }
                            worktb.Rows[g]["Plate_Name"] = worktb.Rows[g + 1]["Plate_Name"];
                            worktb.Rows[g]["Clinte_Name"] = worktb.Rows[g + 1]["Clinte_Name"];
                            worktb.Rows[g]["Last_Use"] = worktb.Rows[g + 1]["Last_Use"];
                            worktb.Rows[g]["Pallet_Num"] = worktb.Rows[g + 1]["Pallet_Num"];
                            worktb.Rows[g]["Box_Num"] = worktb.Rows[g + 1]["Box_Num"];
                        }
                        workDa.Update(worktb);
                        if (i == 0)
                        {
                            this.ShowCurentCord();
                        }
                        else
                        {
                            i--;
                            this.ShowCurentCord();
                        }
                        MessageBox.Show("The Recorde Has Been Deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (worktb.Rows.Count > 0)
                {
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    comboBox3.Text = "";
                    listBox2.Items.Clear();
                    int c = worktb.Rows.Count;
                    string[] a = new string[c];
                    for (int g = 0; g < worktb.Rows.Count; g++)
                    {
                        a[g] = worktb.Rows[g]["Plate_name"].ToString();
                    }
                    bool found = false;
                    for (int g = 0; g < worktb.Rows.Count; g++)
                    {
                        if (a[g] == textBox1.Text)
                        {
                            found = true;
                            textBox1.Text = worktb.Rows[g]["Plate_name"].ToString();
                            textBox2.Text = worktb.Rows[g]["Clinte_Name"].ToString();
                            textBox3.Text = worktb.Rows[g]["Last_Use"].ToString();
                            textBox4.Text = worktb.Rows[g]["Pallet_Num"].ToString();
                            textBox5.Text = worktb.Rows[g]["Box_Num"].ToString();
                            break;
                        }
                    }
                    if (!found)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        MessageBox.Show("The Record You Ordered Is Not Exist.", "Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ther Is No Record Inserted To Search In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                string Box = comboBox1.SelectedItem.ToString();
                string Pallet = comboBox3.SelectedItem.ToString();
                string a;
                string b;
                for (int g = 0; g < worktb.Rows.Count; g++)
                {
                    a = worktb.Rows[g]["Box_Num"].ToString();
                    b = worktb.Rows[g]["Pallet_Num"].ToString();
                    if (a == Box&&b==Pallet)
                    {
                        i = g;
                        button8.Select();
                        this.ShowCurentCord();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> PalletNum = new List<string>();
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                listBox2.Items.Clear();
                for (int h = 0; h < worktb.Rows.Count; h++)
                {
                    string a = comboBox3.SelectedItem.ToString();
                    string b = worktb.Rows[h]["Pallet_Num"].ToString();
                    if (a == b)
                    {
                        if (PalletNum.Contains(worktb.Rows[h]["Box_Num"])) { }
                        else
                        {
                            PalletNum.Add(worktb.Rows[h]["Box_Num"].ToString());
                        }
                    }
                }

                for (int all = 0; all < PalletNum.Count(); all++)
                {
                    comboBox1.Items.Add((all + 1).ToString());
                }
                comboBox1.Enabled = true;
                /*
                List<string> pallet = new List<string>();
                
                for (int h = 0; h < PalletNum.Count(); h++)
                {  
                    if (pallet.Count() == 0)
                    {
                        
                        string pn = PalletNum[0].ToString();
                        pallet.Add(pn);
                        continue;
                    }
                    else if (pallet.Count()>0)
                    {
                        for (int o = 0; o < PalletNum.Count(); o++)
                        {
                            string p1 = pallet[o].Trim();
                            string pn1 = PalletNum[h].Trim();
                            int p = int.Parse(p1);
                            int PN = int.Parse(pn1);
                            if (PN >= p)
                            {
                                pallet.Add( PalletNum[h].ToString());
                                continue;
                            }
                            else if (PN < p)
                            {
                                for (int y = pallet.Count() - 1; y >= o; y--)
                                {
                                    pallet.Add(" ");
                                    pallet[y + 1] = pallet[y];
                                }
                                pallet[o] = PalletNum[h];
                                int l = pallet.Count() - 1;
                                pallet.RemoveAt(l);
                                continue;
                            }
                        }
                    }
                    
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            workCon.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex < 0 || listBox2.SelectedIndex > listBox2.Items.Count)
                { }
                else
                {
                    int g = listBox2.SelectedIndex;
                    i = a[g];
                    this.ShowCurentCord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel6.Height = button7.Height;
            panel6.Top = button7.Top;
            panel6.Left = button7.Left;
            button7.BackColor = Color.FromArgb(46,51,73);
        }

        private void button7_Leave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(24,30,54);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex < 0)
                {

                }
                else
                {
                    i = listBox1.SelectedIndex;
                    this.ShowCurentCord();
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    comboBox1.Enabled = false;
                    comboBox3.Text = "";
                    listBox2.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox1.Enabled = false;
                comboBox3.Text = "";
                listBox2.Items.Clear();
                if (i > 0)
                {
                    i--;
                    this.ShowCurentCord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*try
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            panel6.Height = button4.Height;
            panel6.Top = button4.Top;
            panel6.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (worktb.Rows.Count > 0)
                {
                    s1 = textBox1.Text;
                    s2 = textBox2.Text;
                    s3 = textBox3.Text;
                    s4 = textBox4.Text;
                    s5 = textBox5.Text;
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ther Is No Recorde To Ediet","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            panel6.Height = button6.Height;
            panel6.Top = button6.Top;
            panel6.Left = button6.Left;
            button6.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
