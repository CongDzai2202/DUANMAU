using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IServices;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Services;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Services
{
    public class ServiceNhanVien:IServiceNhanVien
    {
        private List<Nhanvien> _lstNhanviens;
        private DatabaseContext _dbContext;
        

        public ServiceNhanVien()
        {
            
            _lstNhanviens = new List<Nhanvien>();
            _dbContext = new DatabaseContext();
            getListFromDB();
        }
        
        public void getListFromDB()
        {
            _lstNhanviens = _dbContext.Nhanviens.AsNoTracking().ToList();
        }

        
        public List<Nhanvien> GetListNV()
        {
            return _lstNhanviens;
        }
       

        public string AddNhanVien(Nhanvien nv)
        {
            nv.Id = _lstNhanviens.Max(c => c.Id) + 1;
            nv.Manv = "NV" + nv.Id;
            _lstNhanviens.Add(nv);
            _dbContext.Nhanviens.Add(nv);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";

        }

        public string UpdateNhanVien(Nhanvien nv)
        {
            _dbContext.Nhanviens.Update(nv);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string DeleteNhanVien(string mnv)
        {
            
            var nv = _dbContext.Nhanviens.FirstOrDefault(c => c.Manv == mnv);
            _dbContext.Nhanviens.Remove(nv);
            _dbContext.SaveChanges();
            return "Xóa Thành Công";
                
           
        }
    }
}
