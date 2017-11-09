namespace EventManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertEventTypeMasterData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT EventTypes ON");
            Sql("INSERT [dbo].[EventTypes] ([Id], [Name], [Description], [CreatedDate], [CreatedBy]) VALUES (1, N'Mobility', N'Mobility', CAST(0x0000A82500000000 AS DateTime), NULL)");
            Sql("INSERT [dbo].[EventTypes] ([Id], [Name], [Description], [CreatedDate], [CreatedBy]) VALUES (2, N'Web Development', N'Web Development', CAST(0x0000A82500000000 AS DateTime), NULL)");
            Sql("SET IDENTITY_INSERT EventTypes OFF ");
        }
        
        public override void Down()
        {
        }
    }
}
