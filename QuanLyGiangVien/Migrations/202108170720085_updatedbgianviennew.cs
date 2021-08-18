namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbgianviennew : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.HocHams", "namdat");
            DropColumn("dbo.HocVis", "namdat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HocVis", "namdat", c => c.Int(nullable: false));
            AddColumn("dbo.HocHams", "namdat", c => c.Int(nullable: false));
        }
    }
}
