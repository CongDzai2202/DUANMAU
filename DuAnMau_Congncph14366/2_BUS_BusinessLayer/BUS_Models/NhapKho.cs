using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;

namespace _2_BUS_BusinessLayer.BUS_Models
{
    public class NhapKho
    {
        // public Nhanvien nhanVien { get; set; } // mã tên
        // public Hang sanPham { get; set; } // mẫ tên sô lương
        public string MaNV { get; set; }
        public string TenNv { get; set; }
        public int MaHang { get; set; }

    }
}
