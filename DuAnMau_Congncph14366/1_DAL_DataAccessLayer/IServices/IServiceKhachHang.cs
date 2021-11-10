using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IServices
{
    public interface IServiceKhachHang
    {
        public void GetLstHangFromDB();
        public List<Khachhang> GetLstHangs();
        public string AddHang(Khachhang khachhang);
        public string UpdateHang(Khachhang khachhang);
        public string DeleteHang(string khachhang);

    }
}
