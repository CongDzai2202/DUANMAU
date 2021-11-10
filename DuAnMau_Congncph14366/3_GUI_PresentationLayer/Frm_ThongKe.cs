using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_ThongKe : Form
    {
        private IQLSanPham _sv;
        private IQLNhapKho _nk;
        private Frm_DangNhap dn;
        public int quyen;
        public Frm_ThongKe()
        {
            _sv = new QLSanPham();
            _nk = new QLNhapKho();
            dn = new Frm_DangNhap();
            InitializeComponent();
            LoadDataNhap();
            

        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {

        }

        public void Quyen(int t)
        {
            quyen = t;
        }
        private void sảnPhẩmNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataNhap();
        }

        private void sảnPhẩmTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _sv = new QLSanPham();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Số Lượng Hàng Tồn";
            dataGridView1.Rows.Clear();
            if (_sv.GetLstHangs().Count < 0) return;
            foreach (var x in _sv.GetLstHangs())
            {
                dataGridView1.Rows.Add(x.Tenhang, x.Soluong);
            }
        }
        private void LoadDataNhap()
        {
            _sv = new QLSanPham();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã Nhân Viên";
            dataGridView1.Columns[1].Name = "Tên Nhân Viên";
            dataGridView1.Columns[2].Name = "Số Lượng ";
            dataGridView1.Rows.Clear();
            if (_nk.NhapKhos().Count < 0) return;
            foreach (var x in _nk.NhapKhos())
            {
                dataGridView1.Rows.Add(x.MaNV,x.TenNv,x.MaHang);
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            if (quyen == 1)
            {
                Frm_GiaoDienChinh giaoDienChinh = new Frm_GiaoDienChinh();
                this.Hide();
                giaoDienChinh.Show();
            }
            else
            {
                Frm_GiaoDienND giaoDienNd = new Frm_GiaoDienND();
                this.Hide();
                giaoDienNd.Show();
            }
        }
    }
}
