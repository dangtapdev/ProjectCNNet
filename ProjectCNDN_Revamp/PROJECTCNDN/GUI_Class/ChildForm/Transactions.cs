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
    public partial class Transactions : Form
    {        
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            dgv_Trans.DataSource = BLL.LayGD();
        }
    }
}
