namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillTry : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Therapists", "SkillId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Therapists", "SkillId", c => c.Int(nullable: false));
        }
    }
}
