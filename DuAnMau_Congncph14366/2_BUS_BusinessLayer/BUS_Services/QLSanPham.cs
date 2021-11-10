using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class QLSanPham:IQLSanPham
    {
        private IServiceSanPham _iServiceSanPham;
        private IServiceNhanVien _iServiceNhanVien;
        private List<NhapKho> _lstNhapKhos;
        
        public QLSanPham()
        {
            _iServiceSanPham = new ServiceSanPham();
            _iServiceNhanVien = new ServiceNhanVien();
            _lstNhapKhos = new List<NhapKho>();
            
        }


        public List<Hang> GetLstHangs()
        {
            return _iServiceSanPham.GetLstHangs();
        }

        public string AddHang(Hang hang)
        {
            return _iServiceSanPham.AddHang(hang);
        }

        public string UpdateHang(Hang hang)
        {
            return _iServiceSanPham.UpdateHang(hang);
        }

        public string DeleteHang(int hang)
        {
            return _iServiceSanPham.DeleteHang(hang);
        }

       
    }
}
