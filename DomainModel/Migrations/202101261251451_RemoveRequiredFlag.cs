namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFlag : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "Days", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "Days", c => c.String(nullable: false));
        }
    }
}
