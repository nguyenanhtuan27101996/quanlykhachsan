using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlkhachsan.Model;
using qlkhachsan.Repository;

namespace qlkhachsan.Service
{
    class NhanVienServiceImpl : NhanVienService
    {
        private NhanVienRepository nhanVienRepository = new NhanVienRepositoryImpl();
        public bool capNhatNhanVien(NhanVien objNhanVien)
        {
            return nhanVienRepository.capNhatNhanVien(objNhanVien);
        }

        public bool dangNhap(NhanVien objNhanVien)
        {
            return nhanVienRepository.dangNhap(objNhanVien);
        }

        public List<NhanVien> layDanhSachNhanVien()
        {
            return nhanVienRepository.layDanhSachNhanVien();
        }

        public List<NhanVien> layDanhSachQuyenHanNhanVien()
        {
            return nhanVienRepository.layDanhSachQuyenHanNhanVien();
        }

        public bool themNhanVien(NhanVien objNhanVien)
        {
            return nhanVienRepository.themNhanVien(objNhanVien);
        }

        public List<NhanVien> timKiemNhanVienTheoMa(string maNhanVien)
        {
            return nhanVienRepository.timKiemNhanVienTheoMa(maNhanVien);
        }

        public bool xoaNhanVien(string maNhanVien)
        {
            return nhanVienRepository.xoaNhanVien(maNhanVien);
        }
    }
}
