﻿using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class.ChildForm
{
    public partial class SalesPerson : Form
    {
        public SalesPerson()
        {
            InitializeComponent();
        }

        private void SalesPerson_Load(object sender, EventArgs e)
        {
            dgv_NV.DataSource = BLL.LayNV();
        }
    }
}
