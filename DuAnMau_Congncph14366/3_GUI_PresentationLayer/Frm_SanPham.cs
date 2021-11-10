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
    public partial class Frm_SanPham : Form
    {
        private string _imageLocation = "";
        private OpenFileDialog _OpenFileDialog = new OpenFileDialog();
        private IQLSanPham _iQLSanPham;
        private IQLNhanVien _iQLNhanVien;
        private int flagint;
        private string flagstring;
        private string _hang;
        private ICheck _iCheck;
        public int quyen;
        public string MaNVDN;
        public Frm_SanPham()
        {
            _iQLNhanVien = new QLNhanVien();
            _iQLSanPham = new QLSanPham();
            _iCheck = new Check();
            InitializeComponent();
            LoadData();
            LoadCMB();
        }
        void LoadCMB()
        {
            foreach (var x in _iQLNhanVien.GetListNV().ToList())
            {
                cmb_maNV.Items.Add(x.Manv);

            }
            cmb_maNV.SelectedIndex = 0;
        }
        bool Checkk()
        {
            if (_iCheck.checkNull(cmb_maNV.Text))
            {
                MessageBox.Show(" Mã Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_tenHang.Text))
            {
                MessageBox.Show(" Tên Hàng Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_ghiChu.Text))
            {
                MessageBox.Show(" Ghi Chú Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_donGiaNhap.Text))
            {
                MessageBox.Show(" Đơn Giá Nhập Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_donGiaXuat.Text))
            {
                MessageBox.Show(" Đơn Giá Xuất Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNull(txt_hinhanh.Text))
            {
                MessageBox.Show(" Hình Ảnh Nhân Viên Không Được Để Trống", "Thông Báo");
                return false;
            }

            if (_iCheck.checkNumber(txt_donGiaNhap.Text))
            {
                MessageBox.Show(" Đơn Giá Nhập Phải Nhập Số", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNumber(txt_donGiaXuat.Text))
            {
                MessageBox.Show(" Đơn Giá Xuất Phải Nhập Số", "Thông Báo");
                return false;
            }
            if (_iCheck.checkNumber(txt_soLuong.Text))
            {
                MessageBox.Show(" Số Lượng Phải Nhập Số", "Thông Báo");
                return false;
            }


            return true;
        }
        public void MaNV(string mnv)
        {
            MaNVDN = mnv;
            MaNVDN = mnv;
        }
        public void LoadData()
        {

            _iQLSanPham = new QLSanPham();
            dgid_dataSP.ColumnCount = 10;
            dgid_dataSP.Columns[0].Name = "Mã Hàng";
            dgid_dataSP.Columns[1].Name = "Mã Nhân Viên";
            dgid_dataSP.Columns[2].Name = "Tên Hàng";
            dgid_dataSP.Columns[3].Name = "Số Lượng";
            dgid_dataSP.Columns[4].Name = "Đơn Giá Nhập";
            dgid_dataSP.Columns[5].Name = "Đơn Giá Bán";
            dgid_dataSP.Columns[6].Name = "Hình Ảnh";
            dgid_dataSP.Columns[7].Name = "Ghi Chú";
            dgid_dataSP.Rows.Clear();
            if (_iQLSanPham.GetLstHangs().Count < 0) return;
            foreach (var x in _iQLSanPham.GetLstHangs())
            {
                dgid_dataSP.Rows.Add(x.Mahang,x.Manv, x.Tenhang, x.Soluong, x.Dongianhap,x.Dongiaban,x.Hinhanh,x.Ghichu);
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
                    Hang h = new Hang();
                    h.Mahang = _iQLSanPham.GetLstHangs().Max(c => c.Mahang) + 1;
                    h.Manv = cmb_maNV.Text;
                    h.Tenhang = txt_tenHang.Text;
                    h.Soluong = Convert.ToInt32(txt_soLuong.Text);
                    h.Dongianhap = Convert.ToDouble(txt_donGiaNhap.Text);
                    h.Dongiaban = Convert.ToDouble(txt_donGiaXuat.Text);
                    h.Hinhanh = _imageLocation;
                    h.Ghichu = txt_ghiChu.Text;
                    MessageBox.Show(_iQLSanPham.AddHang(h), "Thông Báo");
                    _iQLSanPham.GetLstHangs();
                    LoadData();
                }
            }
        }
        private void dgid_dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == _iQLSanPham.GetLstHangs().Count || RowIndex == -1) return;
            txt_maHang.Text = dgid_dataSP.Rows[RowIndex].Cells[0].Value.ToString();
            cmb_maNV.Text = dgid_dataSP.Rows[RowIndex].Cells[1].Value.ToString();
            txt_tenHang.Text = dgid_dataSP.Rows[RowIndex].Cells[2].Value.ToString();
            txt_soLuong.Text = dgid_dataSP.Rows[RowIndex].Cells[3].Value.ToString();
            txt_donGiaNhap.Text = dgid_dataSP.Rows[RowIndex].Cells[4].Value.ToString();
            txt_donGiaXuat.Text = dgid_dataSP.Rows[RowIndex].Cells[5].Value.ToString();
            txt_hinhanh.Text = dgid_dataSP.Rows[RowIndex].Cells[6].Value.ToString();
            txt_ghiChu.Text = dgid_dataSP.Rows[RowIndex].Cells[7].Value.ToString();
            ptb_anh.ImageLocation = dgid_dataSP.Rows[RowIndex].Cells[6].Value.ToString();
            flagint = Convert.ToInt32(dgid_dataSP.Rows[RowIndex].Cells[0].Value.ToString());

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
                    Hang h = new Hang();
                    h.Mahang = _iQLSanPham.GetLstHangs().Where(c => c.Tenhang == txt_tenHang.Text).Select(c => c.Mahang)
                        .FirstOrDefault();
                    h.Tenhang = txt_tenHang.Text;
                    h.Manv = MaNVDN;
                    h.Soluong = Convert.ToInt32(txt_soLuong.Text);
                    h.Dongianhap = Convert.ToDouble(txt_donGiaNhap.Text);
                    h.Dongiaban = Convert.ToDouble(txt_donGiaXuat.Text);
                    h.Hinhanh = _imageLocation;
                    h.Ghichu = txt_ghiChu.Text;
                    MessageBox.Show(_iQLSanPham.UpdateHang(h), "Thông Báo");
                    _iQLSanPham.GetLstHangs();
                    LoadData();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_iQLSanPham.DeleteHang(flagint), "Thông Báo");
                _iQLSanPham.GetLstHangs();
                LoadData();
            }

        }

        private void btn_anh_Click(object sender, EventArgs e)
        {
            _OpenFileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            if (_OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _imageLocation = _OpenFileDialog.FileName;
                ptb_anh.ImageLocation = _imageLocation;
                txt_hinhanh.Text = _imageLocation;
            }
        }
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {

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

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            _iQLSanPham = new QLSanPham();
            dgid_dataSP.Rows.Clear();
            if (_iQLSanPham.GetLstHangs().Count < 0) return;
            foreach (var x in _iQLSanPham.GetLstHangs().Where(c => c.Tenhang == txt_timKiem.Text))
            {
                dgid_dataSP.Rows.Add(x.Mahang, x.Manv, x.Tenhang, x.Soluong, x.Dongianhap, x.Dongiaban, x.Hinhanh, x.Ghichu);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
