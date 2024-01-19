using BussinessLogicLayer;
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
    public partial class Car_models : Form
    {
        public Car_models()
        {
            InitializeComponent();
        }

        private void Car_models_Load(object sender, EventArgs e)
        {
            dgv_Cars.DataSource = BLL.LayXe();
        }
    }
}
