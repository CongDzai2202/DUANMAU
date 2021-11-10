using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_KhachHang : Form
    {
        private IQLKhachHang _iQLKhachHang;
        private ICheck _iCheck;
        private string flagstring;
        public int quyen;
       
        public Frm_KhachHang()
        {
            _iQLKhachHang = new QLKhachHang();
            _iCheck = new Check();
            InitializeComponent();
            LoadData();
        }
        bool Checkk()
        {
            if (_iCheck.checkNull(txt_SoDienThoai.Text))
            {
                MessageBox.Show(" Tên Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_maNV.Text))
            {
                MessageBox.Show(" Email Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_tenKH.Text))
            {
                MessageBox.Show(" Email Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }

            if (_iCheck.checkNull(txt_diaChi.Text))
            {
                MessageBox.Show(" Địa Chỉ Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }

            if (_iCheck.checkNumber(txt_SoDienThoai.Text))
            {
                MessageBox.Show(" Số Điện Thoại Phải Nhập Số", "Thông Báo");
                return false;
            }

            if (_iCheck.checkString(txt_tenKH.Text))
            {
                MessageBox.Show("Tên Nhân Viên Phải Viết Chữ \n Không Được Nhập Số", "Thông Báo");
                return false;
            }
            return true;
        }
        void LoadData()
        {
            _iQLKhachHang = new QLKhachHang();
            dgid_dataKH.ColumnCount = 10;
            dgid_dataKH.Columns[0].Name = "Số Điện Thoại";
            dgid_dataKH.Columns[1].Name = "Mã Nhân Viên";
            dgid_dataKH.Columns[2].Name = "Tên Khách Hàng";
            dgid_dataKH.Columns[3].Name = "Dịa Chỉ";
            dgid_dataKH.Columns[4].Name = "Giới Tính";
            dgid_dataKH.Rows.Clear();
            if (_iQLKhachHang.GetLstHangs().Count < 0) return;
            foreach (var x in _iQLKhachHang.GetLstHangs())
            {
                dgid_dataKH.Rows.Add(x.Sodienthoai, x.Manv, x.Tenkhach, x.Diachi, x.Phai);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (Checkk() == false)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Khachhang kh = new Khachhang();
                    kh.Sodienthoai = txt_SoDienThoai.Text;
                    kh.Manv = txt_maNV.Text;
                    kh.Tenkhach = txt_tenKH.Text;
                    kh.Diachi = txt_diaChi.Text;
                    kh.Phai = rdb_nam.Checked ? "Nam" : "Nữ";
                    MessageBox.Show(_iQLKhachHang.AddHang(kh), "Thông Báo");
                    _iQLKhachHang.GetLstHangs();
                    LoadData();
                }
            }
        }
        private void dgid_dataKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == _iQLKhachHang.GetLstHangs().Count || RowIndex == -1) return;
            txt_SoDienThoai.Text = dgid_dataKH.Rows[RowIndex].Cells[0].Value.ToString();
            txt_maNV.Text = dgid_dataKH.Rows[RowIndex].Cells[1].Value.ToString();
            txt_tenKH.Text = dgid_dataKH.Rows[RowIndex].Cells[2].Value.ToString();
            txt_diaChi.Text = dgid_dataKH.Rows[RowIndex].Cells[3].Value.ToString();
            rdb_nam.Checked = dgid_dataKH.Rows[RowIndex].Cells[4].Value.ToString()=="Nam"?true:false;
            rdb_nu.Checked = dgid_dataKH.Rows[RowIndex].Cells[4].Value.ToString()=="Nữ"?true:false;
            flagstring = dgid_dataKH.Rows[RowIndex].Cells[0].Value.ToString();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQLKhachHang.DeleteHang(txt_SoDienThoai.Text), "Thông Báo");
            _iQLKhachHang.GetLstHangs();
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (Checkk() == false)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Khachhang kh = new Khachhang();
                    kh.Sodienthoai = txt_SoDienThoai.Text;
                    kh.Manv = txt_maNV.Text;
                    kh.Tenkhach = txt_tenKH.Text;
                    kh.Diachi = txt_diaChi.Text;
                    kh.Phai = rdb_nam.Checked ? "Nam" : "Nữ";
                    MessageBox.Show(_iQLKhachHang.UpdateHang(kh), "Thông Báo");
                    _iQLKhachHang.GetLstHangs();
                    LoadData();
                }
            }
        }
        
        public void Quyen(int t)
        {
            quyen = t;
            quyen = t;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (quyen == 1)
            {
                Frm_GiaoDienChinh gdChinh = new Frm_GiaoDienChinh();
                this.Hide();
                gdChinh.Show();
            }
            else
            {
                Frm_GiaoDienND gd = new Frm_GiaoDienND();
                this.Hide();
                gd.Show();
            }
        }
        void LoadDataTK(string acc)
        {
            _iQLKhachHang = new QLKhachHang();
            dgid_dataKH.ColumnCount = 10;
            dgid_dataKH.Columns[0].Name = "Số Điện Thoại";
            dgid_dataKH.Columns[1].Name = "Mã Nhân Viên";
            dgid_dataKH.Columns[2].Name = "Tên Khách Hàng";
            dgid_dataKH.Columns[3].Name = "Dịa Chỉ";
            dgid_dataKH.Columns[4].Name = "Giới Tính";
            dgid_dataKH.Rows.Clear();
            if (_iQLKhachHang.GetLstHangs().Count < 0) return;
            foreach (var x in _iQLKhachHang.GetLstHangs().Where(c=>c.Sodienthoai == txt_timKiem.Text))
            {
                dgid_dataKH.Rows.Add(x.Sodienthoai, x.Manv, x.Tenkhach, x.Diachi, x.Phai);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            _iQLKhachHang = new QLKhachHang();
            dgid_dataKH.Rows.Clear();
            if (_iQLKhachHang.GetLstHangs().Count < 0) return;
            foreach (var x in _iQLKhachHang.GetLstHangs().Where(c => c.Sodienthoai == txt_timKiem.Text))
            {
                dgid_dataKH.Rows.Add(x.Sodienthoai, x.Manv, x.Tenkhach, x.Diachi, x.Phai);
            }
        }
    }
}
