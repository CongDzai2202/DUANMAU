
namespace _3_GUI_PresentationLayer
{
    partial class Frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_danhSach = new System.Windows.Forms.Button();
            this.btn_boQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_khongHoatDong = new System.Windows.Forms.CheckBox();
            this.cb_hoatDong = new System.Windows.Forms.CheckBox();
            this.rdb_quanTri = new System.Windows.Forms.RadioButton();
            this.rdb_nhanVien = new System.Windows.Forms.RadioButton();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgid_dataNV = new System.Windows.Forms.DataGridView();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 766);
            this.panel1.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(57, 624);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 107);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.BackgroundImage")));
            this.btn_Dong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dong.Location = new System.Drawing.Point(953, 30);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(145, 57);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "       Quay Lại";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_danhSach
            // 
            this.btn_danhSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_danhSach.BackgroundImage")));
            this.btn_danhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_danhSach.Location = new System.Drawing.Point(799, 30);
            this.btn_danhSach.Name = "btn_danhSach";
            this.btn_danhSach.Size = new System.Drawing.Size(148, 57);
            this.btn_danhSach.TabIndex = 0;
            this.btn_danhSach.Text = "       Danh Sách";
            this.btn_danhSach.UseVisualStyleBackColor = true;
            // 
            // btn_boQua
            // 
            this.btn_boQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_boQua.BackgroundImage")));
            this.btn_boQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_boQua.Location = new System.Drawing.Point(645, 30);
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
            this.btn_Luu.Location = new System.Drawing.Point(491, 30);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(119, 57);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "        Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sua.Location = new System.Drawing.Point(337, 30);
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
            this.btn_Xoa.Location = new System.Drawing.Point(183, 30);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 57);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "           Xóa";
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
            this.btn_Them.Text = "           Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.cb_khongHoatDong);
            this.groupBox2.Controls.Add(this.cb_hoatDong);
            this.groupBox2.Controls.Add(this.rdb_quanTri);
            this.groupBox2.Controls.Add(this.rdb_nhanVien);
            this.groupBox2.Controls.Add(this.txt_tenNV);
            this.groupBox2.Controls.Add(this.txt_diaChi);
            this.groupBox2.Controls.Add(this.txt_Email);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(57, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 232);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cb_khongHoatDong
            // 
            this.cb_khongHoatDong.AutoSize = true;
            this.cb_khongHoatDong.Location = new System.Drawing.Point(876, 172);
            this.cb_khongHoatDong.Name = "cb_khongHoatDong";
            this.cb_khongHoatDong.Size = new System.Drawing.Size(184, 29);
            this.cb_khongHoatDong.TabIndex = 23;
            this.cb_khongHoatDong.Text = "Không Hoạt Động";
            this.cb_khongHoatDong.UseVisualStyleBackColor = true;
            // 
            // cb_hoatDong
            // 
            this.cb_hoatDong.AutoSize = true;
            this.cb_hoatDong.Location = new System.Drawing.Point(698, 172);
            this.cb_hoatDong.Name = "cb_hoatDong";
            this.cb_hoatDong.Size = new System.Drawing.Size(127, 29);
            this.cb_hoatDong.TabIndex = 23;
            this.cb_hoatDong.Text = "Hoạt Động";
            this.cb_hoatDong.UseVisualStyleBackColor = true;
            // 
            // rdb_quanTri
            // 
            this.rdb_quanTri.AutoSize = true;
            this.rdb_quanTri.Location = new System.Drawing.Point(385, 168);
            this.rdb_quanTri.Name = "rdb_quanTri";
            this.rdb_quanTri.Size = new System.Drawing.Size(102, 29);
            this.rdb_quanTri.TabIndex = 18;
            this.rdb_quanTri.TabStop = true;
            this.rdb_quanTri.Text = "Quản Trị";
            this.rdb_quanTri.UseVisualStyleBackColor = true;
            // 
            // rdb_nhanVien
            // 
            this.rdb_nhanVien.AutoSize = true;
            this.rdb_nhanVien.Location = new System.Drawing.Point(176, 170);
            this.rdb_nhanVien.Name = "rdb_nhanVien";
            this.rdb_nhanVien.Size = new System.Drawing.Size(118, 29);
            this.rdb_nhanVien.TabIndex = 21;
            this.rdb_nhanVien.TabStop = true;
            this.rdb_nhanVien.Text = "Nhân Viên";
            this.rdb_nhanVien.UseVisualStyleBackColor = true;
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenNV.Location = new System.Drawing.Point(176, 96);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(345, 45);
            this.txt_tenNV.TabIndex = 15;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diaChi.Location = new System.Drawing.Point(692, 27);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(345, 50);
            this.txt_diaChi.TabIndex = 16;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(176, 30);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(345, 45);
            this.txt_Email.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vai Trò : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Nhân Viên : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trạng Thái : ";
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
            this.groupBox1.Controls.Add(this.dgid_dataNV);
            this.groupBox1.Controls.Add(this.btn_timKiem);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Location = new System.Drawing.Point(57, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dgid_dataNV
            // 
            this.dgid_dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_dataNV.Location = new System.Drawing.Point(23, 86);
            this.dgid_dataNV.Name = "dgid_dataNV";
            this.dgid_dataNV.RowHeadersWidth = 62;
            this.dgid_dataNV.RowTemplate.Height = 33;
            this.dgid_dataNV.Size = new System.Drawing.Size(1075, 239);
            this.dgid_dataNV.TabIndex = 9;
            this.dgid_dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_dataNV_CellClick);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_timKiem.BackgroundImage")));
            this.btn_timKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_timKiem.Location = new System.Drawing.Point(942, 21);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(156, 59);
            this.btn_timKiem.TabIndex = 8;
            this.btn_timKiem.Text = "        Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timKiem.Location = new System.Drawing.Point(586, 30);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(345, 45);
            this.txt_timKiem.TabIndex = 7;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 766);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_dataNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_danhSach;
        private System.Windows.Forms.Button btn_boQua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_quanTri;
        private System.Windows.Forms.RadioButton rdb_nhanVien;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgid_dataNV;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.CheckBox cb_khongHoatDong;
        private System.Windows.Forms.CheckBox cb_hoatDong;
    }
}