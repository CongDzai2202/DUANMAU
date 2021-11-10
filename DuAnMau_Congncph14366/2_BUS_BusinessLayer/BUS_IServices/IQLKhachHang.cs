using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IQLKhachHang
    {
        List<Khachhang> GetLstHangs();
        string AddHang(Khachhang khachhang);
        string UpdateHang(Khachhang khachhang);
        string DeleteHang(string khachhang);


    }
}
