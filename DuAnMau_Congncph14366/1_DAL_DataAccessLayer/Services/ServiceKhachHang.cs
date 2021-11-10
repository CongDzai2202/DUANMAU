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
    public class ServiceKhachHang : IServiceKhachHang
    {
        private DatabaseContext _dbContext;
        private List<Khachhang> _lstKhachHangs;

        public ServiceKhachHang()
        {
            _dbContext = new DatabaseContext();
            _lstKhachHangs = new List<Khachhang>();
            GetLstHangFromDB();
        }
        public void GetLstHangFromDB()
        {
            _lstKhachHangs = _dbContext.Khachhangs.AsNoTracking().ToList();
        }

        public List<Khachhang> GetLstHangs()
        {
            return _lstKhachHangs;
        }

        public string AddHang(Khachhang khachhang)
        {
            _dbContext.Khachhangs.Add(khachhang);
                _dbContext.SaveChanges();
                return "Thêm Thành Công";
            

        }

        public string UpdateHang(Khachhang khachhang)
        {
            _dbContext.Khachhangs.Update(khachhang);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string DeleteHang(string khachhang)
        {
            var kh = _dbContext.Khachhangs.FirstOrDefault(c => c.Sodienthoai == khachhang);
            _dbContext.Khachhangs.Remove(kh);
            _dbContext.SaveChanges();
            return "Xóa Thành Công";
        }
    }
}
