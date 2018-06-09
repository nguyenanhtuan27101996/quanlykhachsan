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
    class PhongDatRepositoryImpl : PhongDatRepository
    {
        public bool datPhong(PhongDat objPhongDat)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "INSERT INTO phongdat VALUES('"
                +objPhongDat.MaHopDong+"','"
                +objPhongDat.MaPhong+"','"
                +objPhongDat.Cmnd+"',N'"
                +objPhongDat.TenKhachHang+"','"
                +objPhongDat.SoNguoi+"','"
                +objPhongDat.NgayDatPhong+"','"
                +objPhongDat.MaNhanVien+"')";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }

        public List<PhongDat> layDanhSachPhongDat()
        {
            List<PhongDat> lstPhongDat = new List<PhongDat>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT mahopdong,maphong,cmnd,tenkhachhang,songuoi,ngaydatphong,manhanvien FROM phongdat";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhongDat objPhongDat = new PhongDat();
                objPhongDat.MaHopDong = reader["mahopdong"].ToString();
                objPhongDat.MaPhong = reader["maphong"].ToString();
                objPhongDat.Cmnd = reader["cmnd"].ToString();
                objPhongDat.TenKhachHang = reader["tenkhachhang"].ToString();
                objPhongDat.SoNguoi = (int)reader["songuoi"];
                objPhongDat.NgayDatPhong = (DateTime)reader["ngaydatphong"];
                objPhongDat.MaNhanVien = reader["manhanvien"].ToString();

                lstPhongDat.Add(objPhongDat);
            }
            conn.Close();
            return lstPhongDat;
        }

        public List<PhongDat> timKiemPhongDatTheoMaHD(string maHopDong)
        {
            List<PhongDat> lstPhongDat = new List<PhongDat>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT mahopdong,maphong,cmnd,tenkhachhang,songuoi,ngaydatphong,manhanvien FROM phongdat WHERE mahopdong LIKE '%"+maHopDong+"%'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhongDat objPhongDat = new PhongDat();
                objPhongDat.MaHopDong = reader["mahopdong"].ToString();
                objPhongDat.MaPhong = reader["maphong"].ToString();
                objPhongDat.Cmnd = reader["cmnd"].ToString();
                objPhongDat.TenKhachHang = reader["tenkhachhang"].ToString();
                objPhongDat.SoNguoi = (int)reader["songuoi"];
                objPhongDat.NgayDatPhong = (DateTime)reader["ngaydatphong"];
                objPhongDat.MaNhanVien = reader["manhanvien"].ToString();

                lstPhongDat.Add(objPhongDat);
            }
            conn.Close();
            return lstPhongDat;
        }

        public List<PhongDat> timKiemPhongDatTheoMaPhong(string maPhong)
        {
            List<PhongDat> lstPhongDat = new List<PhongDat>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT mahopdong,maphong,cmnd,tenkhachhang,songuoi,ngaydatphong,manhanvien FROM phongdat WHERE maphong='" + maPhong + "'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhongDat objPhongDat = new PhongDat();
                objPhongDat.MaHopDong = reader["mahopdong"].ToString();
                objPhongDat.MaPhong = reader["maphong"].ToString();
                objPhongDat.Cmnd = reader["cmnd"].ToString();
                objPhongDat.TenKhachHang = reader["tenkhachhang"].ToString();
                objPhongDat.SoNguoi = (int)reader["songuoi"];
                objPhongDat.NgayDatPhong = (DateTime)reader["ngaydatphong"];
                objPhongDat.MaNhanVien = reader["manhanvien"].ToString();

                lstPhongDat.Add(objPhongDat);
            }
            conn.Close();
            return lstPhongDat;
        }

        public bool xoaPhongDat(string maHopDong)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "DELETE FROM phongdat WHERE mahopdong='" + maHopDong + "'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }
    }
}
