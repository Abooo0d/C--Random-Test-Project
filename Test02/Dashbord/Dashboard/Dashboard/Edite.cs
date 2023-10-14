using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Edite : Form
    {
        public Edite()
        {
            InitializeComponent();
        }
        public string[] data = new string[5];
        public void showcurrentcord()
        {
            try
            {
                txtowner.Text = MainForm.datatable.Rows[MainForm.i]["owner_name"].ToString();
                txtplatenum.Text = MainForm.datatable.Rows[MainForm.i]["plate_id"].ToString();
                txtplatename.Text = MainForm.datatable.Rows[MainForm.i]["plate_name"].ToString();
                txtboxnum.Text = MainForm.datatable.Rows[MainForm.i]["box_num"].ToString();
                txtpalletnum.Text = MainForm.datatable.Rows[MainForm.i]["pallet_num"].ToString();

                data[0] = MainForm.datatable.Rows[MainForm.i]["owner_name"].ToString();
                data[1] = MainForm.datatable.Rows[MainForm.i]["plate_id"].ToString();
                data[2] = MainForm.datatable.Rows[MainForm.i]["plate_name"].ToString();
                data[3] = MainForm.datatable.Rows[MainForm.i]["box_num"].ToString();
                data[4] = MainForm.datatable.Rows[MainForm.i]["pallet_num"].ToString();
            }
            catch (Exception ex)
            {
                MainForm.lblerrorprovider.Text = ex.Message;
            }
        }
        private void Edite_Load(object sender, EventArgs e)
        {
            showcurrentcord();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtowner.Text = data[0].ToString();
            txtplatenum.Text = data[1].ToString();
            txtplatename.Text = data[2].ToString();
            txtboxnum.Text = data[3].ToString();
            txtpalletnum.Text = data[4].ToString();
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.datatable.Rows[MainForm.i]["owner_name"] = txtowner.Text;
                MainForm.datatable.Rows[MainForm.i]["plate_id"] = txtplatenum.Text;
                MainForm.datatable.Rows[MainForm.i]["plate_name"] = txtplatename.Text;
                MainForm.datatable.Rows[MainForm.i]["box_num"] = txtboxnum.Text;
                MainForm.datatable.Rows[MainForm.i]["pallet_num"] = txtpalletnum.Text;
                MainForm.adapter.Update(MainForm.datatable);
                MainForm.btnhome.PerformClick();
            }
            catch (Exception ex)
            {
                MainForm.lblerrorprovider.Text = ex.Message;
            }
        }
    }
}
