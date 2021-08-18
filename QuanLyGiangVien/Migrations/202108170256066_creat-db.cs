namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiangDays",
                c => new
                    {
                        id_gv = c.Int(nullable: false),
                        id_hocphan = c.Int(nullable: false),
                        ngaybatdau = c.DateTime(nullable: false),
                        ngayketthuc = c.DateTime(nullable: false),
                        GiangVien_id = c.Int(),
                        HocPhan_id = c.Int(),
                    })
                .PrimaryKey(t => new { t.id_gv, t.id_hocphan })
                .ForeignKey("dbo.GiangViens", t => t.GiangVien_id)
                .ForeignKey("dbo.HocPhans", t => t.HocPhan_id)
                .Index(t => t.GiangVien_id)
                .Index(t => t.HocPhan_id);
            
            CreateTable(
                "dbo.GiangViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        hoten = c.String(nullable: false, maxLength: 255),
                        gioitinh = c.Int(nullable: false),
                        quequan = c.String(maxLength: 255),
                        ngaybatdau = c.DateTime(nullable: false),
                        id_hocvi = c.Int(nullable: false),
                        id_hocham = c.Int(nullable: false),
                        id_khoa = c.Int(nullable: false),
                        id_loaigiaovien = c.Int(nullable: false),
                        HocHam_id = c.Int(),
                        HocVi_id = c.Int(),
                        Khoa_id = c.Int(),
                        LoaiGiaoVien_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.HocHams", t => t.HocHam_id)
                .ForeignKey("dbo.HocVis", t => t.HocVi_id)
                .ForeignKey("dbo.Khoas", t => t.Khoa_id)
                .ForeignKey("dbo.LoaiGiangViens", t => t.LoaiGiaoVien_id)
                .Index(t => t.HocHam_id)
                .Index(t => t.HocVi_id)
                .Index(t => t.Khoa_id)
                .Index(t => t.LoaiGiaoVien_id);
            
            CreateTable(
                "dbo.HocHams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenhocham = c.String(nullable: false, maxLength: 255),
                        namdat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HocVis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenhocvi = c.String(nullable: false, maxLength: 255),
                        namdat = c.Int(nullable: false),
                        id_truongdaotao = c.Int(nullable: false),
                        NoiDaoTao_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NoiDaoTaos", t => t.NoiDaoTao_id)
                .Index(t => t.NoiDaoTao_id);
            
            CreateTable(
                "dbo.NoiDaoTaos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tentruong = c.String(nullable: false, maxLength: 255),
                        thanhpho = c.String(maxLength: 255),
                        quocgia = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenkhoa = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LoaiGiangViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenloaihocgiaovien = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenhocphan = c.String(nullable: false, maxLength: 255),
                        tinchi = c.Int(nullable: false),
                        id_loaihocphan = c.Int(nullable: false),
                        LoaiHocPhan_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.LoaiHocPhans", t => t.LoaiHocPhan_id)
                .Index(t => t.LoaiHocPhan_id);
            
            CreateTable(
                "dbo.LoaiHocPhans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tenloaihocphan = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiangDays", "HocPhan_id", "dbo.HocPhans");
            DropForeignKey("dbo.HocPhans", "LoaiHocPhan_id", "dbo.LoaiHocPhans");
            DropForeignKey("dbo.GiangViens", "LoaiGiaoVien_id", "dbo.LoaiGiangViens");
            DropForeignKey("dbo.GiangViens", "Khoa_id", "dbo.Khoas");
            DropForeignKey("dbo.HocVis", "NoiDaoTao_id", "dbo.NoiDaoTaos");
            DropForeignKey("dbo.GiangViens", "HocVi_id", "dbo.HocVis");
            DropForeignKey("dbo.GiangViens", "HocHam_id", "dbo.HocHams");
            DropForeignKey("dbo.GiangDays", "GiangVien_id", "dbo.GiangViens");
            DropIndex("dbo.HocPhans", new[] { "LoaiHocPhan_id" });
            DropIndex("dbo.HocVis", new[] { "NoiDaoTao_id" });
            DropIndex("dbo.GiangViens", new[] { "LoaiGiaoVien_id" });
            DropIndex("dbo.GiangViens", new[] { "Khoa_id" });
            DropIndex("dbo.GiangViens", new[] { "HocVi_id" });
            DropIndex("dbo.GiangViens", new[] { "HocHam_id" });
            DropIndex("dbo.GiangDays", new[] { "HocPhan_id" });
            DropIndex("dbo.GiangDays", new[] { "GiangVien_id" });
            DropTable("dbo.LoaiHocPhans");
            DropTable("dbo.HocPhans");
            DropTable("dbo.LoaiGiangViens");
            DropTable("dbo.Khoas");
            DropTable("dbo.NoiDaoTaos");
            DropTable("dbo.HocVis");
            DropTable("dbo.HocHams");
            DropTable("dbo.GiangViens");
            DropTable("dbo.GiangDays");
        }
    }
}
