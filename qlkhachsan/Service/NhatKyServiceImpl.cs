using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlkhachsan.Model;
using qlkhachsan.Repository;

namespace qlkhachsan.Service
{
    class NhatKyServiceImpl : NhatKyService
    {
        private NhatKyRepository nhatKyRepository = new NhatKyRepositoryImpl();
        public List<NhatKy> layTatCaNhatKy()
        {
            return nhatKyRepository.layTatCaNhatKy();
        }

        public bool themNhatKy(NhatKy objNhatKy)
        {
            return nhatKyRepository.themNhatKy(objNhatKy);
        }

        public List<NhatKy> timNhatKyTheoMaHopDong(string maHopDong)
        {
            return nhatKyRepository.timNhatKyTheoMaHopDong(maHopDong);
        }

        public float tinhTienThuePhong(NhatKy objNhatKy)
        {
            return nhatKyRepository.tinhTienThuePhong(objNhatKy);
        }

        public bool xoaNhatKy(string maHopDong)
        {
            return nhatKyRepository.xoaNhatKy(maHopDong);
        }
    }
}
