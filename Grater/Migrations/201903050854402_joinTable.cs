namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class joinTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SkillTherapists",
                c => new
                    {
                        Skill_Id = c.Int(nullable: false),
                        Therapist_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Skill_Id, t.Therapist_Id })
                .ForeignKey("dbo.Skills", t => t.Skill_Id, cascadeDelete: true)
                .ForeignKey("dbo.Therapists", t => t.Therapist_Id, cascadeDelete: true)
                .Index(t => t.Skill_Id)
                .Index(t => t.Therapist_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkillTherapists", "Therapist_Id", "dbo.Therapists");
            DropForeignKey("dbo.SkillTherapists", "Skill_Id", "dbo.Skills");
            DropIndex("dbo.SkillTherapists", new[] { "Therapist_Id" });
            DropIndex("dbo.SkillTherapists", new[] { "Skill_Id" });
            DropTable("dbo.SkillTherapists");
        }
    }
}
