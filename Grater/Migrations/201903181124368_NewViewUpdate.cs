namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewViewUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Therapists", "Mobile", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Therapists", "Mobile");
        }
    }
}
