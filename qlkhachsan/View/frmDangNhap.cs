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
    public partial class frmDangNhap : Form
    {
        private bool flagShowPassWord = true;
        private NhanVienService nhanVienService = new NhanVienServiceImpl();
        private NhatKyDangNhapService nhatKyDangNhapService = new NhatKyDangNhapServiceImpl();

        public frmDangNhap()
        {
            InitializeComponent();
        }

      
        private void btnHienThiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (flagShowPassWord)
            {
                txtMatKhau.PasswordChar = '\0';
                btnHienThiMatKhau.Text = "Ẩn";
                flagShowPassWord = false;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                btnHienThiMatKhau.Text = "Hiển thị";
                flagShowPassWord = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cboQuyenHan.SelectedIndex = 0;
           
        }
        private bool kiemTraNhapRong(string strMaNhanVien,string strMatKhau)
        {
            if(strMaNhanVien.Equals("") || strMatKhau.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemTraNhapRong(txtMaNhanVien.Text.Trim(), txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Bạn nhập chưa đầy đủ ! ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                NhanVien objNhanVien = new NhanVien();
                objNhanVien.MaNhanVien = txtMaNhanVien.Text.Trim();
                objNhanVien.MatKhau = txtMatKhau.Text.Trim();
                objNhanVien.QuyenHan = cboQuyenHan.Text;
                if (objNhanVien.QuyenHan.Equals("Quản trị viên"))
                {
                    if (nhanVienService.dangNhap(objNhanVien))
                    {
                        string strThoiGianHienTai = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                        MessageBox.Show("Đăng nhập thành công lúc " + strThoiGianHienTai, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmTrangChu f = new frmTrangChu();
                        string strHoTen = nhanVienService.timKiemNhanVienTheoMa
                            (objNhanVien.MaNhanVien)[0].HoTen;
                        f.strTenNhanVien = strHoTen;
                        f.strMaNhanVien = txtMaNhanVien.Text.Trim();
                        f.flagHienThiMenu = true;

                        //them vao nhat ky dang nhap
                        NhatKyDangNhap objNhatKyDangNhap = new NhatKyDangNhap();
                        objNhatKyDangNhap.MaNhanVien = objNhanVien.MaNhanVien;
                        objNhatKyDangNhap.QuyenHan = objNhanVien.QuyenHan;
                        objNhatKyDangNhap.HoTen = strHoTen;
                        objNhatKyDangNhap.ThoiGianDangNhap = DateTime.Now;
                        nhatKyDangNhapService.themNhatKy(objNhatKyDangNhap);
                        //
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (nhanVienService.dangNhap(objNhanVien))
                    {
                        string strThoiGianHienTai = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                        MessageBox.Show("Đăng nhập thành công lúc " + strThoiGianHienTai, "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmTrangChu f = new frmTrangChu();
                        string strHoTen = nhanVienService.timKiemNhanVienTheoMa
                           (objNhanVien.MaNhanVien)[0].HoTen;
                        f.strTenNhanVien = strHoTen;
                        f.strMaNhanVien = txtMaNhanVien.Text.Trim();
                        f.flagHienThiMenu = false;
                        //them vao nhat ky dang nhap
                        NhatKyDangNhap objNhatKyDangNhap = new NhatKyDangNhap();
                        objNhatKyDangNhap.MaNhanVien = objNhanVien.MaNhanVien;
                        objNhatKyDangNhap.QuyenHan = objNhanVien.QuyenHan;
                        objNhatKyDangNhap.HoTen = strHoTen;
                        objNhatKyDangNhap.ThoiGianDangNhap = DateTime.Now;
                        nhatKyDangNhapService.themNhatKy(objNhatKyDangNhap);
                        //
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
