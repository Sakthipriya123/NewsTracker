namespace NewsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "User_Id" });
            AddColumn("dbo.Comments", "User_Id1", c => c.String(maxLength: 128));
            AlterColumn("dbo.Comments", "User_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Comments", "User_Id1");
            AddForeignKey("dbo.Comments", "User_Id1", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "User_Id1", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "User_Id1" });
            AlterColumn("dbo.Comments", "User_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Comments", "User_Id1");
            CreateIndex("dbo.Comments", "User_Id");
            AddForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
