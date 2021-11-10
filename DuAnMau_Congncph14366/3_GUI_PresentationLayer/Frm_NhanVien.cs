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
    public partial class Frm_NhanVien : Form
    {
        private IQLNhanVien _iQlNhanVien;
        private ICheck _iCheck;
        private string flag;
        Frm_DangNhap dn = new Frm_DangNhap();


        public Frm_NhanVien()
        { 
            _iQlNhanVien = new QLNhanVien();
            _iCheck = new Check();
            InitializeComponent();
            LoadData();
        }

        bool Checkk()
        {
            if (_iCheck.checkNull(txt_tenNV.Text))
            {
                MessageBox.Show( " Tên Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_Email.Text))
            {
                MessageBox.Show(" Email Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_diaChi.Text))
            {
                MessageBox.Show(" Địa Chỉ Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }

            if (_iCheck.checkString(txt_tenNV.Text) )
            {
                MessageBox.Show("Tên Nhân Viên Phải Viết Chữ \n Không Được Nhập Số", "Thông Báo");
                return false;
            }
            return true;
        }

        public void LoadData()
        {
            _iQlNhanVien = new QLNhanVien();
            dgid_dataNV.ColumnCount = 10;
            dgid_dataNV.Columns[0].Name = "Tên Nhân Viên";
            dgid_dataNV.Columns[1].Name = "Email";
            dgid_dataNV.Columns[2].Name = "Địa Chỉ";
            dgid_dataNV.Columns[3].Name = "Vai Trò";
            dgid_dataNV.Columns[4].Name = "Tình Trạng";
            dgid_dataNV.Columns[5].Name = "ID";
            dgid_dataNV.Columns[5].Visible = false;
            dgid_dataNV.Rows.Clear();
            if(_iQlNhanVien.GetListNV().Count<0) return;
            foreach (var x in _iQlNhanVien.GetListNV())
            {
                dgid_dataNV.Rows.Add(x.Tennv, x.Email, x.Diachi, x.Vaitro == 1 ?"Quản lý":"Nhân Viên", x.Tinhtrang==1?"Hoạt Động":"Không Hoạt Động");
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
                    try
                    {
                        Nhanvien nv = new Nhanvien();
                        nv.Email = txt_Email.Text;
                        nv.Tennv = txt_tenNV.Text;
                        nv.Matkhau = dn.Encrypt("1");
                        nv.Vaitro = rdb_nhanVien.Checked == true ? 0:1;
                        //nv.Vaitro = Convert.ToInt32(rdb_quanTri.Checked == false);
                        nv.Diachi = txt_diaChi.Text;
                        nv.Tinhtrang = Convert.ToInt32(cb_hoatDong.Checked == true);
                        _iQlNhanVien.AddNhanVien(nv);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadData();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Mã Nhân Viên Trùng");
                    }
                }
            }

        }

        

        private void dgid_dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == _iQlNhanVien.GetListNV().Count || RowIndex == -1) return;
            
            txt_Email.Text = dgid_dataNV.Rows[RowIndex].Cells[1].Value.ToString();
            txt_tenNV.Text = dgid_dataNV.Rows[RowIndex].Cells[0].Value.ToString();
            txt_diaChi.Text = dgid_dataNV.Rows[RowIndex].Cells[2].Value.ToString();
            rdb_nhanVien.Checked = dgid_dataNV.Rows[RowIndex].Cells[3].Value.ToString() == "Nhân Viên" ? true : false;
            rdb_quanTri.Checked = dgid_dataNV.Rows[RowIndex].Cells[3].Value.ToString() == "Quản Trị" ? true : false;
            cb_hoatDong.Checked =dgid_dataNV.Rows[RowIndex].Cells[4].Value.ToString() == "Hoạt Động" ? true : false;
            cb_khongHoatDong.Checked =dgid_dataNV.Rows[RowIndex].Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false;
            flag = _iQlNhanVien.GetListNV().Where(c => c.Email == txt_Email.Text).Select(c => c.Manv).FirstOrDefault();
            

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
                    Nhanvien nv = new Nhanvien();
                    nv.Manv = flag;
                    nv.Email = txt_Email.Text;
                    nv.Tennv = txt_tenNV.Text;
                    nv.Diachi = txt_diaChi.Text;
                    nv.Vaitro = rdb_nhanVien.Checked==true ? 0:1;
                    nv.Tinhtrang = cb_hoatDong.Checked ? 1 : 2;
                    nv.Matkhau = dn.Encrypt("1");
                    _iQlNhanVien.GetListNV();
                    _iQlNhanVien.UpdateNhanVien(nv);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    LoadData();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var id = _iQlNhanVien.GetListNV().Where(c => c.Manv == flag).Select(c => c.Manv).FirstOrDefault();
                    _iQlNhanVien.DeleteNhanVien(id);
                    MessageBox.Show("Xóa Thành Công", "Thông báo");
                    _iQlNhanVien.GetListNV();
                    LoadData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Mã Nhân Viên Đang Liên Quan Bảng Sản Phẩm Và Bảng Khách Hàng","Thông Báo");
                }
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Frm_GiaoDienChinh gdChinh = new Frm_GiaoDienChinh();
            this.Hide();
            gdChinh.Show();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            
            dgid_dataNV.Rows.Clear();
            if (_iQlNhanVien.GetListNV().Count < 0) return;
            foreach (var x in _iQlNhanVien.GetListNV().Where(c => c.Manv == txt_timKiem.Text))
            {
                dgid_dataNV.Rows.Add(x.Tennv, x.Email, x.Diachi, x.Vaitro == 1 ? "Nhân Viên" : x.Vaitro == 2 ? "Trưởng Phòng" : "Giám Đốc", x.Tinhtrang == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
