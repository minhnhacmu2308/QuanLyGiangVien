namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newup : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.HocPhans", new[] { "LoaiHocPhan_id1" });
            DropColumn("dbo.HocPhans", "LoaiHocPhan_id");
            RenameColumn(table: "dbo.HocPhans", name: "LoaiHocPhan_id1", newName: "LoaiHocPhan_id");
            AlterColumn("dbo.HocPhans", "LoaiHocPhan_id", c => c.Int());
            CreateIndex("dbo.HocPhans", "LoaiHocPhan_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.HocPhans", new[] { "LoaiHocPhan_id" });
            AlterColumn("dbo.HocPhans", "LoaiHocPhan_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.HocPhans", name: "LoaiHocPhan_id", newName: "LoaiHocPhan_id1");
            AddColumn("dbo.HocPhans", "LoaiHocPhan_id", c => c.Int(nullable: false));
            CreateIndex("dbo.HocPhans", "LoaiHocPhan_id1");
        }
    }
}
