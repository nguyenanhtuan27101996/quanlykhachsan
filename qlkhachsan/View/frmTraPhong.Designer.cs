namespace qlkhachsan.View
{
    partial class frmTraPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.txtMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(105, 426);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Trả phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(186, 426);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hợp đồng: ";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Location = new System.Drawing.Point(135, 28);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(154, 20);
            this.txtMaHopDong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng: ";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(135, 65);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(135, 102);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(135, 138);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(154, 20);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(135, 173);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(80, 20);
            this.txtSoNguoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khách hàng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số người: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã nhân viên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày đặt phòng: ";
            // 
            // dtpNgayDatPhong
            // 
            this.dtpNgayDatPhong.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDatPhong.Location = new System.Drawing.Point(135, 212);
            this.dtpNgayDatPhong.Name = "dtpNgayDatPhong";
            this.dtpNgayDatPhong.Size = new System.Drawing.Size(165, 20);
            this.dtpNgayDatPhong.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày trả phòng: ";
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(135, 255);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(165, 20);
            this.dtpNgayTraPhong.TabIndex = 5;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaNhanVien.FormattingEnabled = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(135, 298);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(165, 21);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tiền thanh toán: ";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.Red;
            this.lblSoTien.Location = new System.Drawing.Point(131, 355);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(20, 24);
            this.lblSoTien.TabIndex = 13;
            this.lblSoTien.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoTien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayTraPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpNgayDatPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoNguoi);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHopDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 408);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 467);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayDatPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.ComboBox txtMaNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}