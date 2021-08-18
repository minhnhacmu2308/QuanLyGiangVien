namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbngáyinh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiangViens", "ngaysinh", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GiangViens", "ngaysinh");
        }
    }
}
