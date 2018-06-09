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
    class NhanVienRepositoryImpl : NhanVienRepository
    {
        public bool capNhatNhanVien(NhanVien objNhanVien)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "UPDATE nhanvien SET matkhau=N'"
                +objNhanVien.MatKhau+"',quyenhan=N'"
                +objNhanVien.QuyenHan+"',hoten=N'"
                +objNhanVien.HoTen+"'WHERE manhanvien='"+objNhanVien.MaNhanVien+"'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
            
        }

        public bool dangNhap(NhanVien objNhanVien)
        {
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,matkhau,quyenhan,hoten FROM nhanvien WHERE manhanvien='"
                +objNhanVien.MaNhanVien+"'AND matkhau='"
                +objNhanVien.MatKhau+"'AND quyenhan=N'"
                +objNhanVien.QuyenHan+"'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien objNhanVien1 = new NhanVien();
                objNhanVien1.MaNhanVien = reader["manhanvien"].ToString();
                objNhanVien1.MatKhau = reader["matkhau"].ToString();
                objNhanVien1.QuyenHan = reader["quyenhan"].ToString();
                objNhanVien1.HoTen = reader["hoten"].ToString();
                lstNhanVien.Add(objNhanVien1);
            }
            isSuccess = lstNhanVien.Count() > 0;
            conn.Close();
            return isSuccess;
           
        }

        public List<NhanVien> layDanhSachNhanVien()
        {
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,matkhau,quyenhan,hoten FROM nhanvien";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien objNhanVien = new NhanVien();
                objNhanVien.MaNhanVien = reader["manhanvien"].ToString();
                objNhanVien.MatKhau = reader["matkhau"].ToString();
                objNhanVien.QuyenHan = reader["quyenhan"].ToString();
                objNhanVien.HoTen = reader["hoten"].ToString();
                lstNhanVien.Add(objNhanVien);
            }
            conn.Close();
            return lstNhanVien;
           
        }

        public List<NhanVien> layDanhSachQuyenHanNhanVien()
        {
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,matkhau,quyenhan,hoten FROM nhanvien WHERE quyenhan=N'Nhân viên'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien objNhanVien = new NhanVien();
                objNhanVien.MaNhanVien = reader["manhanvien"].ToString();
                objNhanVien.MatKhau = reader["matkhau"].ToString();
                objNhanVien.QuyenHan = reader["quyenhan"].ToString();
                objNhanVien.HoTen = reader["hoten"].ToString();
                lstNhanVien.Add(objNhanVien);
            }
            conn.Close();
            return lstNhanVien;
        }

        public bool themNhanVien(NhanVien objNhanVien)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "INSERT INTO nhanvien VALUES(N'"
                + objNhanVien.MaNhanVien + "',N'" + objNhanVien.MatKhau
                + "',N'" + objNhanVien.QuyenHan + "',N'"
                + objNhanVien.HoTen + "')";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }

        public List<NhanVien> timKiemNhanVienTheoMa(string maNhanVien)
        {
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "SELECT manhanvien,matkhau,quyenhan,hoten FROM nhanvien WHERE manhanvien LIKE'%"+maNhanVien+"%'";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(strQuery, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien objNhanVien = new NhanVien();
                objNhanVien.MaNhanVien = reader["manhanvien"].ToString();
                objNhanVien.MatKhau = reader["matkhau"].ToString();
                objNhanVien.QuyenHan = reader["quyenhan"].ToString();
                objNhanVien.HoTen = reader["hoten"].ToString();
                lstNhanVien.Add(objNhanVien);
            }
            conn.Close();
            return lstNhanVien;
        }

        public bool xoaNhanVien(string maNhanVien)
        {
            bool isSuccess = false;
            SqlConnection conn = null;
            conn = DataAccessConnection.getConnection();
            conn.Open();
            string strQuery = "DELETE FROM nhanvien WHERE manhanvien='"+maNhanVien+"'";
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;
            isSuccess = command.ExecuteNonQuery() > 0;

            conn.Close();
            return isSuccess;
        }
    }
}
