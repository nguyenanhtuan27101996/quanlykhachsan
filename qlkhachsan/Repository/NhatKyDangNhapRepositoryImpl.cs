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
    class NhatKyDangNhapRepositoryImpl : NhatKyDangNhapRepository
    {
        public List<NhatKyDangNhap> layDanhSachDangNhap()
        {
            List<NhatKyDangNhap> lstNhatKyDangNhap = new List<NhatKyDangNhap>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,quyenhan,hoten,thoigian FROM nhatkydangnhap";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhatKyDangNhap objNhatKy = new NhatKyDangNhap();
                objNhatKy.MaNhanVien = reader["manhanvien"].ToString();
                objNhatKy.QuyenHan = reader["quyenhan"].ToString();
                objNhatKy.HoTen = reader["hoten"].ToString();
                objNhatKy.ThoiGianDangNhap = (DateTime)reader["thoigian"];
                
                lstNhatKyDangNhap.Add(objNhatKy);
            }
            conn.Close();

            return lstNhatKyDangNhap;
        }

        public bool themNhatKy(NhatKyDangNhap obj)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "INSERT INTO nhatkydangnhap VALUES('"
                + obj.MaNhanVien + "',N'"
                + obj.QuyenHan + "',N'"
                + obj.HoTen + "','"
                + obj.ThoiGianDangNhap + "')";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }

        public List<NhatKyDangNhap> timKiemTheoMaNhanVien(string maNhanVien)
        {
            List<NhatKyDangNhap> lstNhatKyDangNhap = new List<NhatKyDangNhap>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,quyenhan,hoten,thoigian FROM nhatkydangnhap WHERE manhanvien LIKE '%"+maNhanVien+"%'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhatKyDangNhap objNhatKy = new NhatKyDangNhap();
                objNhatKy.MaNhanVien = reader["manhanvien"].ToString();
                objNhatKy.QuyenHan = reader["quyenhan"].ToString();
                objNhatKy.HoTen = reader["hoten"].ToString();
                objNhatKy.ThoiGianDangNhap = (DateTime)reader["thoigian"];

                lstNhatKyDangNhap.Add(objNhatKy);
            }
            conn.Close();

            return lstNhatKyDangNhap;
        }
    }
}
