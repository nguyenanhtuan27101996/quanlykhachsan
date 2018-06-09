using qlkhachsan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Service
{
    interface NhatKyDangNhapService
    {
        bool themNhatKy(NhatKyDangNhap obj);

        List<NhatKyDangNhap> layDanhSachDangNhap();

        List<NhatKyDangNhap> timKiemTheoMaNhanVien(string maNhanVien);
    }
}
