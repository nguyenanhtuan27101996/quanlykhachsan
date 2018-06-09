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
    public partial class frmDatPhong : Form
    {
       
        public bool kiemTraAnNut;
        private PhongDatService phongDatService = new PhongDatServiceImpl();
        private NhanVienService nhanVienService = new NhanVienServiceImpl();
        private PhongService phongService = new PhongServiceImpl();
        public string strTenNhanVien = "";
        public bool flagHienThiMenu;
        public string strMaNhanVien = "";
        public frmDatPhong()
        {
            InitializeComponent();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool kiemTraNhapRong(string strMaHopDong,string strCMND,
            string strTenKhachHang,string strSoNguoi)
        {
            if(strMaHopDong.Equals("") || strCMND.Equals("") 
                || strTenKhachHang.Equals("")|| strSoNguoi.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dtpNgayDatPhong.Enabled = false;
            txtMaPhong.Enabled = false;
            dtpNgayDatPhong.Text = DateTime.Now.ToString();
            ganGiaTriLenComboboxMaNhanVien();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if(!kiemTraNhapRong(txtMaHopDong.Text,txtCMND.Text,txtTenKhachHang.Text,
                txtSoNguoi.Text))
            {
                MessageBox.Show("Nhập thông tin không đầy đủ !", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                try
                {
                    string strMaHopDong = txtMaHopDong.Text.Trim();
                    string strMaPhong = txtMaPhong.Text;
                    string strCMND = txtCMND.Text.Trim();
                    string strTenKhachHang = txtTenKhachHang.Text.Trim();
                    int soNguoi = int.Parse(txtSoNguoi.Text.Trim());
                    DateTime ngayDatPhong = dtpNgayDatPhong.Value;
                    string strMaNhanVien = txtMaNhanVien.Text.Trim();

                    PhongDat objPhongDat = new PhongDat(strMaHopDong, strMaPhong, strCMND,
                        strTenKhachHang, soNguoi, ngayDatPhong, strMaNhanVien);

                    if (phongDatService.datPhong(objPhongDat))
                    {
                        MessageBox.Show("Đặt phòng thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kiemTraAnNut = true;

                        //thay đổi trạng thái của phòng khi đã đặt phòng thành công
                        List<Phong> lstPhong = phongService.timPhongTheoMaPhong(strMaPhong);
                        Phong objPhong = new Phong();
                        objPhong.MaPhong = lstPhong[0].MaPhong;
                        objPhong.TinhTrang = "Đang được thuê";
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
                        MessageBox.Show("Đặt phòng không thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thông tin nhập vào không đúng.Mời nhập lại !", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            
           

        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            kiemTraAnNut = false;

            this.Hide();
            frmTrangChu f = new frmTrangChu();
            f.strTenNhanVien = strTenNhanVien;
            f.flagHienThiMenu = flagHienThiMenu;
            f.strMaNhanVien = strMaNhanVien;
            f.ShowDialog();
            this.Close();
        }

        private void ganGiaTriLenComboboxMaNhanVien()
        {
            List<NhanVien> lstNhanVien = nhanVienService.layDanhSachQuyenHanNhanVien();
            foreach(NhanVien objNhanVien in lstNhanVien)
            {
                txtMaNhanVien.Items.Add(objNhanVien.MaNhanVien);
            }
            txtMaNhanVien.SelectedIndex = 0;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            disableView();
        }

        private void disableView()
        {
            txtMaHopDong.Enabled = false;
            txtCMND.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtSoNguoi.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void enableView()
        {
            txtMaHopDong.Enabled = true;
            txtCMND.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtSoNguoi.Enabled = true;
            txtMaNhanVien.Enabled = true;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            enableView();
        }
    }
}
