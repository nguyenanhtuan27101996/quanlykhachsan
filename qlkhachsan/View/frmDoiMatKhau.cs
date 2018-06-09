using qlkhachsan.Model;
using qlkhachsan.Service;
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
    public partial class frmDoiMatKhau : Form
    {
        private NhanVienService nhanVienService = new NhanVienServiceImpl();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string strMatKhauHienTai = txtMatKhauHienTai.Text.Trim();
            string strMatKhauMoi = txtMatKhauMoi.Text.Trim();
            string strNhapLaiMatKhauMoi = txtNhapLaiMatKhauMoi.Text.Trim();

            if (!kiemTraNhapRong(strMatKhauHienTai, strMatKhauMoi, 
                strNhapLaiMatKhauMoi))
            {
                MessageBox.Show("Bạn nhập chưa đầy đủ !","Thông báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string strMaNhanVien = lblMaNhanVien.Text;
                List<NhanVien> lstNhanVien = nhanVienService.
                    timKiemNhanVienTheoMa(strMaNhanVien);
                string strMatKhauDung = lstNhanVien[0].MatKhau;
                if (strMatKhauHienTai.Equals(strMatKhauDung))
                {
                    if (kiemTraNhapLaiMatKhau(strMatKhauMoi, strNhapLaiMatKhauMoi))
                    {
                        NhanVien objNhanVien = new NhanVien();
                        objNhanVien.MaNhanVien = strMaNhanVien;
                        objNhanVien.MatKhau = strMatKhauMoi;
                        objNhanVien.QuyenHan = lstNhanVien[0].QuyenHan;
                        objNhanVien.HoTen= lstNhanVien[0].HoTen;
                        if (nhanVienService.capNhatNhanVien(objNhanVien))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetTextBox();
                            this.Hide();
                            frmThoatTaiKhoan f = new frmThoatTaiKhoan();
                            f.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp.Vui lòng nhập lại !", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại chưa đúng.Vui lòng nhập lại !", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private bool kiemTraNhapRong(string strMatKhauHienTai,
            string strMatKhauMoi, string strNhapLaiMatKhauMoi)
        {
            

            if((strMatKhauHienTai.Equals("")) || (strMatKhauMoi.Equals("")) || 
                (strNhapLaiMatKhauMoi.Equals(""))){
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private bool kiemTraNhapLaiMatKhau(string strMatKhauMoi
            , string strNhapLaiMatKhauMoi)
        {
            if (strMatKhauMoi.Equals(strNhapLaiMatKhauMoi))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void resetTextBox()
        {
            txtMatKhauHienTai.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLaiMatKhauMoi.Clear();
        }
    }
}
