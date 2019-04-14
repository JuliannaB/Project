namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO USERS (UserName, UserCity, UserDescription) VALUES ('Chris', 'Dublin', 'Im smart one')");
            Sql("INSERT INTO USERS (UserName, UserCity, UserDescription) VALUES ('Kate', 'Lodz', 'I like massages')");
            Sql("INSERT INTO USERS (UserName, UserCity, UserDescription) VALUES ('Anna', 'Dublin', 'good one')");
         
        }
        
        public override void Down()
        {
        }
    }
}
