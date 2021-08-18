using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class HocViDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<HocVi> getAll()
        {
            return mydb.hocVis.ToList();
        }
        public HocVi getInformationByid(int id)
        {
            return mydb.hocVis.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.hocVis.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(HocVi hocVi)
        {
            mydb.hocVis.Add(hocVi);
            mydb.SaveChanges();
        }
        public void edit(HocVi hocVi)
        {
            var objectH = getInformationByid(hocVi.id);
            objectH.tenhocvi = hocVi.tenhocvi;
            mydb.SaveChanges();
        }
       
    }
}