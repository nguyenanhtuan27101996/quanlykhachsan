using qlkhachsan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Service
{
    interface PhongDatService
    {
        bool datPhong(PhongDat objPhongDat);

        List<PhongDat> layDanhSachPhongDat();

        bool xoaPhongDat(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaHD(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaPhong(string maPhong);
    }
}
