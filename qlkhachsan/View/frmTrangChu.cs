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
    public partial class frmTrangChu : Form
    {
        private PhongDatService phongDatService = new PhongDatServiceImpl();
        private PhongService phongService = new PhongServiceImpl();
        public  string strTenNhanVien = "";
        public bool flagHienThiMenu;
        public string strMaNhanVien = "";
        #region khai bao cac bien trang thai
        private bool flag101;
        private bool flag102;
        private bool flag103;
        private bool flag104;
        private bool flag105;
        private bool flag106;
        private bool flag107;
        private bool flag108;
        private bool flag201;
        private bool flag202;
        private bool flag203;
        private bool flag204;
        private bool flag205;
        private bool flag206;
        private bool flag207;
        private bool flag208;
        private bool flag301;
        private bool flag302;
        private bool flag303;
        private bool flag304;
        private bool flag305;
        private bool flag306;
        private bool flag307;
        private bool flag308;
        private bool flag401;
        private bool flag402;
        private bool flag403;
        private bool flag404;
        private bool flag405;
        private bool flag406;
        private bool flag407;
        private bool flag408;
        private bool flag501;
        private bool flag502;
        private bool flag503;
        private bool flag504;
        private bool flag505;
        private bool flag506;
        private bool flag507;
        private bool flag508;
        #endregion 
        public frmTrangChu()
        {
            InitializeComponent();
            
        }
        private void displayMenuQuanLy()
        {
            if (flagHienThiMenu == false)
            {
                menuQuanLy.Enabled = false;
            }
            else
            {
                menuQuanLy.Enabled = true;
            }
        }
        private void pb101_Click(object sender, EventArgs e)
        {
            datPhong(flag101, lbl101.Text);
        }
        private void datPhong(bool flag,string text)
        {
            if (flag == false)
            {
                frmDatPhong f = new frmDatPhong();
                f.txtMaPhong.Text = text;
                this.Hide();
                f.strTenNhanVien = strTenNhanVien;
                f.flagHienThiMenu = flagHienThiMenu;
                f.strMaNhanVien = strMaNhanVien;
                f.ShowDialog();
                this.Close();
                if (f.kiemTraAnNut == true)
                {
                    
                    flag = true;
                }
                else
                {
                    f.flagHienThiMenu = flagHienThiMenu;
                    return;
                }
            }
            else
            {
                frmTraPhong f = new frmTraPhong();
                f.txtMaPhong.Text = text;
                this.Hide();
                f.strTenNhanVien = strTenNhanVien;
                f.flagHienThiMenu = flagHienThiMenu;
                f.strMaNhanVien = strMaNhanVien;
                f.ShowDialog();
                this.Close();

                if (f.kiemTraAnNut == true)
                {

                    flag = false;
                }
                else
                {
                    f.flagHienThiMenu = flagHienThiMenu;
                    return;
                }

            }
        }
        private bool kiemTraTrangThaiPhong(string maPhong)
        {
            List<PhongDat> lstPhongDat = phongDatService.layDanhSachPhongDat();
            foreach (PhongDat objPhongDat in lstPhongDat)
            {
                if (objPhongDat.MaPhong.Equals(maPhong))
                {
                    return true;
                }
            }
            return false;
        }
        
        
        private void initForm()
        {
            #region khoi tao cho tang 1
            flag101 = kiemTraTrangThaiPhong(lbl101.Text);
            initImageForPictureBox(flag101, pb101);
            flag102 = kiemTraTrangThaiPhong(lbl102.Text);
            initImageForPictureBox(flag102, pb102);
            flag103 = kiemTraTrangThaiPhong(lbl103.Text);
            initImageForPictureBox(flag103, pb103);
            flag104 = kiemTraTrangThaiPhong(lbl104.Text);
            initImageForPictureBox(flag104, pb104);
            flag105 = kiemTraTrangThaiPhong(lbl105.Text);
            initImageForPictureBox(flag105, pb105);
            flag106 = kiemTraTrangThaiPhong(lbl106.Text);
            initImageForPictureBox(flag106, pb106);
            flag107 = kiemTraTrangThaiPhong(lbl107.Text);
            initImageForPictureBox(flag107, pb107);
            flag108 = kiemTraTrangThaiPhong(lbl108.Text);
            initImageForPictureBox(flag108, pb108);
            #endregion

            #region khoi tao cho tang 2
            flag201 = kiemTraTrangThaiPhong(lbl201.Text);
            initImageForPictureBox(flag201, pb201);
            flag202 = kiemTraTrangThaiPhong(lbl202.Text);
            initImageForPictureBox(flag202, pb202);
            flag203 = kiemTraTrangThaiPhong(lbl203.Text);
            initImageForPictureBox(flag203, pb203);
            flag204 = kiemTraTrangThaiPhong(lbl204.Text);
            initImageForPictureBox(flag204, pb204);
            flag205 = kiemTraTrangThaiPhong(lbl205.Text);
            initImageForPictureBox(flag205, pb205);
            flag206 = kiemTraTrangThaiPhong(lbl206.Text);
            initImageForPictureBox(flag206, pb206);
            flag207 = kiemTraTrangThaiPhong(lbl207.Text);
            initImageForPictureBox(flag207, pb207);
            flag208 = kiemTraTrangThaiPhong(lbl208.Text);
            initImageForPictureBox(flag208, pb208);
            #endregion

            #region khoi tao cho tang 3
            flag301 = kiemTraTrangThaiPhong(lbl301.Text);
            initImageForPictureBox(flag301, pb301);
            flag302 = kiemTraTrangThaiPhong(lbl302.Text);
            initImageForPictureBox(flag302, pb302);
            flag303 = kiemTraTrangThaiPhong(lbl303.Text);
            initImageForPictureBox(flag303, pb303);
            flag304 = kiemTraTrangThaiPhong(lbl304.Text);
            initImageForPictureBox(flag304, pb304);
            flag305 = kiemTraTrangThaiPhong(lbl305.Text);
            initImageForPictureBox(flag305, pb305);
            flag306 = kiemTraTrangThaiPhong(lbl306.Text);
            initImageForPictureBox(flag306, pb306);
            flag307 = kiemTraTrangThaiPhong(lbl307.Text);
            initImageForPictureBox(flag307, pb307);
            flag308 = kiemTraTrangThaiPhong(lbl308.Text);
            initImageForPictureBox(flag308, pb308);
            #endregion

            #region khoi tao cho tang 4
            flag401 = kiemTraTrangThaiPhong(lbl401.Text);
            initImageForPictureBox(flag401, pb401);
            flag402 = kiemTraTrangThaiPhong(lbl402.Text);
            initImageForPictureBox(flag402, pb402);
            flag403 = kiemTraTrangThaiPhong(lbl403.Text);
            initImageForPictureBox(flag403, pb403);
            flag404 = kiemTraTrangThaiPhong(lbl404.Text);
            initImageForPictureBox(flag404, pb404);
            flag405 = kiemTraTrangThaiPhong(lbl405.Text);
            initImageForPictureBox(flag405, pb405);
            flag406 = kiemTraTrangThaiPhong(lbl406.Text);
            initImageForPictureBox(flag406, pb406);
            flag407 = kiemTraTrangThaiPhong(lbl407.Text);
            initImageForPictureBox(flag407, pb407);
            flag408 = kiemTraTrangThaiPhong(lbl408.Text);
            initImageForPictureBox(flag408, pb408);
            #endregion

            #region khoi tao cho tang 5
            flag501 = kiemTraTrangThaiPhong(lbl501.Text);
            initImageForPictureBox(flag501, pb501);
            flag502 = kiemTraTrangThaiPhong(lbl502.Text);
            initImageForPictureBox(flag502, pb502);
            flag503 = kiemTraTrangThaiPhong(lbl503.Text);
            initImageForPictureBox(flag503, pb503);
            flag504 = kiemTraTrangThaiPhong(lbl504.Text);
            initImageForPictureBox(flag504, pb504);
            flag505 = kiemTraTrangThaiPhong(lbl505.Text);
            initImageForPictureBox(flag505, pb505);
            flag506 = kiemTraTrangThaiPhong(lbl506.Text);
            initImageForPictureBox(flag506, pb506);
            flag507 = kiemTraTrangThaiPhong(lbl507.Text);
            initImageForPictureBox(flag507, pb507);
            flag508 = kiemTraTrangThaiPhong(lbl508.Text);
            initImageForPictureBox(flag508, pb508);
            #endregion
        }
        private void initImageForPictureBox(bool flag, PictureBox pb)
        {
            if (flag == false)
            {
                pb.Image = qlkhachsan.Properties.Resources.ready;
            }
            else
            {
                pb.Image = qlkhachsan.Properties.Resources.booking;
            }
        
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            initForm();
            hienThiDgvDanhSachPhong();
            hienThiDgvPhongDangThue();
            hienThiTinhTrangPhongLenLabel();
            lblTenNhanVien.Text = strTenNhanVien;
            displayMenuQuanLy();
        }

        private void hienThiTinhTrangPhongLenLabel()
        {
            int soPhongTrong = phongService.demSoPhongConTrong();
            int soPhongDangThue = phongService.demSoPhongDuocThue();
            lblSoPhongConTrong.Text = "" + soPhongTrong;
            lblSoPhongDaDuocThue.Text = "" + soPhongDangThue;
        }
        private void hienThiDgvDanhSachPhong()
        {
            List<Phong> lstPhong = phongService.layDanhSachTatCaPhong();
            DataTable table = new DataTable();
            table.Columns.Add("Mã phòng");
            table.Columns.Add("Tình trạng");
            foreach(var obj in lstPhong)
            {
                table.Rows.Add(obj.MaPhong, obj.TinhTrang);
            }
            dgvTatCaPhong.DataSource = table;
           
        }
        private void hienThiDgvPhongDangThue()
        {
            List<PhongDat> lstPhongDat = phongDatService.layDanhSachPhongDat();
            DataTable table = new DataTable();
            table.Columns.Add("Mã phòng");
            table.Columns.Add("Khách hàng");
            foreach (var obj in lstPhongDat)
            {
                table.Rows.Add(obj.MaPhong, obj.TenKhachHang);
            }
            dgvPhongDangDuocThue.DataSource = table;
        }
        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void pb102_Click(object sender, EventArgs e)
        {
            datPhong(flag102, lbl102.Text);
        }

        private void pb103_Click(object sender, EventArgs e)
        {
            datPhong(flag103, lbl103.Text);
        }

        private void pb104_Click(object sender, EventArgs e)
        {
            datPhong(flag104, lbl104.Text);
        }

        private void pb105_Click(object sender, EventArgs e)
        {
            datPhong(flag105, lbl105.Text);
        }

        private void pb106_Click(object sender, EventArgs e)
        {
            datPhong(flag106, lbl106.Text);
        }

        private void pb107_Click(object sender, EventArgs e)
        {
            datPhong(flag107, lbl107.Text);
        }

        private void pb108_Click(object sender, EventArgs e)
        {
            datPhong(flag108, lbl108.Text);
        }

        private void pb201_Click(object sender, EventArgs e)
        {
            datPhong(flag201, lbl201.Text);
        }

        private void pb202_Click(object sender, EventArgs e)
        {
            datPhong(flag202, lbl202.Text);
        }

        private void pb203_Click(object sender, EventArgs e)
        {
            datPhong(flag203, lbl203.Text);
        }

        private void pb204_Click(object sender, EventArgs e)
        {
            datPhong(flag204, lbl204.Text);
        }

        private void pb205_Click(object sender, EventArgs e)
        {
            datPhong(flag205, lbl205.Text);
        }

        private void pb206_Click(object sender, EventArgs e)
        {
            datPhong(flag206, lbl206.Text);
        }

        private void pb207_Click(object sender, EventArgs e)
        {
            datPhong(flag207, lbl207.Text);
        }

        private void pb208_Click(object sender, EventArgs e)
        {
            datPhong(flag208, lbl208.Text);
        }

        private void pb301_Click(object sender, EventArgs e)
        {
            datPhong(flag301, lbl301.Text);
        }

        private void pb302_Click(object sender, EventArgs e)
        {
            datPhong(flag302, lbl302.Text);
        }

        private void pb303_Click(object sender, EventArgs e)
        {
            datPhong(flag303, lbl303.Text);
        }

        private void pb304_Click(object sender, EventArgs e)
        {
            datPhong(flag304, lbl304.Text);
        }

        private void pb305_Click(object sender, EventArgs e)
        {
            datPhong(flag305, lbl305.Text);
        }

        private void pb306_Click(object sender, EventArgs e)
        {
            datPhong(flag306, lbl306.Text);
        }

        private void pb307_Click(object sender, EventArgs e)
        {
            datPhong(flag307, lbl307.Text);
        }

        private void pb308_Click(object sender, EventArgs e)
        {
            datPhong(flag308, lbl308.Text);
        }

        private void pb401_Click(object sender, EventArgs e)
        {
            datPhong(flag401, lbl401.Text);
        }

        private void pb402_Click(object sender, EventArgs e)
        {
            datPhong(flag402, lbl402.Text);
        }

        private void pb403_Click(object sender, EventArgs e)
        {
            datPhong(flag403, lbl403.Text);
        }

        private void pb404_Click(object sender, EventArgs e)
        {
            datPhong(flag404, lbl404.Text);
        }

        private void pb405_Click(object sender, EventArgs e)
        {
            datPhong(flag405, lbl405.Text);
        }

        private void pb406_Click(object sender, EventArgs e)
        {
            datPhong(flag406, lbl406.Text);
        }

        private void pb407_Click(object sender, EventArgs e)
        {
            datPhong(flag407, lbl407.Text);
        }

        private void pb408_Click(object sender, EventArgs e)
        {
            datPhong(flag408, lbl408.Text);
        }

        private void pb501_Click(object sender, EventArgs e)
        {
            datPhong(flag501, lbl501.Text);
        }

        private void pb502_Click(object sender, EventArgs e)
        {
            datPhong(flag502, lbl502.Text);
        }

        private void pb503_Click(object sender, EventArgs e)
        {
            datPhong(flag503, lbl503.Text);
        }

        private void pb504_Click(object sender, EventArgs e)
        {
            datPhong(flag504, lbl504.Text);
        }

        private void pb505_Click(object sender, EventArgs e)
        {
            datPhong(flag505, lbl505.Text);
        }

        private void pb506_Click(object sender, EventArgs e)
        {
            datPhong(flag506, lbl506.Text);
        }

        private void pb507_Click(object sender, EventArgs e)
        {
            datPhong(flag507, lbl507.Text);
        }

        private void pb508_Click(object sender, EventArgs e)
        {
            datPhong(flag508, lbl508.Text);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var userChoice = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không ?",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (userChoice == DialogResult.OK)
            {
                string strThoiGianHienTai = 
                    DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                MessageBox.Show("Đăng xuất thành công lúc " + strThoiGianHienTai, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
                this.Close();
            }
           
        }

        private void btnNhatKyDangNhap_Click(object sender, EventArgs e)
        {
            frmNhatKyDangNhap f = new frmNhatKyDangNhap();
            f.ShowDialog();
        }

        private void btnNhatKyTra_Click(object sender, EventArgs e)
        {
            frmNhatKyTraPhong f = new frmNhatKyTraPhong();
            f.ShowDialog();
        }

        private void btnNhatKyThue_Click(object sender, EventArgs e)
        {
            frmNhatKyThuePhong f = new frmNhatKyThuePhong();
            f.ShowDialog();
        }

        private void btnDanhSachPhong_Click(object sender, EventArgs e)
        {
            frmDanhSachPhong f = new frmDanhSachPhong();
            f.ShowDialog();
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            f.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.lblMaNhanVien.Text = strMaNhanVien;
            f.lblTenNhanVien.Text = strTenNhanVien;
            f.ShowDialog();
        }
    }
}
