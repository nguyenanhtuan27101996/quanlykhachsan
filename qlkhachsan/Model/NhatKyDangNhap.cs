using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Model
{
    class NhatKyDangNhap
    {
        private int id;
        private string maNhanVien;
        private string quyenHan;
        private string hoTen;
        private DateTime thoiGianDangNhap;

        public NhatKyDangNhap()
        {
        }

        public NhatKyDangNhap(int id, string maNhanVien, string quyenHan, string hoTen, DateTime thoiGianDangNhap)
        {
            this.Id = id;
            this.MaNhanVien = maNhanVien;
            this.QuyenHan = quyenHan;
            this.HoTen = hoTen;
            this.ThoiGianDangNhap = thoiGianDangNhap;
        }

        public int Id { get => id; set => id = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string QuyenHan { get => quyenHan; set => quyenHan = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime ThoiGianDangNhap { get => thoiGianDangNhap; set => thoiGianDangNhap = value; }
    }
}
