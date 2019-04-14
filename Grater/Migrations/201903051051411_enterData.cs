namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enterData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SALONS (City, Name, Address) VALUES ('Dublin', 'Urban', 'Santry')");
        }
        
        public override void Down()
        {
        }
    }
}
