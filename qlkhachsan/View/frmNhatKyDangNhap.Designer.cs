namespace qlkhachsan.View
{
    partial class frmNhatKyDangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhatKyDangNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo mã nhân viên:\r\n";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoCompleteCustomSource.AddRange(new string[] {
            "14103100"});
            this.txtMaNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhanVien.Location = new System.Drawing.Point(242, 12);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(332, 20);
            this.txtMaNhanVien.TabIndex = 1;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhatKyDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // dgvNhatKyDangNhap
            // 
            this.dgvNhatKyDangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhatKyDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKyDangNhap.Location = new System.Drawing.Point(17, 19);
            this.dgvNhatKyDangNhap.Name = "dgvNhatKyDangNhap";
            this.dgvNhatKyDangNhap.Size = new System.Drawing.Size(574, 323);
            this.dgvNhatKyDangNhap.TabIndex = 0;
            // 
            // frmNhatKyDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "frmNhatKyDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký đăng nhập";
            this.Load += new System.EventHandler(this.frmNhatKyDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhatKyDangNhap;
    }
}