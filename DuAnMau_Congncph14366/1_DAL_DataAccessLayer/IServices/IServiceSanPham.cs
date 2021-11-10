using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IServices
{
    public interface IServiceSanPham
    {
        void GetLstHangFromDB();
        List<Hang> GetLstHangs();
        string AddHang(Hang hang);
        string UpdateHang(Hang hang);
        string DeleteHang(int hang);

    }
}
