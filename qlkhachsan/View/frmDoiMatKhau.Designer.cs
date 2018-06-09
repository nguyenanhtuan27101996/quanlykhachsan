namespace qlkhachsan.View
{
    partial class frmDoiMatKhau
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
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblMaNhanVien.Location = new System.Drawing.Point(158, 31);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(60, 16);
            this.lblMaNhanVien.TabIndex = 1;
            this.lblMaNhanVien.Text = "Hiển thị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu hiện tại:";
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(161, 112);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.PasswordChar = '*';
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(123, 20);
            this.txtMatKhauHienTai.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(161, 155);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(123, 20);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(161, 199);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(123, 20);
            this.txtNhapLaiMatKhauMoi.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(209, 246);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(128, 246);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên nhân viên:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblTenNhanVien.Location = new System.Drawing.Point(158, 71);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(60, 16);
            this.lblTenNhanVien.TabIndex = 6;
            this.lblTenNhanVien.Text = "Hiển thị";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 292);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDoiMatKhau;
        public System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTenNhanVien;
    }
}