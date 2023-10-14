using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SalePoint
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        //Fields
        public SqlConnection storageConnection;
        public SqlCommandBuilder storageCommandBulider;
        public SqlDataAdapter storageAdaptar;
        public DataTable storageDataTable = new DataTable();
        public DataRow storageDataRow;
        public int i = 0;
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);

        //Methods
        public void OpenConnection()
        {
            try
            {
                storageConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad_Aldeen\documents\visual studio 2015\Projects\SalePoint\SalePoint\Sales.mdf;Integrated Security=True");
                storageConnection.Open();
                storageAdaptar = new SqlDataAdapter("select * from Storage", storageConnection);
                storageCommandBulider = new SqlCommandBuilder(storageAdaptar);
                storageAdaptar.Fill(storageDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr");
            }
        }
        public void FillData()
        {
            try
            {
                if (i<storageDataTable.Rows.Count)
                {
                    txtMaterialName._Text = storageDataTable.Rows[i]["Material_name"].ToString();
                    txtMaterialNum._Text = storageDataTable.Rows[i]["id"].ToString();
                    txtPrice._Text = storageDataTable.Rows[i]["Price"].ToString();
                    txtQunity._Text = storageDataTable.Rows[i]["Quntity"].ToString();
                    txtColor._Text = storageDataTable.Rows[i]["Color"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UPdate()
        {
            try
            {
                storageDataTable.Rows[i]["Material_name"] = txtMaterialName._Text;
                storageDataTable.Rows[i]["id"] = txtMaterialNum._Text;
                storageDataTable.Rows[i]["Price"] = txtPrice._Text;
                storageDataTable.Rows[i]["Quntity"] = txtQunity._Text;
                storageDataTable.Rows[i]["Color"] = txtColor._Text;
                storageAdaptar.Update(storageDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delet()
        {
            for (int x = i; x < storageDataTable.Rows.Count-1; x++)
            {
                storageDataTable.Rows[x]["Material_name"] = storageDataTable.Rows[x + 1]["Material_name"];
                storageDataTable.Rows[x]["id"] = storageDataTable.Rows[x + 1]["id"];
                storageDataTable.Rows[x]["Price"] = storageDataTable.Rows[x + 1]["Price"];
                storageDataTable.Rows[x]["Quntity"] = storageDataTable.Rows[x + 1]["Quntity"];
                storageDataTable.Rows[x]["Color"] = storageDataTable.Rows[x + 1]["Color"];
            }
            i = storageDataTable.Rows.Count - 1;
            storageDataTable.Rows[i].Delete();
            storageAdaptar.Update(storageDataTable);
            i = 0;
        }
        //Events
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseLeave(object sender, EventArgs e)
        {
            Dragging = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            OpenConnection();
            FillData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i<storageDataTable.Rows.Count-1)
            {
                i++;
                FillData();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (i>0)
            {
                i--;
                FillData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPdate();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            Delet();
            FillData();
        }
    }
}
