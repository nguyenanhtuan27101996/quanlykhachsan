using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlkhachsan.DataAccess;
using qlkhachsan.Model;

namespace qlkhachsan.Repository
{
    class NhatKyRepositoryImpl : NhatKyRepository
    {
        private PhongRepository phongRepository = new PhongRepositoryImpl();

        public List<NhatKy> layTatCaNhatKy()
        {
            List<NhatKy> lstNhatKy = new List<NhatKy>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT mahopdong,maphong,cmnd,tenkhachhang,songuoi,ngaydatphong,ngaytraphong,sotien,manhanvien FROM nhatky";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhatKy objNhatKy = new NhatKy();
                objNhatKy.MaHopDong = reader["mahopdong"].ToString();
                objNhatKy.MaPhong = reader["maphong"].ToString();
                objNhatKy.Cmnd = reader["cmnd"].ToString();
                objNhatKy.TenKhachHang = reader["tenkhachhang"].ToString();
                objNhatKy.SoNguoi = (int)reader["songuoi"];
                objNhatKy.NgayDatPhong = (DateTime)reader["ngaydatphong"];
                objNhatKy.NgayTraPhong = (DateTime)reader["ngaytraphong"];
                // objNhatKy.SoTien = (float)reader.GetDouble(8);
                objNhatKy.SoTien = float.Parse(reader[7].ToString());
                objNhatKy.MaNhanVien = reader["manhanvien"].ToString();
                lstNhatKy.Add(objNhatKy);
            }
            conn.Close();

            return lstNhatKy;
        }

        public bool themNhatKy(NhatKy objNhatKy)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "INSERT INTO nhatky VALUES('"
                +objNhatKy.MaHopDong+"','"
                +objNhatKy.MaPhong+"','"
                +objNhatKy.Cmnd+"',N'"
                +objNhatKy.TenKhachHang+"','"
                +objNhatKy.SoNguoi+"','"
                +objNhatKy.NgayDatPhong+"','"
                +objNhatKy.NgayTraPhong+"','"
                +objNhatKy.SoTien+"','"
                +objNhatKy.MaNhanVien+"')";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }

        public List<NhatKy> timNhatKyTheoMaHopDong(string maHopDong)
        {
            List<NhatKy> lstNhatKy = new List<NhatKy>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT mahopdong,maphong,cmnd,tenkhachhang,songuoi,ngaydatphong,ngaytraphong,sotien,manhanvien FROM nhatky WHERE mahopdong LIKE '%"+maHopDong+"%'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhatKy objNhatKy = new NhatKy();
                objNhatKy.MaHopDong = reader["mahopdong"].ToString();
                objNhatKy.MaPhong = reader["maphong"].ToString();
                objNhatKy.Cmnd = reader["cmnd"].ToString();
                objNhatKy.TenKhachHang = reader["tenkhachhang"].ToString();
                objNhatKy.SoNguoi = (int)reader["songuoi"];
                objNhatKy.NgayDatPhong = (DateTime)reader["ngaydatphong"];
                objNhatKy.NgayTraPhong = (DateTime)reader["ngaytraphong"];
                //objNhatKy.SoTien = (float)reader.GetDouble(8);
                objNhatKy.SoTien = float.Parse(reader[7].ToString());
                objNhatKy.MaNhanVien = reader["manhanvien"].ToString();
                lstNhatKy.Add(objNhatKy);
            }
            conn.Close();

            return lstNhatKy;
        }

        public float tinhTienThuePhong(NhatKy objNhatKy)
        {
            float tienPhaiTra = 0;
            int soPhutThuePhong = 0;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT DATEDIFF(minute,'"
                +objNhatKy.NgayDatPhong+"','"+objNhatKy.NgayTraPhong+"')";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            soPhutThuePhong = (int)command.ExecuteScalar();
            
            conn.Close();
            List<Phong> lstPhong = phongRepository.timPhongTheoMaPhong(objNhatKy.MaPhong);
            float giaTienPhong = lstPhong[0].GiaTien;

            if (soPhutThuePhong < 1)
            {
                tienPhaiTra = (float)10000;
            }
            else
            {
                tienPhaiTra = (giaTienPhong / 60) * soPhutThuePhong;
            }
            
            
            

            return tienPhaiTra;
        }

        public bool xoaNhatKy(string maHopDong)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "DELETE FROM nhatky WHERE mahopdong='" + maHopDong + "'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }
    }
}
