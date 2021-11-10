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
    public class QLKhachHang:IQLKhachHang
    {
        private IServiceKhachHang _iServiceKhachHang;
        public QLKhachHang()
        {
            _iServiceKhachHang = new ServiceKhachHang();
        }

        public List<Khachhang> GetLstHangs()
        {
            return _iServiceKhachHang.GetLstHangs();
        }

        public string AddHang(Khachhang khachhang)
        {
            return _iServiceKhachHang.AddHang(khachhang);
        }

        public string UpdateHang(Khachhang khachhang)
        {
            return _iServiceKhachHang.UpdateHang(khachhang);
        }

        public string DeleteHang(string khachhang)
        {
            return _iServiceKhachHang.DeleteHang(khachhang);
        }
    }
}
