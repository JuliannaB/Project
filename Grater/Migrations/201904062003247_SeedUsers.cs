namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ca1e723-2c5f-4c01-aa80-1f96c1c92ece', N'Admin@grater.com', 0, N'AHunjAyMxKXaf+IYEY4JmaouFVyn6jZIs2roNntyO6/XROuFSA4Y7TM1E68aNvLMUg==', N'556d8141-c0b6-4650-99d7-2c021c6eb638', NULL, 0, 0, NULL, 1, 0, N'Admin@grater.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5ae0e88-6d93-43e3-9439-07958e3270ca', N'guest@grater.com', 0, N'ACfD/ge3jYNOsxvZaoEJPvs9VOlw1ZGPhuEyME2Alamv07EtHIR61/3yYirTNIpw0Q==', N'eb9a0266-0598-4c14-b643-416c40eb6cd3', NULL, 0, 0, NULL, 1, 0, N'guest@grater.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'39de88d0-39e2-4f10-ba1d-7ea281e4a7a6', N'CanManageApp')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ca1e723-2c5f-4c01-aa80-1f96c1c92ece', N'39de88d0-39e2-4f10-ba1d-7ea281e4a7a6')


");
        }
        
        public override void Down()
        {
        }
    }
}
