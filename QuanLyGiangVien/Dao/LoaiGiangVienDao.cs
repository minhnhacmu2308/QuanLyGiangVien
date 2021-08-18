using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace QuanLyGiangVien.Dao
{
    public class LoaiGiangVienDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();

        public List<LoaiGiangVien> getAll()
        {
            return mydb.loaiGiangViens.ToList();
        }
        public LoaiGiangVien getLoaiGiangVienByid(int id)
        {
            return mydb.loaiGiangViens.Where(l => l.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectL = getLoaiGiangVienByid(id);
            mydb.loaiGiangViens.Remove(objectL);
            mydb.SaveChanges();
        }
        public void add(LoaiGiangVien lgv)
        {
            mydb.loaiGiangViens.Add(lgv);
            mydb.SaveChanges();
        }
        public void update(LoaiGiangVien lgv)
        {
            var objectL = getLoaiGiangVienByid(lgv.id);
            objectL.tenloaigiangvien = lgv.tenloaigiangvien;
            mydb.SaveChanges();
        }
    }
}