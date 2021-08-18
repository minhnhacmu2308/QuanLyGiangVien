namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HocVis", "NoiDaoTao_id", "dbo.NoiDaoTaos");
            DropIndex("dbo.HocVis", new[] { "NoiDaoTao_id" });
            DropColumn("dbo.HocVis", "NoiDaoTao_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HocVis", "NoiDaoTao_id", c => c.Int());
            CreateIndex("dbo.HocVis", "NoiDaoTao_id");
            AddForeignKey("dbo.HocVis", "NoiDaoTao_id", "dbo.NoiDaoTaos", "id");
        }
    }
}
