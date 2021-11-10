using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IQLDangNhap
    {
        List<Nhanvien> GetLstNhanvien();
        bool KiemtrKiemTraTKvaMK(string tk, string mk , int tt);
        bool KiemtrKiemTraTKvaMK1(string tk, string mk, int tt);
        string LuuMatKhauMoi(Nhanvien nhanvien);
    }
}
