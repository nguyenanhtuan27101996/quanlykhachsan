namespace qlkhachsan.View
{
    partial class frmThoatTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDangXuatHet = new System.Windows.Forms.RadioButton();
            this.rdoDuyTriDangNhap = new System.Windows.Forms.RadioButton();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDuyTriDangNhap);
            this.groupBox1.Controls.Add(this.rdoDangXuatHet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn ";
            // 
            // rdoDangXuatHet
            // 
            this.rdoDangXuatHet.AutoSize = true;
            this.rdoDangXuatHet.Location = new System.Drawing.Point(20, 19);
            this.rdoDangXuatHet.Name = "rdoDangXuatHet";
            this.rdoDangXuatHet.Size = new System.Drawing.Size(182, 17);
            this.rdoDangXuatHet.TabIndex = 0;
            this.rdoDangXuatHet.TabStop = true;
            this.rdoDangXuatHet.Text = "Đăng xuất khỏi tất cả các thiết bị";
            this.rdoDangXuatHet.UseVisualStyleBackColor = true;
            // 
            // rdoDuyTriDangNhap
            // 
            this.rdoDuyTriDangNhap.AutoSize = true;
            this.rdoDuyTriDangNhap.Location = new System.Drawing.Point(20, 42);
            this.rdoDuyTriDangNhap.Name = "rdoDuyTriDangNhap";
            this.rdoDuyTriDangNhap.Size = new System.Drawing.Size(110, 17);
            this.rdoDuyTriDangNhap.TabIndex = 1;
            this.rdoDuyTriDangNhap.TabStop = true;
            this.rdoDuyTriDangNhap.Text = "Duy trì đăng nhập";
            this.rdoDuyTriDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(197, 91);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // frmThoatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmThoatTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDuyTriDangNhap;
        private System.Windows.Forms.RadioButton rdoDangXuatHet;
        private System.Windows.Forms.Button btnTiepTuc;
    }
}