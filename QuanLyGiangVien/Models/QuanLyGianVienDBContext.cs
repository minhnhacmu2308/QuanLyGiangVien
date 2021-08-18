using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLyGiangVien.Models
{
    public class QuanLyGianVienDBContext : DbContext
    {
        public QuanLyGianVienDBContext() : base("QuanLyGiangVienConnectionString")
        {

        }
        public DbSet<GiangVien> giangViens { get; set; }
        public DbSet<GiangDay> giangDays { get; set; }
        public DbSet<HocHam> hocHams { get; set; }
        public DbSet<HocVi> hocVis { get; set; }
        public DbSet<HocPhan> hocPhans { get; set; }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<LoaiHocPhan> loaiHocPhans { get; set; }
        public DbSet<LoaiGiangVien> loaiGiangViens { get; set; }
        public DbSet<NoiDaoTao> noiDaoTaos { get; set; }
     }
}