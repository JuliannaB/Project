namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ranking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Ranking", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Ranking");
        }
    }
}
