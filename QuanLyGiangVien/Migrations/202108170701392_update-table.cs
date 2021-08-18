namespace QuanLyGiangVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiangViens", "NoiDaoTao_id", c => c.Int());
            CreateIndex("dbo.GiangViens", "NoiDaoTao_id");
            AddForeignKey("dbo.GiangViens", "NoiDaoTao_id", "dbo.NoiDaoTaos", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiangViens", "NoiDaoTao_id", "dbo.NoiDaoTaos");
            DropIndex("dbo.GiangViens", new[] { "NoiDaoTao_id" });
            DropColumn("dbo.GiangViens", "NoiDaoTao_id");
        }
    }
}
