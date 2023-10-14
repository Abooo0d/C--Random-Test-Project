using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public static SqlConnection connection;
        public static SqlDataAdapter adapter;
        public static SqlCommandBuilder commandbuilder;
        public static DataTable datatable = new DataTable();
        public static DataRow datarow;
        public static int i = 0;
        public static bool reload = false;
        private bool Dragging = false;
        private Point startpoint = new Point(0, 0);
        public Form Activeform = null;
        public static AutoCompleteStringCollection txtstring = new AutoCompleteStringCollection();
        #region Design 
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
        #endregion
        #region Methods
        public void pnlon(Button btn)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }
        public void pnlleave(Button btn)
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }
        public void openconnection()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select * from projectdata", connection);
                commandbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(datatable);
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
            
        }
        public void filldata()
        {
            try
            {
                datatable.Clear();
                adapter = new SqlDataAdapter("select * from projectdata", connection);
                commandbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(datatable);
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
           
        }
        public void filllists()
        {
            try
            {
                lbxallprojects.Items.Clear();
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    lbxallprojects.Items.Add(datatable.Rows[i]["plate_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
           
        }
        public void clearsearch()
        {
            lbxsearchresulte.Items.Clear();
            txtsearch.Text = "Search.";
        }
        public void openForm(Form childeform)
        {
            if (Activeform != null)
            {
                Activeform.Close();
            }
            Activeform = childeform;
            childeform.TopLevel = false;
            childeform.FormBorderStyle = FormBorderStyle.None;
            childeform.Dock = DockStyle.Fill;
            childeform.BringToFront();
            pnlcontaner.Controls.Add(childeform);
            pnlcontaner.Tag = childeform;
            childeform.Show();
        }
        public void txtcomplet()
        {
            try
            {
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    txtstring.Add(datatable.Rows[i]["owner_name"].ToString());
                    txtstring.Add(datatable.Rows[i]["plate_name"].ToString());
                }
                txtsearch.AutoCompleteMode = AutoCompleteMode.Append;
                txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtsearch.AutoCompleteCustomSource = txtstring;
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
        }
        #endregion
        #region Dragging
        private void pnltopborder_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            startpoint = new Point(e.X, e.Y);
        }
        private void pnltopborder_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        private void pnltopborder_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
        #endregion
        private void btnhome_Click(object sender, EventArgs e)
        {
            filldata();
            filllists();
            clearsearch();
            pnlon(btnhome);
            Home h = new Home();
            openForm(h);
            btnadd.BackColor = Color.FromArgb(255, 24, 30, 54);
            btnedite.BackColor = Color.FromArgb(255, 24, 30, 54);

        }
        private void btnhome_Leave(object sender, EventArgs e)
        {
            pnlleave(btnhome);
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            pnlon(btnadd);
            Add aa = new Add();
            openForm(aa);
            btnhome.BackColor = Color.FromArgb(255, 24, 30, 54);
            btnedite.BackColor = Color.FromArgb(255, 24, 30, 54);
        }
        private void btnadd_Leave(object sender, EventArgs e)
        {
            pnlleave(btnadd);
        }
        private void btnedite_Click(object sender, EventArgs e)
        {
            pnlon(btnedite);
            Edite ee = new Edite();
            openForm(ee);
            btnhome.BackColor = Color.FromArgb(255, 24, 30, 54);
            btnadd.BackColor = Color.FromArgb(255, 24, 30, 54);
        }
        private void btnedite_Leave(object sender, EventArgs e)
        {
            pnlleave(btnedite);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblusername.Text = Login.name;
            try
            {
                openconnection();
                btnhome.PerformClick();
                txtcomplet();
            }
            catch (Exception ex)
            { lblerrorprovider.Text = ex.Message; }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
            Application.Exit();
        }
        private void lbxallprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedproject = lbxallprojects.SelectedItem.ToString();
            i = lbxallprojects.SelectedIndex;
            btnhome.PerformClick();
        }
        private void btnperson_Click(object sender, EventArgs e)
        {
            try
            {
                lbxsearchresulte.Items.Clear();
                string person = txtsearch.Text;
                txtsearch.Text = "";
                if (person != "")
                {
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        if (person == datatable.Rows[i]["owner_name"].ToString())
                        {
                            string plate = datatable.Rows[i]["plate_name"].ToString();
                            if (!lbxsearchresulte.Items.Contains(plate + "," + person))
                            {
                                lbxsearchresulte.Items.Add(plate.Trim() + "," + person.Trim());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
        }
        private void btnplate_Click(object sender, EventArgs e)
        {
            try
            {
                string plate = txtsearch.Text;
                lbxsearchresulte.Items.Clear();
                txtsearch.Text = "";
                if (plate != "")
                {
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        if (plate == datatable.Rows[i]["plate_name"].ToString())
                        {
                            MainForm.i = i;
                            btnhome.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrorprovider.Text = ex.Message;
            }
        }
        private void txtsearch_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }
        private void lbxsearchresulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = lbxsearchresulte.SelectedItem.ToString().Trim();
            string[] selectedplate = line.Split(',');
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                if (datatable.Rows[i]["owner_name"].ToString() == selectedplate[1] && datatable.Rows[i]["plate_name"].ToString() == selectedplate[0])
                {
                    MainForm.i = i;
                    btnhome.PerformClick();
                    break;
                }
            }
        }
    }
}
