using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Services;
using _2_BUS_BusinessLayer.BUS_IServices;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class QLDanhNhap:IQLDangNhap
    {
        private IServiceNhanVien _iServiceNhanVien;
        private List<Nhanvien> _lstNhanvien;

        public QLDanhNhap()
        {
            _iServiceNhanVien = new ServiceNhanVien();
            _lstNhanvien = _iServiceNhanVien.GetListNV();
            
        }

        public List<Nhanvien> GetLstNhanvien()
        {
            return _iServiceNhanVien.GetListNV();
        }
        public bool KiemtrKiemTraTKvaMK(string tk, string mk , int tt)
        {
            if (_lstNhanvien.Any(c => c.Email == tk && c.Matkhau == mk && c.Vaitro == 1))
            {
                return true;
            }


            return false;
        }
        public bool KiemtrKiemTraTKvaMK1(string tk, string mk, int tt)
        {
            if (_lstNhanvien.Any(c => c.Email == tk && c.Matkhau == mk && c.Vaitro == 0))
            {
                return true;
            }


            return false;
        }
        public string LuuMatKhauMoi(Nhanvien nhanvien)
        {
            return _iServiceNhanVien.UpdateNhanVien(nhanvien);
        }
    }
}
