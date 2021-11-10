using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.BUS_Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IQLSanPham
    {

        List<Hang> GetLstHangs();
        string AddHang(Hang hang);
        string UpdateHang(Hang hang);
        string DeleteHang(int hang);
        
    }
}
