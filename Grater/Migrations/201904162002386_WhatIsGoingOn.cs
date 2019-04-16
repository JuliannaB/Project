namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhatIsGoingOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CommentTitle", c => c.String());
            AddColumn("dbo.Therapists", "SkillId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Therapists", "SkillId");
            DropColumn("dbo.Comments", "CommentTitle");
        }
    }
}
