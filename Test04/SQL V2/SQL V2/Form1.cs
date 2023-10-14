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

namespace SQL_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SqlConnection con;
            con = new SqlConnection("Data Source=DESKTOP-53QHABJ\\SAAD_ALDEEN;Initial Catalog=My_Final_Project;Integrated Security=True");
            con.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Ready_Setups", con);
            SqlCommandBuilder cm = new SqlCommandBuilder(dt);
            DataTable a = new DataTable();
            dt.Fill(a);
            DataRow nr = a.NewRow();
            int i = a.Rows.Count+1;
            nr["ID"] = i;
            nr["Brand"] = " ";
            nr["CPU_Name"] = textBox1.Text;
            nr["MatherBord_Name"] = textBox2.Text;
            nr["Graphic_Card_Name"] = textBox3.Text;
            nr["RAM"] = " ";
            nr["Hard_Disc"] = " ";
            a.Rows.Add(nr);
            dt.Update(a);
            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
