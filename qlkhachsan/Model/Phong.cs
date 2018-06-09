using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Model
{
    class Phong
    {
        private string maPhong;
        private int tang;
        private string loaiPhong;
        private string moTa;
        private float giaTien;
        private string tinhTrang;

        public Phong()
        {
        }

        public Phong(string maPhong, int tang, string loaiPhong, string moTa, float giaTien, string tinhTrang)
        {
            this.MaPhong = maPhong;
            this.Tang = tang;
            this.LoaiPhong = loaiPhong;
            this.MoTa = moTa;
            this.GiaTien = giaTien;
            this.TinhTrang = tinhTrang;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
