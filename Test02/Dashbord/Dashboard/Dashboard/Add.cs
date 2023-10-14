using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void btncansel_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
            } 
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.datarow = MainForm.datatable.NewRow();
                MainForm.datarow["id"] = MainForm.datatable.Rows.Count + 1;
                MainForm.datarow["owner_name"] = txtowner.Text;
                MainForm.datarow["plate_id"] = txtplatenum.Text;
                MainForm.datarow["plate_name"] = txtplatename.Text;
                MainForm.datarow["box_num"] = txtboxnum.Text;
                MainForm.datarow["pallet_num"] = txtpalletnum.Text;
                MainForm.datatable.Rows.Add(MainForm.datarow);
                MainForm.adapter.Update(MainForm.datatable);
                MainForm.i = MainForm.datatable.Rows.Count - 1;
                foreach (Control c in Controls)
                {
                    if (c is TextBox) c.Text = "";
                }
                MainForm.btnhome.PerformClick();
            }
            catch (Exception ex)
            {
                MainForm.lblerrorprovider.Text = ex.Message;
            }
        }
    }
}
