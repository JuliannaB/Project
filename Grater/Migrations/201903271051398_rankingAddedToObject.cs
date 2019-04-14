namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rankingAddedToObject : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO USERS (UserName, UserCity, UserDescription, Ranking) VALUES('Anastacia Gaspacio', 'Dublin', 'I like pasta', 1)");
           
        }
        
        public override void Down()
        {
        }
    }
}
