using qlkhachsan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.Repository
{
    interface NhatKyRepository
    {
        List<NhatKy> layTatCaNhatKy();

        bool themNhatKy(NhatKy objNhatKy);

        bool xoaNhatKy(string maHopDong);

        List<NhatKy> timNhatKyTheoMaHopDong(string maHopDong);

        float tinhTienThuePhong(NhatKy objNhatKy);



    }
}
