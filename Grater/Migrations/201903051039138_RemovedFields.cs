namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "TherapistId", c => c.Int(nullable: false));
            CreateIndex("dbo.Skills", "TherapistId");
            AddForeignKey("dbo.Skills", "TherapistId", "dbo.Therapists", "Id", cascadeDelete: true);
            DropColumn("dbo.Therapists", "ActWorkPlace");
            DropColumn("dbo.Therapists", "PreWorkPlace");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Therapists", "PreWorkPlace", c => c.String());
            AddColumn("dbo.Therapists", "ActWorkPlace", c => c.String());
            DropForeignKey("dbo.Skills", "TherapistId", "dbo.Therapists");
            DropIndex("dbo.Skills", new[] { "TherapistId" });
            DropColumn("dbo.Skills", "TherapistId");
        }
    }
}
