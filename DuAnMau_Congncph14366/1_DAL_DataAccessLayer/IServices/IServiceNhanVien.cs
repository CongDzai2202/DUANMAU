using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IServices
{
    public interface IServiceNhanVien
    {
        void getListFromDB();
        List<Nhanvien> GetListNV();
        string AddNhanVien(Nhanvien nv);
        string UpdateNhanVien(Nhanvien nv);
        string DeleteNhanVien(string mnv);


    }
}
