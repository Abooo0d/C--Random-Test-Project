﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            bunifuCustomDataGrid1.Rows.Add(
                new object[] {
                    26000,
                    "coffe",
                    26000
                }
                );
            bunifuCustomDataGrid1.Rows.Add(
                new object[] {
                    26000,
                    "coffe",
                    26000
                }
                );
            bunifuCustomDataGrid1.Rows.Add(
                new object[] {
                    26000,
                    "coffe",
                    26000
                }
                );
            bunifuCustomDataGrid1.Rows.Add(
                new object[] {
                    26000,
                    "coffe",
                    26000
                }
                );
        }
    }
}
