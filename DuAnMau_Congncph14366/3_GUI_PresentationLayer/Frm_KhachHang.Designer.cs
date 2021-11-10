
namespace _3_GUI_PresentationLayer
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_danhSach = new System.Windows.Forms.Button();
            this.btn_boQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenNhanVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgid_dataKH = new System.Windows.Forms.DataGridView();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataKH)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(28, 610);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 107);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.BackgroundImage")));
            this.btn_Dong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dong.Location = new System.Drawing.Point(949, 30);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(144, 57);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "        Quay Lại";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_danhSach
            // 
            this.btn_danhSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_danhSach.BackgroundImage")));
            this.btn_danhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_danhSach.Location = new System.Drawing.Point(770, 30);
            this.btn_danhSach.Name = "btn_danhSach";
            this.btn_danhSach.Size = new System.Drawing.Size(153, 57);
            this.btn_danhSach.TabIndex = 0;
            this.btn_danhSach.Text = "        Danh Sách";
            this.btn_danhSach.UseVisualStyleBackColor = true;
            // 
            // btn_boQua
            // 
            this.btn_boQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_boQua.BackgroundImage")));
            this.btn_boQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_boQua.Location = new System.Drawing.Point(609, 30);
            this.btn_boQua.Name = "btn_boQua";
            this.btn_boQua.Size = new System.Drawing.Size(135, 57);
            this.btn_boQua.TabIndex = 0;
            this.btn_boQua.Text = "         Bỏ Qua";
            this.btn_boQua.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Luu.BackgroundImage")));
            this.btn_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Luu.Location = new System.Drawing.Point(464, 30);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(119, 57);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "      Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sua.Location = new System.Drawing.Point(319, 30);
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
            this.btn_Xoa.Location = new System.Drawing.Point(174, 30);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 57);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "     Xóa";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_nu);
            this.groupBox2.Controls.Add(this.rdb_nam);
            this.groupBox2.Controls.Add(this.txt_maNV);
            this.groupBox2.Controls.Add(this.txt_tenKH);
            this.groupBox2.Controls.Add(this.txt_diaChi);
            this.groupBox2.Controls.Add(this.txt_SoDienThoai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_tenNhanVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(28, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(818, 112);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(61, 29);
            this.rdb_nu.TabIndex = 18;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(692, 112);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(75, 29);
            this.rdb_nam.TabIndex = 21;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_maNV.Location = new System.Drawing.Point(176, 153);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(345, 45);
            this.txt_maNV.TabIndex = 15;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenKH.Location = new System.Drawing.Point(176, 96);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(345, 45);
            this.txt_tenKH.TabIndex = 15;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diaChi.Location = new System.Drawing.Point(692, 27);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(345, 50);
            this.txt_diaChi.TabIndex = 16;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoDienThoai.Location = new System.Drawing.Point(176, 30);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(345, 45);
            this.txt_SoDienThoai.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số Điện Thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giới Tính : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Nhân Viên : ";
            // 
            // txt_tenNhanVien
            // 
            this.txt_tenNhanVien.AutoSize = true;
            this.txt_tenNhanVien.Location = new System.Drawing.Point(19, 110);
            this.txt_tenNhanVien.Name = "txt_tenNhanVien";
            this.txt_tenNhanVien.Size = new System.Drawing.Size(152, 25);
            this.txt_tenNhanVien.TabIndex = 13;
            this.txt_tenNhanVien.Text = "Tên Khách Hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa Chỉ : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgid_dataKH);
            this.groupBox1.Controls.Add(this.btn_timKiem);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Location = new System.Drawing.Point(28, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 374);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dgid_dataKH
            // 
            this.dgid_dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_dataKH.Location = new System.Drawing.Point(19, 96);
            this.dgid_dataKH.Name = "dgid_dataKH";
            this.dgid_dataKH.RowHeadersWidth = 62;
            this.dgid_dataKH.RowTemplate.Height = 33;
            this.dgid_dataKH.Size = new System.Drawing.Size(1075, 261);
            this.dgid_dataKH.TabIndex = 9;
            this.dgid_dataKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_dataKH_CellClick);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_timKiem.BackgroundImage")));
            this.btn_timKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_timKiem.Location = new System.Drawing.Point(954, 30);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(144, 60);
            this.btn_timKiem.TabIndex = 8;
            this.btn_timKiem.Text = "      Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timKiem.Location = new System.Drawing.Point(577, 34);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(345, 45);
            this.txt_timKiem.TabIndex = 7;
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 714);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_KhachHang";
            this.Text = "Frm_KhachHang";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_danhSach;
        private System.Windows.Forms.Button btn_boQua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_tenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgid_dataKH;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label2;
    }
}