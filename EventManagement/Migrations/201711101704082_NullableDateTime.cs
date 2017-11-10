namespace EventManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventDate", c => c.DateTime());
            AlterColumn("dbo.Events", "EventTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "EventDate", c => c.DateTime(nullable: false));
        }
    }
}
