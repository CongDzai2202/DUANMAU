using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class QLNhapKho:IQLNhapKho
    {
        private IServiceNhanVien _iServiceNhanVien;
        private IServiceSanPham _iServiceSanPham;
        private List<NhapKho> _nhapKho;
        public QLNhapKho()
        {
            _iServiceNhanVien = new ServiceNhanVien();
            _iServiceSanPham = new ServiceSanPham();
            _nhapKho = new List<NhapKho>();
        }

        public List<NhapKho> NhapKhos()
        {
            _nhapKho = (from a in _iServiceSanPham.GetLstHangs()
                join b in _iServiceNhanVien.GetListNV() on a.Manv equals b.Manv
                group a by new
                {
                    a.Manv,
                    b.Tennv
                }
                into g
                select new NhapKho()
                {
                    MaNV = g.Key.Manv,
                    TenNv = g.Key.Tennv,
                    MaHang = g.Count(c=>c.Mahang == c.Mahang)
                }).ToList();
            return _nhapKho;
        }
    }
}
