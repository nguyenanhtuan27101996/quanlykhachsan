using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Model
{
    class NhatKy
    {
        private int id;
        private string maHopDong;
        private string maPhong;
        private string cmnd;
        private string tenKhachHang;
        private int soNguoi;
        private DateTime ngayDatPhong;
        private DateTime ngayTraPhong;
        private float soTien;
        private string maNhanVien;

        public NhatKy()
        {
        }

        public NhatKy(int id, string maHopDong, string maPhong, string cmnd, string tenKhachHang, int soNguoi, DateTime ngayDatPhong, DateTime ngayTraPhong, float soTien, string maNhanVien)
        {
            this.Id = id;
            this.MaHopDong = maHopDong;
            this.MaPhong = maPhong;
            this.Cmnd = cmnd;
            this.TenKhachHang = tenKhachHang;
            this.SoNguoi = soNguoi;
            this.NgayDatPhong = ngayDatPhong;
            this.NgayTraPhong = ngayTraPhong;
            this.SoTien = soTien;
            this.MaNhanVien = maNhanVien;
        }

        public int Id { get => id; set => id = value; }
        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
        public float SoTien { get => soTien; set => soTien = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
