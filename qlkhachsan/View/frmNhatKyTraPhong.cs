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
    public partial class frmNhatKyTraPhong : Form
    {
        private NhatKyService nhatKyService = new NhatKyServiceImpl();
        public frmNhatKyTraPhong()
        {
            InitializeComponent();
        }

        private void frmNhatKyTraPhong_Load(object sender, EventArgs e)
        {
            List<NhatKy> lstNhatKy = nhatKyService.layTatCaNhatKy();
            hienThiDuLieuLenDgv(lstNhatKy);
        }
        private void hienThiDuLieuLenDgv(List<NhatKy> lstNhatKy)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã hợp đồng");
            table.Columns.Add("Mã phòng");
            table.Columns.Add("CMND");
            table.Columns.Add("Tên khách hàng");
            table.Columns.Add("Số người");
            table.Columns.Add("Ngày đặt phòng");
            table.Columns.Add("Ngày trả phòng");
            table.Columns.Add("Số tiền");
            table.Columns.Add("Mã nhân viên");

            foreach(NhatKy obj in lstNhatKy)
            {
                table.Rows.Add(obj.MaHopDong, obj.MaPhong,
                    obj.Cmnd, obj.TenKhachHang, obj.SoNguoi.ToString(),
                    obj.NgayDatPhong.ToString("dd/MM/yyyy hh:mm:ss tt"),
                    obj.NgayTraPhong.ToString("dd/MM/yyyy hh:mm:ss tt"),
                    obj.SoTien.ToString("#,###"),
                    obj.MaNhanVien);
            }
            
            dgvNhatKyTra.DataSource = table;
        }

        private void txtMaHopDong_TextChanged(object sender, EventArgs e)
        {
            List<NhatKy> lstNhatKy = nhatKyService.timNhatKyTheoMaHopDong(txtMaHopDong.Text.Trim());
            hienThiDuLieuLenDgv(lstNhatKy);
        }
    }
}
