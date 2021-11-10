using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Services;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IQLNhanVien
    {
        
        List<Nhanvien> GetListNV();
        string AddNhanVien(Nhanvien nv);
        string UpdateNhanVien(Nhanvien nv);
        string DeleteNhanVien(string mnv);
    }
}
