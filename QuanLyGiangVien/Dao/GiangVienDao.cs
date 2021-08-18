using QuanLyGiangVien.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Dao
{
    public class GiangVienDao
    {
        QuanLyGianVienDBContext mydb = new QuanLyGianVienDBContext();
        public List<GiangVien> getAll()
        {
            return mydb.giangViens.ToList();
        }
        public GiangVien getInformationByid(int id)
        {
            return mydb.giangViens.Where(h => h.id == id).FirstOrDefault();
        }
        public void delete(int id)
        {
            var objectH = getInformationByid(id);
            mydb.giangViens.Remove(objectH);
            mydb.SaveChanges();
        }
        public void add(string hoten, int gioitinh, string quequan, string ngaybatdau,int idHocHam, int idHocVi, int idKhoa,
            int idLoaigv, int idNoiDaotao,int namedathocvi,int namdathocham,string ngaysinh)
        {
            string sql = "insert into dbo.GiangViens(hoten,gioitinh,quequan,ngaybatdau,HocHam_id,HocVi_id,Khoa_id,LoaiGiaoVien_id,NoiDaoTao_id,namdathocvi,namdathocham,ngaysinh)"+
                " values(@hoten, @gioitinh, @quequan, @ngaybatdau, @idHh, @idHocvi, @idKhoa, @idlgv, @idNdd, @namhv, @namhh, @ngaysinh)";
            mydb.Database.ExecuteSqlCommand(sql, new SqlParameter("@hoten", hoten),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@quequan", quequan),
                new SqlParameter("@ngaybatdau", ngaybatdau),
                new SqlParameter("@idHh", idHocHam),
                new SqlParameter("@idHocvi", idHocVi),
                new SqlParameter("@idKhoa", idKhoa),
                new SqlParameter("@idlgv", idLoaigv),
                new SqlParameter("@idNdd", idNoiDaotao),
                new SqlParameter("@namhv", namedathocvi),
                new SqlParameter("@namhh", namdathocham),
                 new SqlParameter("@ngaysinh", ngaysinh)
                );
        }
        public void edit(int id,string hoten, int gioitinh, string quequan, string ngaybatdau, int idHocHam, int idHocVi, int idKhoa,
            int idLoaigv, int idNoiDaotao, int namedathocvi, int namdathocham, string ngaysinh)
        {
            string sql = "update dbo.GiangViens set  hoten = @hoten , gioitinh = @gioitinh, quequan = @quequan,ngaybatdau = @ngaybatdau ,HocHam_id = @idHh,HocVi_id = @idHocvi,Khoa_id =@idKhoa ,LoaiGiaoVien_id = @idlgv" +
                ",NoiDaoTao_id = @idNdd,namdathocvi =  @namhv ,namdathocham =  @namhh,ngaysinh = @ngaysinh  where id = @id ";
            mydb.Database.ExecuteSqlCommand(sql, new SqlParameter("@hoten", hoten),
              new SqlParameter("@gioitinh", gioitinh),
              new SqlParameter("@quequan", quequan),
              new SqlParameter("@ngaybatdau", ngaybatdau),
              new SqlParameter("@idHh", idHocHam),
              new SqlParameter("@idHocvi", idHocVi),
              new SqlParameter("@idKhoa", idKhoa),
              new SqlParameter("@idlgv", idLoaigv),
              new SqlParameter("@idNdd", idNoiDaotao),
              new SqlParameter("@namhv", namedathocvi),
              new SqlParameter("@namhh", namdathocham),
               new SqlParameter("@ngaysinh", ngaysinh),
                new SqlParameter("@id", id)
              );
        }
    }
}