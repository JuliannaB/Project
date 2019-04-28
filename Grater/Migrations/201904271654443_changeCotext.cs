namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCotext : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Skills", "TherapistId", "dbo.Therapists");
            DropForeignKey("dbo.Comments", "TherapistId", "dbo.Therapists");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "TherapistId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Skills", new[] { "TherapistId" });
            DropTable("dbo.Comments");
            DropTable("dbo.Therapists");
            DropTable("dbo.Skills");
            DropTable("dbo.Users");
            DropTable("dbo.Salons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Salons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        UserCity = c.String(),
                        UserDescription = c.String(),
                        Ranking = c.Int(nullable: false),
                        UserImage = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        TherapistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Therapists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TherapistName = c.String(nullable: false),
                        City = c.String(),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Mobile = c.Boolean(nullable: false),
                        TherapistImage = c.Binary(),
                        SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentTitle = c.String(),
                        CommentContent = c.String(),
                        Rate = c.Int(nullable: false),
                        TherapistId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Skills", "TherapistId");
            CreateIndex("dbo.Comments", "UserId");
            CreateIndex("dbo.Comments", "TherapistId");
            AddForeignKey("dbo.Comments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "TherapistId", "dbo.Therapists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Skills", "TherapistId", "dbo.Therapists", "Id", cascadeDelete: true);
        }
    }
}
