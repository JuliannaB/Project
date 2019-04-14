namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applyAnnotationsToNAme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Therapists", "TherapistName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Therapists", "TherapistName", c => c.String());
        }
    }
}
