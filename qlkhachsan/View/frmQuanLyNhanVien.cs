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
    public partial class frmQuanLyNhanVien : Form
    {
        private NhanVienService nhanVienService = new NhanVienServiceImpl();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
            cboQuyenHan.SelectedIndex = 0;
            hienThiToanBoNhanVien();
        }
        private void hienThiToanBoNhanVien()
        {
            List<NhanVien> lstNhanVien = nhanVienService.layDanhSachNhanVien();
            hienThiDuLieuLenDgv(lstNhanVien);
        }
        private void hienThiDuLieuLenDgv(List<NhanVien> lstNhanVien)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã nhân viên");
            table.Columns.Add("Mật khẩu");
            table.Columns.Add("Quyền hạn");
            table.Columns.Add("Họ tên");

            foreach(var obj in lstNhanVien)
            {
                table.Rows.Add(obj.MaNhanVien, obj.MatKhau, obj.QuyenHan, obj.HoTen);
            }
            dgvNhanVien.DataSource = table;
        }

        private void resetTextBox()
        {
            txtMaNhanVien.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            resetTextBox();
        }

        private void txtTimKiemMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> lstNhanVien = nhanVienService.timKiemNhanVienTheoMa
                (txtTimKiemMaNhanVien.Text.Trim());
            hienThiDuLieuLenDgv(lstNhanVien);
        }
        private bool kiemTraNhapRong(string strMaNhanVien,string strMatKhau,
            string strHoTen)
        {
            if(strMaNhanVien.Equals("") || strMatKhau.Equals("")||
                strHoTen.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string strMaNhanVien = txtMaNhanVien.Text.Trim();
            string strMatKhau = txtMatKhau.Text.Trim();
            string strQuyenHan = cboQuyenHan.Text;
            string strHoTen = txtHoTen.Text.Trim();
            if (!kiemTraNhapRong(strMaNhanVien, strMatKhau, strHoTen))
            {
                MessageBox.Show("Nhập chưa đầy đủ !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NhanVien objNhanVien = new NhanVien
                  (strMaNhanVien, strMatKhau, strQuyenHan, strHoTen);

                if (nhanVienService.themNhanVien(objNhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiToanBoNhanVien();
                    resetTextBox();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công !",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string strMaNhanVien = txtMaNhanVien.Text.Trim();
            string strMatKhau = txtMatKhau.Text.Trim();
            string strQuyenHan = cboQuyenHan.Text;
            string strHoTen = txtHoTen.Text.Trim();

            if (!kiemTraNhapRong(strMaNhanVien, strMatKhau, strHoTen))
            {
                MessageBox.Show("Nhập chưa đầy đủ !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NhanVien objNhanVien = new NhanVien
               (strMaNhanVien, strMatKhau, strQuyenHan, strHoTen);
                if (nhanVienService.capNhatNhanVien(objNhanVien))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiToanBoNhanVien();
                    resetTextBox();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công !",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtMatKhau.Text= row.Cells[1].Value.ToString();
                cboQuyenHan.Text= row.Cells[2].Value.ToString();
                txtHoTen.Text= row.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strMaNhanVien = txtMaNhanVien.Text.Trim();
            if (nhanVienService.xoaNhanVien(strMaNhanVien))
            {
                MessageBox.Show("Xóa nhân viên thành công !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienThiToanBoNhanVien();
                resetTextBox();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên không thành công !",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
