using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlkhachsan.View
{
    public partial class frmThoatTaiKhoan : Form
    {
        public frmThoatTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (rdoDangXuatHet.Checked)
            {
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }
    }
}
