using qlkhachsan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Service
{
    interface NhanVienService
    {
        List<NhanVien> layDanhSachNhanVien();

        bool themNhanVien(NhanVien objNhanVien);

        bool capNhatNhanVien(NhanVien objNhanVien);

        bool xoaNhanVien(string maNhanVien);

        List<NhanVien> timKiemNhanVienTheoMa(string maNhanVien);

        bool dangNhap(NhanVien objNhanVien);

        List<NhanVien> layDanhSachQuyenHanNhanVien();
    }
}
