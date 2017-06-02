namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35793a87-8254-4aa9-9a6e-488840e82773', N'guest@vidly.com', 0, N'ANEXszvCmw15BIgm5gho1mZsm/f0jP0m2zz8h52IqiS9kRJGYBiIIGDa2k5km4rXDA==', N'c3289eca-556f-4276-9f64-9fdb47d6f6f5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd5bd09ea-9c5f-4df4-b2cd-dbd61f55540c', N'admin@vidly.com', 0, N'ALKbXDdZAOfD/l+XCQgPwNHIU8OJCPnEC//pvUzsxDN0JbpbkKdewt8tjqH5WY3gNQ==', N'cc4b0903-5090-4586-b750-6b833a31a667', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'14c1071b-6612-49d5-80b4-565f50da89b1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd5bd09ea-9c5f-4df4-b2cd-dbd61f55540c', N'14c1071b-6612-49d5-80b4-565f50da89b1')
");
        }
        
        public override void Down()
        {
        }
    }
}
