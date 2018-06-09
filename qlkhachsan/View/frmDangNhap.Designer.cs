namespace qlkhachsan.View
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboQuyenHan = new System.Windows.Forms.ComboBox();
            this.btnHienThiMatKhau = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên: ";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoCompleteCustomSource.AddRange(new string[] {
            "14103100330",
            "14103100331",
            "14103100332"});
            this.txtMaNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhanVien.Location = new System.Drawing.Point(266, 64);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(161, 20);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu: ";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(266, 104);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(161, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(8)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(180, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(352, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(266, 179);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlkhachsan.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quyền hạn: ";
            // 
            // cboQuyenHan
            // 
            this.cboQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyenHan.FormattingEnabled = true;
            this.cboQuyenHan.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên"});
            this.cboQuyenHan.Location = new System.Drawing.Point(266, 142);
            this.cboQuyenHan.Name = "cboQuyenHan";
            this.cboQuyenHan.Size = new System.Drawing.Size(161, 21);
            this.cboQuyenHan.TabIndex = 6;
            // 
            // btnHienThiMatKhau
            // 
            this.btnHienThiMatKhau.AutoSize = true;
            this.btnHienThiMatKhau.Location = new System.Drawing.Point(433, 107);
            this.btnHienThiMatKhau.Name = "btnHienThiMatKhau";
            this.btnHienThiMatKhau.Size = new System.Drawing.Size(43, 13);
            this.btnHienThiMatKhau.TabIndex = 7;
            this.btnHienThiMatKhau.TabStop = true;
            this.btnHienThiMatKhau.Text = "Hiển thị";
            this.btnHienThiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHienThiMatKhau_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(485, 233);
            this.Controls.Add(this.btnHienThiMatKhau);
            this.Controls.Add(this.cboQuyenHan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboQuyenHan;
        private System.Windows.Forms.LinkLabel btnHienThiMatKhau;
    }
}