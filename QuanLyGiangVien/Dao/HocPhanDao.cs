using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class HocPhanDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<HocPhan> getAll()
        {
            return mydb.hocPhans.ToList();
        }
        public HocPhan getInformationByid(int id)
        {
            return mydb.hocPhans.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.hocPhans.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(string ten,int tinchi,int idLoaiHocPhan )
        {
            string sql = "insert into HocPhans(tenhocphan,tinchi,LoaiHocPhan_id) values(@ten,@tinchi,@loaihocphanId)";
            mydb.Database.ExecuteSqlCommand(sql,new SqlParameter("@ten",ten),new SqlParameter("@tinchi",tinchi),new SqlParameter("loaihocphanId", idLoaiHocPhan));
        }
        public void edit(int id,string ten, int tinchi, int idLoaiHocPhan)
        {
            string sql = "update  dbo.HocPhans set tenhocphan = @tenhocphan,tinchi = @tinchi ,LoaiHocPhan_id = @LoaiHocPhan_id where id = @id";
            mydb.Database.ExecuteSqlCommand(sql, new SqlParameter("@tenhocphan", ten), new SqlParameter("@tinchi", tinchi), new SqlParameter("LoaiHocPhan_id", idLoaiHocPhan), new SqlParameter("@id", id));
        }
    }
}