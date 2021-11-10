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
    public partial class Frm_GiaoDienND : Form
    {
        public string EmailDN;
        public Frm_GiaoDienND()
        {
            InitializeComponent();
        }
        public void TenDN(string ten)
        {
            lbl_ten.Text = "Chào Bạn : " + ten;
            EmailDN = ten;

        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SanPham sanPham = new Frm_SanPham();
            this.Hide();
            sanPham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Không Thể Sử Dụng Chức Năng Này", "Thông Báo");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang khachHang = new Frm_KhachHang();
            this.Hide();
            khachHang.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap dangNhap = new Frm_DangNhap();
            this.Hide();
            dangNhap.Show();
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongKe tke = new Frm_ThongKe();
            this.Hide();
            tke.Show();
        }
    }
}
