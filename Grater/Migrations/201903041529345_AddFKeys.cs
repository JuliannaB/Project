namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "TherapistId", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "TherapistId");
            CreateIndex("dbo.Comments", "UserId");
            AddForeignKey("dbo.Comments", "TherapistId", "dbo.Therapists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "TherapistId", "dbo.Therapists");
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "TherapistId" });
            DropColumn("dbo.Comments", "UserId");
            DropColumn("dbo.Comments", "TherapistId");
        }
    }
}
