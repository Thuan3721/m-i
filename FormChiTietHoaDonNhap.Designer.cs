namespace baidaynay
{
    partial class FormChiTietHoaDonNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvChitiethoadonnhap = new DataGridView();
            bttThem = new Button();
            bttSua = new Button();
            bttThoat = new Button();
            txtIDThuoc = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGiaNhap = new TextBox();
            txtThanhTien = new TextBox();
            txtGhiChu = new TextBox();
            bttXoa = new Button();
            txtMaHDN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvChitiethoadonnhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 38);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Hóa Đơn Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 91);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "MaHDN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 151);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "IDThuoc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 214);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 87);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn Giá Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 151);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Thành Tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 211);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 6;
            label7.Text = "Ghi Chú";
            // 
            // dgvChitiethoadonnhap
            // 
            dgvChitiethoadonnhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChitiethoadonnhap.Location = new Point(67, 271);
            dgvChitiethoadonnhap.Name = "dgvChitiethoadonnhap";
            dgvChitiethoadonnhap.Size = new Size(644, 150);
            dgvChitiethoadonnhap.TabIndex = 7;
            dgvChitiethoadonnhap.CellClick += dgvChitiethoadonnhap_CellClick;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(77, 471);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(75, 33);
            bttThem.TabIndex = 8;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // bttSua
            // 
            bttSua.Location = new Point(242, 469);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 33);
            bttSua.TabIndex = 9;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // bttThoat
            // 
            bttThoat.Location = new Point(576, 469);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(75, 33);
            bttThoat.TabIndex = 10;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = true;
            bttThoat.Click += bttThoat_Click;
            // 
            // txtIDThuoc
            // 
            txtIDThuoc.Location = new Point(180, 148);
            txtIDThuoc.Name = "txtIDThuoc";
            txtIDThuoc.Size = new Size(100, 27);
            txtIDThuoc.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(180, 211);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 27);
            txtSoLuong.TabIndex = 13;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(592, 84);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(100, 27);
            txtDonGiaNhap.TabIndex = 14;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(592, 148);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(100, 27);
            txtThanhTien.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(592, 211);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(100, 27);
            txtGhiChu.TabIndex = 16;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(402, 473);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 29);
            bttXoa.TabIndex = 17;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // txtMaHDN
            // 
            txtMaHDN.Location = new Point(180, 84);
            txtMaHDN.Name = "txtMaHDN";
            txtMaHDN.Size = new Size(100, 27);
            txtMaHDN.TabIndex = 18;
            // 
            // FormChiTietHoaDonNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(txtMaHDN);
            Controls.Add(bttXoa);
            Controls.Add(txtGhiChu);
            Controls.Add(txtThanhTien);
            Controls.Add(txtDonGiaNhap);
            Controls.Add(txtSoLuong);
            Controls.Add(txtIDThuoc);
            Controls.Add(bttThoat);
            Controls.Add(bttSua);
            Controls.Add(bttThem);
            Controls.Add(dgvChitiethoadonnhap);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChiTietHoaDonNhap";
            Text = "FormChiTietHoaDonNhap";
            Load += FormChiTietHoaDonNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChitiethoadonnhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvChitiethoadonnhap;
        private Button bttThem;
        private Button bttSua;
        private Button bttThoat;
        private TextBox txtIDThuoc;
        private TextBox txtSoLuong;
        private TextBox txtDonGiaNhap;
        private TextBox txtThanhTien;
        private TextBox txtGhiChu;
        private Button bttXoa;
        private TextBox txtMaHDN;
    }
}