namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newone : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
