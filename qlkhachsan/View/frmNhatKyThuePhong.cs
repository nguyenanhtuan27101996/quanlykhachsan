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
    public partial class frmNhatKyThuePhong : Form
    {
        private PhongDatService phongDatService = new PhongDatServiceImpl();
        public frmNhatKyThuePhong()
        {
            InitializeComponent();
        }

        private void frmNhatKyThuePhong_Load(object sender, EventArgs e)
        {
            List<PhongDat> lstPhongDat = phongDatService.layDanhSachPhongDat();
            hienThiDuLieuLenDgv(lstPhongDat);
        }

        private void hienThiDuLieuLenDgv(List<PhongDat>lstPhongDat)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã hợp đồng");
            table.Columns.Add("Mã phòng");
            table.Columns.Add("CMND");
            table.Columns.Add("Tên khách hàng");
            table.Columns.Add("Số người");
            table.Columns.Add("Ngày đặt phòng");
            table.Columns.Add("Mã nhân viên");

            foreach(var obj in lstPhongDat)
            {
                table.Rows.Add(obj.MaHopDong, obj.MaPhong, obj.Cmnd,
                    obj.TenKhachHang, obj.SoNguoi,
                    obj.NgayDatPhong.ToString("dd/MM/yyyy hh:mm:ss tt"),
                    obj.MaNhanVien);
            }
            dgvNhatKyThuePhong.DataSource = table;
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            List<PhongDat> lstPhongDat = phongDatService.timKiemPhongDatTheoMaHD(txtMaPhong.Text.Trim());
            hienThiDuLieuLenDgv(lstPhongDat);
        }
    }
}
