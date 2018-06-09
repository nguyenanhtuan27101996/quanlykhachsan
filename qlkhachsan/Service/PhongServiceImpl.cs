using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlkhachsan.Model;
using qlkhachsan.Repository;

namespace qlkhachsan.Service
{
    class PhongServiceImpl : PhongService
    {
        private PhongRepository phongRepository = new PhongRepositoryImpl();
        public bool capNhatThongTinPhong(Phong objPhong)
        {
            return phongRepository.capNhatThongTinPhong(objPhong);
        }

        public bool capNhatTinhTrangPhong(Phong objPhong)
        {
            return phongRepository.capNhatTinhTrangPhong(objPhong);
        }

        public int demSoPhongConTrong()
        {
            return phongRepository.demSoPhongConTrong();
        }

        public int demSoPhongDuocThue()
        {
            return phongRepository.demSoPhongDuocThue();
        }

        public List<Phong> layDanhSachPhongTrong()
        {
            return phongRepository.layDanhSachPhongTrong();
        }

        public List<Phong> layDanhSachTatCaPhong()
        {
            return phongRepository.layDanhSachTatCaPhong();
        }

        public List<Phong> timPhongTheoMaPhong(string maPhong)
        {
            return phongRepository.timPhongTheoMaPhong(maPhong);
        }

        public List<Phong> timPhongTrongTheoMaPhong(string maPhong)
        {
            return phongRepository.timPhongTrongTheoMaPhong(maPhong);
        }
    }
}
