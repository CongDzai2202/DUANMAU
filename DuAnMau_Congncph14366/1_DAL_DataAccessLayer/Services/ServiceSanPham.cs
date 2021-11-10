using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Services
{
    
    public class ServiceSanPham:IServiceSanPham
    {
        private DatabaseContext _dbContext;
        private List<Hang> _lstHangs;
        public ServiceSanPham()
        {
            _dbContext = new DatabaseContext();
            _lstHangs = new List<Hang>();
            GetLstHangFromDB();
        }

        public void GetLstHangFromDB()
        {
            _lstHangs = _dbContext.Hangs.AsNoTracking().ToList();
        }

        public List<Hang> GetLstHangs()
        {
            return _lstHangs;
        }

        public string AddHang(Hang hang)
        {
            _dbContext.Hangs.Add(hang);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string UpdateHang(Hang hang)
        {
            _dbContext.Hangs.Update(hang);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string DeleteHang(int hang)
        {
            var mh = _dbContext.Hangs.FirstOrDefault(c => c.Mahang == hang);
            _dbContext.Hangs.Remove(mh);
            _dbContext.SaveChanges();
            return "Xóa Thành Công";
        }

        
    }
    

}
