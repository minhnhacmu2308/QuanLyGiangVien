namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoaiGiangViens", "tenloaigiangvien", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.LoaiGiangViens", "tenloaihocgiaovien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoaiGiangViens", "tenloaihocgiaovien", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.LoaiGiangViens", "tenloaigiangvien");
        }
    }
}
