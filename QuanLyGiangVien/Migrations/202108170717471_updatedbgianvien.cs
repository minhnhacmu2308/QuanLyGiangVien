namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbgianvien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiangViens", "namdathocvi", c => c.Int(nullable: false));
            AddColumn("dbo.GiangViens", "namdathocham", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GiangViens", "namdathocham");
            DropColumn("dbo.GiangViens", "namdathocvi");
        }
    }
}
