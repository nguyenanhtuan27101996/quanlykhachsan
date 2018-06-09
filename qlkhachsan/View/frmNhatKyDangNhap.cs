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
    public partial class frmNhatKyDangNhap : Form
    {
        private NhatKyDangNhapService nhatKyDangNhapService = new NhatKyDangNhapServiceImpl();
        public frmNhatKyDangNhap()
        {
            InitializeComponent();
        }

        private void frmNhatKyDangNhap_Load(object sender, EventArgs e)
        {
            initData();
        }
        private void initData()
        {
            List<NhatKyDangNhap> lstNhatKyDangNhap = nhatKyDangNhapService.layDanhSachDangNhap();
            hienThiDuLieuLenDgv(lstNhatKyDangNhap);
        }
        private void hienThiDuLieuLenDgv(List<NhatKyDangNhap> lstNhatKyDangNhap)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã nhân viên");
            table.Columns.Add("Quyền hạn");
            table.Columns.Add("Họ tên");
            table.Columns.Add("Thời gian");
            foreach(var obj in lstNhatKyDangNhap)
            {
                table.Rows.Add(obj.MaNhanVien,obj.QuyenHan,obj.HoTen,
                    obj.ThoiGianDangNhap.ToString("dd/MM/yyyy hh:mm:ss tt"));
            }
            dgvNhatKyDangNhap.DataSource = table;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            List<NhatKyDangNhap> lstTimKiemNhatKyDangNhap = 
                nhatKyDangNhapService.timKiemTheoMaNhanVien(txtMaNhanVien.Text.Trim());
            hienThiDuLieuLenDgv(lstTimKiemNhatKyDangNhap);

        }
    }
}
