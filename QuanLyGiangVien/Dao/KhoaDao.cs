using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class KhoaDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<Khoa> getAll()
        {
            return mydb.khoas.ToList();
        }
        public Khoa getinformationById(int id)
        {
            return mydb.khoas.Where(k => k.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectK = getinformationById(id);
            mydb.khoas.Remove(objectK);
            mydb.SaveChanges();
        }
        public void add(Khoa k)
        {
            mydb.khoas.Add(k);
            mydb.SaveChanges();
        }
        public void edit(Khoa k)
        {
            var objectK = getinformationById(k.id);
            objectK.tenkhoa = k.tenkhoa;
            mydb.SaveChanges();
        }
    }
}