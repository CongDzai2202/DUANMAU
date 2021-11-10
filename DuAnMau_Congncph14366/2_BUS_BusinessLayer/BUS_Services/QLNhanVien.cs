using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Services;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class QLNhanVien:IQLNhanVien
    {
        IServiceNhanVien _iServiceNhanVien;
        public QLNhanVien()
        {
            _iServiceNhanVien = new ServiceNhanVien();
        }

        public List<Nhanvien> GetListNV()
        {
            return _iServiceNhanVien.GetListNV();
        }


        public string AddNhanVien(Nhanvien nv)
        {
            return _iServiceNhanVien.AddNhanVien(nv);
        }

        public string UpdateNhanVien(Nhanvien nv)
        {
            return _iServiceNhanVien.UpdateNhanVien(nv);
        }

        public string DeleteNhanVien(string mnv)
        {
            return _iServiceNhanVien.DeleteNhanVien(mnv);
        }
    }
}
