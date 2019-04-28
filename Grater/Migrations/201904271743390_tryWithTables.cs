namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class tryWithTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CommentContent = c.String(),
                    Rate = c.Int(nullable: false),
                    ReleaseDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);



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
                "dbo.Skills",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SkillName = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Therapists",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TherapistName = c.String(),
                    City = c.String(),
                    Description = c.String(),
                    ActWorkPlace = c.String(),
                    PreWorkPlace = c.String(),
                    TherapistImage = c.Binary(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserName = c.String(),
                    UserCity = c.String(),
                    UserDescription = c.String(),
                    UserImage = c.Binary(),
                })
                .PrimaryKey(t => t.Id);



        }

        public override void Down()
        {

            DropTable("dbo.Users");
            DropTable("dbo.Therapists");
            DropTable("dbo.Skills");
            DropTable("dbo.Salons");
            DropTable("dbo.Comments");
        }
    }
}
