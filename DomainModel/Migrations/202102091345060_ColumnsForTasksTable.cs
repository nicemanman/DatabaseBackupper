namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnsForTasksTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Jobs", new[] { "schedule_Id" });
            AddColumn("dbo.Jobs", "NotifyAboutFinish", c => c.Boolean(nullable: false));
            AddColumn("dbo.Jobs", "EmailToNotify", c => c.String());
            AddColumn("dbo.Jobs", "IsEnabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Jobs", "Name", c => c.String());
            AlterColumn("dbo.Jobs", "ServerName", c => c.String());
            AlterColumn("dbo.Jobs", "Path", c => c.String());
            AlterColumn("dbo.Jobs", "Databases", c => c.String());
            AlterColumn("dbo.Jobs", "Schedule_Id", c => c.Int());
            CreateIndex("dbo.Jobs", "Schedule_Id");
            AddForeignKey("dbo.Jobs", "Schedule_Id", "dbo.Schedules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Jobs", new[] { "Schedule_Id" });
            AlterColumn("dbo.Jobs", "Schedule_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Jobs", "Databases", c => c.String(nullable: false));
            AlterColumn("dbo.Jobs", "Path", c => c.String(nullable: false));
            AlterColumn("dbo.Jobs", "ServerName", c => c.String(nullable: false));
            AlterColumn("dbo.Jobs", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Jobs", "IsEnabled");
            DropColumn("dbo.Jobs", "EmailToNotify");
            DropColumn("dbo.Jobs", "NotifyAboutFinish");
            CreateIndex("dbo.Jobs", "schedule_Id");
            AddForeignKey("dbo.Jobs", "schedule_Id", "dbo.Schedules", "Id", cascadeDelete: true);
        }
    }
}
