using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Model
{
    class NhanVien
    {
        private string maNhanVien;
        private string matKhau;
        private string quyenHan;
        private string hoTen;

        public NhanVien()
        {
        }

        public NhanVien(string maNhanVien, string matKhau, string quyenHan, string hoTen)
        {
            this.MaNhanVien = maNhanVien;
            this.MatKhau = matKhau;
            this.QuyenHan = quyenHan;
            this.HoTen = hoTen;
        }

       

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string QuyenHan { get => quyenHan; set => quyenHan = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
    }
}
