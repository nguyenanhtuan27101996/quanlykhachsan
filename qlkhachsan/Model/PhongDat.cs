using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Model
{
    class PhongDat
    {
        private string maHopDong;
        private string maPhong;
        private string cmnd;
        private string tenKhachHang;
        private int soNguoi;
        private DateTime ngayDatPhong;
        private string maNhanVien;

        public PhongDat()
        {
        }

        public PhongDat(string maHopDong, string maPhong, string cmnd, string tenKhachHang, int soNguoi, DateTime ngayDatPhong, string maNhanVien)
        {
            this.MaHopDong = maHopDong;
            this.MaPhong = maPhong;
            this.Cmnd = cmnd;
            this.TenKhachHang = tenKhachHang;
            this.SoNguoi = soNguoi;
            this.NgayDatPhong = ngayDatPhong;
            this.MaNhanVien = maNhanVien;
        }

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
