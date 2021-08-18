using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class HocHamDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<HocHam> getAll()
        {
            return mydb.hocHams.ToList();
        }
        public HocHam getInformationByid(int id)
        {
            return mydb.hocHams.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.hocHams.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(HocHam hocHam)
        {
            mydb.hocHams.Add(hocHam);
            mydb.SaveChanges();
        }
        public void edit(HocHam hocHam)
        {
            var objectH = getInformationByid(hocHam.id);
            objectH.tenhocham = hocHam.tenhocham;
            mydb.SaveChanges();
        }
    }
}