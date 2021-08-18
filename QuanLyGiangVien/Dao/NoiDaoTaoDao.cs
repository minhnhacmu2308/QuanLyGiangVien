using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class NoiDaoTaoDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<NoiDaoTao> getAll()
        {
            return mydb.noiDaoTaos.ToList();
        }
        public NoiDaoTao getInformationByid(int id)
        {
            return mydb.noiDaoTaos.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.noiDaoTaos.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(NoiDaoTao noiDaoTao)
        {
            mydb.noiDaoTaos.Add(noiDaoTao);
            mydb.SaveChanges();
        }
        public void edit(NoiDaoTao noiDaoTao)
        {
            var objectH = getInformationByid(noiDaoTao.id);
            objectH.tentruong = noiDaoTao.tentruong;
            objectH.thanhpho = noiDaoTao.thanhpho;
            objectH.quocgia = noiDaoTao.quocgia;
            mydb.SaveChanges();
        }
    }
}