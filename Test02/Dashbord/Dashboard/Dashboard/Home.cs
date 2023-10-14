using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public void showcurentcord()
        {
            try
            {
                if (MainForm.datatable.Rows.Count == 0) { }
                else
                {
                    txtowner.Text = MainForm.datatable.Rows[MainForm.i]["owner_name"].ToString();
                    txtplatenum.Text = MainForm.datatable.Rows[MainForm.i]["plate_id"].ToString();
                    txtplatename.Text = MainForm.datatable.Rows[MainForm.i]["plate_name"].ToString();
                    txtboxnum.Text = MainForm.datatable.Rows[MainForm.i]["box_num"].ToString();
                    txtpalletnum.Text = MainForm.datatable.Rows[MainForm.i]["pallet_num"].ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.lblerrorprovider.Text = ex.Message;
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            showcurentcord();
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (MainForm.i < MainForm.datatable.Rows.Count-1)
            {
                MainForm.i++;
                showcurentcord();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            if (MainForm.i > 0)
            {
                MainForm.i--;
                showcurentcord();
            }
        }
        private void btnfirstone_Click(object sender, EventArgs e)
        {
            MainForm.i = 0;
            showcurentcord();
        }
        private void btnlastone_Click(object sender, EventArgs e)
        {
            MainForm.i = MainForm.datatable.Rows.Count - 1;
            showcurentcord();
        }
        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            showcurentcord();
        }
    }
}
