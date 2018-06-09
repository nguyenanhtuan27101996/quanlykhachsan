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
    class PhongRepositoryImpl : PhongRepository
    {
        public bool capNhatThongTinPhong(Phong objPhong)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "UPDATE phong SET tang='"
                +objPhong.Tang+"',loaiphong=N'"
                +objPhong.LoaiPhong+"',mota=N'"
                +objPhong.MoTa+"',giatien=N'"
                +objPhong.GiaTien+"'WHERE maphong='"+objPhong.MaPhong+"'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();

            return isSuccess;
        }

        public bool capNhatTinhTrangPhong(Phong objPhong)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "UPDATE phong SET tinhtrang=N'"
                + objPhong.TinhTrang + "'WHERE maphong='" + objPhong.MaPhong + "'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();

            return isSuccess;
        }

        public int demSoPhongConTrong()
        {
            int ketQua = 0;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT COUNT (tinhtrang) FROM phong WHERE tinhtrang=N'Trống'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            ketQua = (int)command.ExecuteScalar();

            conn.Close();

            return ketQua;
        }
        
        public int demSoPhongDuocThue()
        {
            int ketQua = 0;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT COUNT (tinhtrang) FROM phong WHERE tinhtrang=N'Đang được thuê'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            ketQua = (int)command.ExecuteScalar();

            conn.Close();

            return ketQua;
        }

        public List<Phong> layDanhSachPhongTrong()
        {
            List<Phong> lstPhongTrong = new List<Phong>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT maphong,tang,loaiphong,mota,giatien,tinhtrang FROM phong WHERE tinhtrang=N'Trống'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Phong objPhong = new Phong();
                objPhong.MaPhong = reader["maphong"].ToString();
                objPhong.Tang = (int)reader["tang"];
                objPhong.LoaiPhong = reader["loaiphong"].ToString();
                objPhong.MoTa = reader["mota"].ToString();
                objPhong.GiaTien = (float)reader.GetDouble(4);
                objPhong.TinhTrang = reader["tinhtrang"].ToString();
                lstPhongTrong.Add(objPhong);
            }
            conn.Close();
            
            return lstPhongTrong;
        }

        public List<Phong> layDanhSachTatCaPhong()
        {
            List<Phong> lstPhong = new List<Phong>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT maphong,tang,loaiphong,mota,giatien,tinhtrang FROM phong";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Phong objPhong = new Phong();
                objPhong.MaPhong = reader["maphong"].ToString();
                objPhong.Tang = (int) reader["tang"];
                objPhong.LoaiPhong = reader["loaiphong"].ToString();
                objPhong.MoTa = reader["mota"].ToString();
                objPhong.GiaTien =(float)reader.GetDouble(4);
                objPhong.TinhTrang = reader["tinhtrang"].ToString();
                lstPhong.Add(objPhong);
            }
            conn.Close();

            return lstPhong;
        }

       

        public List<Phong> timPhongTheoMaPhong(string maPhong)
        {
            List<Phong> lstPhong = new List<Phong>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT maphong,tang,loaiphong,mota,giatien,tinhtrang FROM phong WHERE maphong LIKE'%"+maPhong+"%'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Phong objPhong = new Phong();
                objPhong.MaPhong = reader["maphong"].ToString();
                objPhong.Tang = (int)reader["tang"];
                objPhong.LoaiPhong = reader["loaiphong"].ToString();
                objPhong.MoTa = reader["mota"].ToString();
                objPhong.GiaTien = (float)reader.GetDouble(4);
                objPhong.TinhTrang = reader["tinhtrang"].ToString();
                lstPhong.Add(objPhong);
            }
            conn.Close();

            return lstPhong;
        }

        public List<Phong> timPhongTrongTheoMaPhong(string maPhong)
        {
            List<Phong> lstPhong = new List<Phong>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT maphong,tang,loaiphong,mota,giatien,tinhtrang FROM phong WHERE maphong LIKE'%" + maPhong + "%' AND tinhtrang=N'Trống'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Phong objPhong = new Phong();
                objPhong.MaPhong = reader["maphong"].ToString();
                objPhong.Tang = (int)reader["tang"];
                objPhong.LoaiPhong = reader["loaiphong"].ToString();
                objPhong.MoTa = reader["mota"].ToString();
                objPhong.GiaTien = (float)reader.GetDouble(4);
                objPhong.TinhTrang = reader["tinhtrang"].ToString();
                lstPhong.Add(objPhong);
            }
            conn.Close();

            return lstPhong;
        }
    }
}
