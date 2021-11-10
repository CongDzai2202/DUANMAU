
namespace _3_GUI_PresentationLayer
{
    partial class Frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_anh = new System.Windows.Forms.Button();
            this.ptb_anh = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_donGiaXuat = new System.Windows.Forms.TextBox();
            this.txt_donGiaNhap = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.txt_maHang = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_danhSach = new System.Windows.Forms.Button();
            this.btn_boQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgid_dataSP = new System.Windows.Forms.DataGridView();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.cmb_maNV = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 766);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_maNV);
            this.groupBox2.Controls.Add(this.btn_anh);
            this.groupBox2.Controls.Add(this.ptb_anh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_donGiaXuat);
            this.groupBox2.Controls.Add(this.txt_donGiaNhap);
            this.groupBox2.Controls.Add(this.txt_soLuong);
            this.groupBox2.Controls.Add(this.txt_tenHang);
            this.groupBox2.Controls.Add(this.txt_ghiChu);
            this.groupBox2.Controls.Add(this.txt_hinhanh);
            this.groupBox2.Controls.Add(this.txt_maHang);
            this.groupBox2.Location = new System.Drawing.Point(36, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 340);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btn_anh
            // 
            this.btn_anh.Location = new System.Drawing.Point(614, 81);
            this.btn_anh.Name = "btn_anh";
            this.btn_anh.Size = new System.Drawing.Size(103, 39);
            this.btn_anh.TabIndex = 11;
            this.btn_anh.Text = "Chọn Ảnh";
            this.btn_anh.UseVisualStyleBackColor = true;
            this.btn_anh.Click += new System.EventHandler(this.btn_anh_Click);
            // 
            // ptb_anh
            // 
            this.ptb_anh.Location = new System.Drawing.Point(755, 30);
            this.ptb_anh.Name = "ptb_anh";
            this.ptb_anh.Size = new System.Drawing.Size(318, 243);
            this.ptb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_anh.TabIndex = 10;
            this.ptb_anh.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn Giá Xuất : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn Giá Nhập : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Hàng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Hàng : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã NV : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ghi Chú : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hình Ảnh : ";
            // 
            // txt_donGiaXuat
            // 
            this.txt_donGiaXuat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_donGiaXuat.Location = new System.Drawing.Point(159, 285);
            this.txt_donGiaXuat.Name = "txt_donGiaXuat";
            this.txt_donGiaXuat.Size = new System.Drawing.Size(271, 45);
            this.txt_donGiaXuat.TabIndex = 7;
            // 
            // txt_donGiaNhap
            // 
            this.txt_donGiaNhap.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_donGiaNhap.Location = new System.Drawing.Point(159, 234);
            this.txt_donGiaNhap.Name = "txt_donGiaNhap";
            this.txt_donGiaNhap.Size = new System.Drawing.Size(271, 45);
            this.txt_donGiaNhap.TabIndex = 7;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soLuong.Location = new System.Drawing.Point(159, 183);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(271, 45);
            this.txt_soLuong.TabIndex = 7;
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenHang.Location = new System.Drawing.Point(159, 132);
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.Size = new System.Drawing.Size(271, 45);
            this.txt_tenHang.TabIndex = 7;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ghiChu.Location = new System.Drawing.Point(549, 217);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(168, 45);
            this.txt_ghiChu.TabIndex = 7;
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hinhanh.Location = new System.Drawing.Point(549, 30);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(168, 45);
            this.txt_hinhanh.TabIndex = 7;
            // 
            // txt_maHang
            // 
            this.txt_maHang.Enabled = false;
            this.txt_maHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_maHang.Location = new System.Drawing.Point(159, 30);
            this.txt_maHang.Name = "txt_maHang";
            this.txt_maHang.Size = new System.Drawing.Size(271, 45);
            this.txt_maHang.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Dong);
            this.groupBox3.Controls.Add(this.btn_danhSach);
            this.groupBox3.Controls.Add(this.btn_boQua);
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Location = new System.Drawing.Point(36, 645);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 107);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.BackgroundImage")));
            this.btn_Dong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dong.Location = new System.Drawing.Point(954, 30);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(150, 57);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "       Quay Lại";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_danhSach
            // 
            this.btn_danhSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_danhSach.BackgroundImage")));
            this.btn_danhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_danhSach.Location = new System.Drawing.Point(774, 30);
            this.btn_danhSach.Name = "btn_danhSach";
            this.btn_danhSach.Size = new System.Drawing.Size(153, 57);
            this.btn_danhSach.TabIndex = 0;
            this.btn_danhSach.Text = "       Danh Sách";
            this.btn_danhSach.UseVisualStyleBackColor = true;
            // 
            // btn_boQua
            // 
            this.btn_boQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_boQua.BackgroundImage")));
            this.btn_boQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_boQua.Location = new System.Drawing.Point(613, 30);
            this.btn_boQua.Name = "btn_boQua";
            this.btn_boQua.Size = new System.Drawing.Size(134, 57);
            this.btn_boQua.TabIndex = 0;
            this.btn_boQua.Text = "        Bỏ Qua";
            this.btn_boQua.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Luu.BackgroundImage")));
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Luu.Location = new System.Drawing.Point(467, 30);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(119, 57);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "         Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sua.Location = new System.Drawing.Point(321, 30);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 57);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "       Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Xoa.Location = new System.Drawing.Point(175, 30);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 57);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "       Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Them.Location = new System.Drawing.Point(29, 30);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 57);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "         Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgid_dataSP);
            this.groupBox1.Controls.Add(this.btn_timKiem);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Location = new System.Drawing.Point(36, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 297);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dgid_dataSP
            // 
            this.dgid_dataSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_dataSP.Location = new System.Drawing.Point(23, 86);
            this.dgid_dataSP.Name = "dgid_dataSP";
            this.dgid_dataSP.RowHeadersWidth = 62;
            this.dgid_dataSP.RowTemplate.Height = 33;
            this.dgid_dataSP.Size = new System.Drawing.Size(1075, 197);
            this.dgid_dataSP.TabIndex = 9;
            this.dgid_dataSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_dataSP_CellClick);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_timKiem.BackgroundImage")));
            this.btn_timKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_timKiem.Location = new System.Drawing.Point(954, 21);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(144, 59);
            this.btn_timKiem.TabIndex = 8;
            this.btn_timKiem.Text = "       Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timKiem.Location = new System.Drawing.Point(566, 30);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(345, 45);
            this.txt_timKiem.TabIndex = 7;
            // 
            // cmb_maNV
            // 
            this.cmb_maNV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_maNV.FormattingEnabled = true;
            this.cmb_maNV.Location = new System.Drawing.Point(159, 81);
            this.cmb_maNV.Name = "cmb_maNV";
            this.cmb_maNV.Size = new System.Drawing.Size(271, 46);
            this.cmb_maNV.TabIndex = 12;
            this.cmb_maNV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 766);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_SanPham";
            this.Text = "Frm_SanPham";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_danhSach;
        private System.Windows.Forms.Button btn_boQua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgid_dataSP;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_donGiaXuat;
        private System.Windows.Forms.TextBox txt_donGiaNhap;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_tenHang;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.PictureBox ptb_anh;
        private System.Windows.Forms.Button btn_anh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maHang;
        private System.Windows.Forms.ComboBox cmb_maNV;
    }
}