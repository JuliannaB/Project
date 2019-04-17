namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skillagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Therapists", "SkillId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Therapists", "SkillId");
        }
    }
}
