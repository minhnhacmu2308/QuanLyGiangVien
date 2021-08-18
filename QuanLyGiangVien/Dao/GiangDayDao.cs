using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class GiangDayDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();

        public List<GiangDay> getAll()
        {
            return mydb.giangDays.ToList();
        }
        public GiangDay getInformationByid(int id)
        {
            return mydb.giangDays.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.giangDays.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(int idHp,int idGv,string ngaybatdau,string ngayketthuc)
        {
            string sql = "insert into GiangDays(ngaybatdau,ngayketthuc,HocPhan_id,GiangVien_id) values(@ngaybatdau,@ngayketthuc,@idHp,@idGv)";
            mydb.Database.ExecuteSqlCommand(sql, new SqlParameter("@ngaybatdau", ngaybatdau),
                new SqlParameter("@ngayketthuc", ngayketthuc),
                new SqlParameter("@idHp", idHp),
                new SqlParameter("@idGv", idGv)
                );
        }
        public void edit(int id , int idHp, int idGv, string ngaybatdau, string ngayketthuc)
        {
            string sql = "update dbo.GiangDays set ngaybatdau = @ngaybatdau , ngayketthuc = @ngayketthuc,HocPhan_id =@idHp ,GiangVien_id = @idGv where id = @id";
            mydb.Database.ExecuteSqlCommand(sql, new SqlParameter("@ngaybatdau", ngaybatdau),
              new SqlParameter("@ngayketthuc", ngayketthuc),
              new SqlParameter("@idHp", idHp),
              new SqlParameter("@idGv", idGv),
              new SqlParameter("@id", id)
              );
        }
    }
}