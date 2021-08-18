namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatcreated : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.GiangDays");
            AddColumn("dbo.GiangDays", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.GiangDays", "id");
            DropColumn("dbo.GiangDays", "id_gv");
            DropColumn("dbo.GiangDays", "id_hocphan");
            DropColumn("dbo.GiangViens", "id_hocvi");
            DropColumn("dbo.GiangViens", "id_hocham");
            DropColumn("dbo.GiangViens", "id_khoa");
            DropColumn("dbo.GiangViens", "id_loaigiaovien");
            DropColumn("dbo.HocVis", "id_truongdaotao");
            DropColumn("dbo.HocPhans", "id_loaihocphan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HocPhans", "id_loaihocphan", c => c.Int(nullable: false));
            AddColumn("dbo.HocVis", "id_truongdaotao", c => c.Int(nullable: false));
            AddColumn("dbo.GiangViens", "id_loaigiaovien", c => c.Int(nullable: false));
            AddColumn("dbo.GiangViens", "id_khoa", c => c.Int(nullable: false));
            AddColumn("dbo.GiangViens", "id_hocham", c => c.Int(nullable: false));
            AddColumn("dbo.GiangViens", "id_hocvi", c => c.Int(nullable: false));
            AddColumn("dbo.GiangDays", "id_hocphan", c => c.Int(nullable: false));
            AddColumn("dbo.GiangDays", "id_gv", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.GiangDays");
            DropColumn("dbo.GiangDays", "id");
            AddPrimaryKey("dbo.GiangDays", new[] { "id_gv", "id_hocphan" });
        }
    }
}
