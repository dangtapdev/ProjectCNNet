using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN_UI main_f = new MAIN_UI();
            main_f.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
