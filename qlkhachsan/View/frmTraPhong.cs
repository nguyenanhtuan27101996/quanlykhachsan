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
    public partial class frmTraPhong : Form
    {
        private PhongDatService phongDatService = new PhongDatServiceImpl();
        private NhatKyService nhatKyService = new NhatKyServiceImpl();
        private NhatKy objNhatKy = new NhatKy();
        private PhongService phongService = new PhongServiceImpl();
        public bool kiemTraAnNut;
        public string strTenNhanVien = "";
        public bool flagHienThiMenu;
        public string strMaNhanVien = "";
        public frmTraPhong()
        {
            InitializeComponent();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Enabled = false;
            dtpNgayDatPhong.Enabled = false;
            dtpNgayTraPhong.Enabled = false;
            txtMaHopDong.Enabled = false;
            txtCMND.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtSoNguoi.Enabled = false;
           
            ganGiaTriChoCacView();

        }

        private void ganGiaTriChoCacView()
        {
            List<PhongDat> lstPhongDat = phongDatService
                .timKiemPhongDatTheoMaPhong(txtMaPhong.Text);
            txtMaHopDong.Text = lstPhongDat[0].MaHopDong;
            txtCMND.Text = lstPhongDat[0].Cmnd;
            txtTenKhachHang.Text = lstPhongDat[0].TenKhachHang;
            txtSoNguoi.Text = lstPhongDat[0].SoNguoi.ToString();
            dtpNgayDatPhong.Text = lstPhongDat[0].NgayDatPhong.ToString();
            dtpNgayTraPhong.Text = DateTime.Now.ToString();
            txtMaNhanVien.Items.Add(lstPhongDat[0].MaNhanVien);
            txtMaNhanVien.SelectedIndex = 0;

            objNhatKy.MaHopDong = txtMaHopDong.Text;
            objNhatKy.MaPhong = txtMaPhong.Text;
            objNhatKy.Cmnd = txtCMND.Text;
            objNhatKy.TenKhachHang = txtTenKhachHang.Text;
            objNhatKy.SoNguoi = int.Parse(txtSoNguoi.Text);
            objNhatKy.NgayDatPhong = dtpNgayDatPhong.Value;
            objNhatKy.NgayTraPhong = dtpNgayTraPhong.Value;
            objNhatKy.MaNhanVien = txtMaNhanVien.Text;

            float soTienPhaiTra = nhatKyService.tinhTienThuePhong(objNhatKy);
            lblSoTien.Text= String.Format("{0:#,###}", soTienPhaiTra);
            objNhatKy.SoTien = float.Parse(lblSoTien.Text);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (nhatKyService.themNhatKy(objNhatKy))
            {
                MessageBox.Show("Trả phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phongDatService.xoaPhongDat(objNhatKy.MaHopDong);
                kiemTraAnNut = true;
                //thay doi trang thai khi phong duoc tra
                List<Phong> lstPhong = phongService.timPhongTheoMaPhong(objNhatKy.MaPhong);
                Phong objPhong = new Phong();
                objPhong.MaPhong = lstPhong[0].MaPhong;
                objPhong.TinhTrang = "Trống";
                phongService.capNhatTinhTrangPhong(objPhong);
                //
                this.Hide();
                frmTrangChu f = new frmTrangChu();
                f.strTenNhanVien = strTenNhanVien;
                f.flagHienThiMenu = flagHienThiMenu;
                f.strMaNhanVien = strMaNhanVien;
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Trả phòng không thành công !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu f = new frmTrangChu();
            f.strTenNhanVien = strTenNhanVien;
            f.flagHienThiMenu = flagHienThiMenu;
            f.strMaNhanVien = strMaNhanVien;
            f.ShowDialog();
            this.Close();
            kiemTraAnNut = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
