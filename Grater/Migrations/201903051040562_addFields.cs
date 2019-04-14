namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Therapists", "PhoneNumber", c => c.String());
            AddColumn("dbo.Therapists", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Therapists", "Email");
            DropColumn("dbo.Therapists", "PhoneNumber");
        }
    }
}
