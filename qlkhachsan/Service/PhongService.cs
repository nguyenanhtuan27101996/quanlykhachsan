using qlkhachsan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Service
{
    interface PhongService
    {
        List<Phong> layDanhSachTatCaPhong();

        List<Phong> layDanhSachPhongTrong();

        int demSoPhongConTrong();

        int demSoPhongDuocThue();

        List<Phong> timPhongTheoMaPhong(string maPhong);

        bool capNhatThongTinPhong(Phong objPhong);

        bool capNhatTinhTrangPhong(Phong objPhong);

        List<Phong> timPhongTrongTheoMaPhong(string maPhong);

    }
}
