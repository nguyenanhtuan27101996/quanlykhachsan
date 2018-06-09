using qlkhachsan.Model;
using qlkhachsan.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlkhachsan.View
{
    public partial class frmDanhSachPhong : Form
    {
        private PhongService phongService = new PhongServiceImpl();
       
        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Enabled = false;
            txtTinhTrang.Enabled = false;
            disableView();
            hienThiTatCaPhong();
        }


        private void disableView()
        {
            txtTang.Enabled = false;
            txtLoaiPhong.Enabled = false;
            txtMoTa.Enabled = false;
            txtGiaTien.Enabled = false;
            btnCapNhat.Enabled = false;
            
        }
        private void enableView()
        {
            txtTang.Enabled = true;
            txtLoaiPhong.Enabled = true;
            txtMoTa.Enabled = true;
            txtGiaTien.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void rdoTatCaPhong_CheckedChanged(object sender, EventArgs e)
        {
            disableView();
            hienThiTatCaPhong();
        }

        private void rdoPhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            enableView();
            hienThiPhongTrong();
        }
        private void hienThiTatCaPhong()
        {
            List<Phong> lstPhong = phongService.layDanhSachTatCaPhong();
            hienThiDuLieuLenDgv(lstPhong);
        }
        private void hienThiPhongTrong()
        {
            List<Phong> lstPhong = phongService.layDanhSachPhongTrong();
            hienThiDuLieuLenDgv(lstPhong);
        }
        private void hienThiDuLieuLenDgv(List<Phong> lstPhong)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã phòng");
            table.Columns.Add("Tầng");
            table.Columns.Add("Loại phòng");
            table.Columns.Add("Mô tả");
            table.Columns.Add("Giá tiền");
            table.Columns.Add("Tình trạng");
            foreach(var obj in lstPhong)
            {
                table.Rows.Add(obj.MaPhong, obj.Tang, obj.LoaiPhong, obj.MoTa,
                    obj.GiaTien.ToString("#,###"), obj.TinhTrang);
            }
            dgvDanhSachPhong.DataSource = table;
        }

        private void txtTimMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (rdoTatCaPhong.Checked)
            {
                List<Phong> lstPhong = phongService.timPhongTheoMaPhong(
                    txtTimMaPhong.Text.Trim());
                hienThiDuLieuLenDgv(lstPhong);

            }
            else
            {
                List<Phong> lstPhong = phongService.timPhongTrongTheoMaPhong(
                   txtTimMaPhong.Text.Trim());
                hienThiDuLieuLenDgv(lstPhong);
            }
        }

        private void dgvDanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoPhongTrong.Checked)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvDanhSachPhong.Rows[e.RowIndex];
                    txtMaPhong.Text = row.Cells[0].Value.ToString();
                    txtTang.Text = row.Cells[1].Value.ToString();
                    txtLoaiPhong.Text = row.Cells[2].Value.ToString();
                    txtMoTa.Text = row.Cells[3].Value.ToString();
                    txtGiaTien.Text = row.Cells[4].Value.ToString();
                    txtTinhTrang.Text = row.Cells[5].Value.ToString();
                    
                }
                
                
            }
        }
        private bool kiemTraNhapRong(string strTang,string strLoaiPhong,
            string strMoTa,string strGiaTien)
        {
            if(strTang.Equals("") || strLoaiPhong.Equals("") ||
                strMoTa.Equals("") || strGiaTien.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!kiemTraNhapRong(txtTang.Text,txtLoaiPhong.Text,
                txtMoTa.Text, txtGiaTien.Text))
            {
                MessageBox.Show("Nhập chưa đầy đủ !",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string strMaPhong = txtMaPhong.Text;
                    int tang = int.Parse(txtTang.Text.Trim());
                    string strLoaiPhong = txtLoaiPhong.Text.Trim();
                    string strMoTa = txtMoTa.Text.Trim();
                    string strTinhTrang = txtTinhTrang.Text.Trim();
                    string strGiaTien = txtGiaTien.Text.Trim();
                    strGiaTien.Replace(",", "");
                    float giaTien = float.Parse(strGiaTien);

                    Phong objPhong = new Phong();
                    objPhong.MaPhong = strMaPhong;
                    objPhong.Tang = tang;
                    objPhong.LoaiPhong = strLoaiPhong;
                    objPhong.MoTa = strMoTa;
                    objPhong.GiaTien = giaTien;
                    if (phongService.capNhatThongTinPhong(objPhong))
                    {
                        MessageBox.Show("Cập nhật thông tin phòng thành công !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetTextBox();
                        hienThiPhongTrong();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin phòng không thành công !",
                           "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông tin nhập vào chưa đúng ! Nhập lại",
                           "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            

        }
        private void resetTextBox()
        {
            txtMaPhong.Clear();
            txtTang.Clear();
            txtLoaiPhong.Clear();
            txtMoTa.Clear();
            txtGiaTien.Clear();
            txtTimMaPhong.Clear();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
