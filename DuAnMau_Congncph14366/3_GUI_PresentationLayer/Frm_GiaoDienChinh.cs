using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_GiaoDienChinh : Form
    {
        private int quyen;
        private string EmailDN;
        private IQLNhanVien _iQlNV;
        private Frm_SanPham sp;
        public Frm_GiaoDienChinh()
        {
            InitializeComponent();
            _iQlNV = new QLNhanVien();
            //dn = new Frm_DangNhap();
            Frm_SanPham sp = new Frm_SanPham();

        }

        public void TenDN(string ten)
        {
            lbl_ten.Text = "Chào Bạn : " + ten;
            EmailDN = ten;
            EmailDN = ten;
        }
        public void Manv()
        {
            var mnv = _iQlNV.GetListNV().Where(c => c.Email == EmailDN).Select(c => c.Manv).FirstOrDefault();
            
            sp.MaNV(mnv);

        }
        public void QuyenDN(int t)
        {
            quyen = t;
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap dangNhap = new Frm_DangNhap();
            this.Hide();
            dangNhap.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SanPham sanPham = new Frm_SanPham();
            var mnv = _iQlNV.GetListNV().Where(c => c.Email == EmailDN).Select(c => c.Manv).FirstOrDefault();

            sanPham.MaNV(mnv);
            sanPham.Quyen(quyen);
            sanPham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien nhanVien = new Frm_NhanVien();
           
            nhanVien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang khachHang = new Frm_KhachHang();
            khachHang.Quyen(quyen);
            
            khachHang.Show();
        }

        private void Frm_GiaoDienChinh_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ten_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongKe thongKe = new Frm_ThongKe();
            thongKe.Quyen(quyen);
            thongKe.Show();
        }
    }
}
