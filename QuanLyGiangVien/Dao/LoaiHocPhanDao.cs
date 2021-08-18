using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{

    public class LoaiHocPhanDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<LoaiHocPhan> getAll()
        {
            return mydb.loaiHocPhans.ToList();
        }
        public LoaiHocPhan getInformationById(int id)
        {
            return mydb.loaiHocPhans.Where(l => l.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationById(id);
            mydb.loaiHocPhans.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(LoaiHocPhan lhp)
        {
            mydb.loaiHocPhans.Add(lhp);
            mydb.SaveChanges();
        }
        public void edit(LoaiHocPhan lhp)
        {
            var objectH = getInformationById(lhp.id);
            objectH.tenloaihocphan = lhp.tenloaihocphan;
            mydb.SaveChanges();
        }
    }
}