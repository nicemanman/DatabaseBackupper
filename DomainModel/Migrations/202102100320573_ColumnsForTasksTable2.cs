namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnsForTasksTable2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Jobs", new[] { "Schedule_Id" });
            RenameColumn(table: "dbo.Jobs", name: "Schedule_Id", newName: "ScheduleID");
            AlterColumn("dbo.Jobs", "ScheduleID", c => c.Int(nullable: false));
            CreateIndex("dbo.Jobs", "ScheduleID");
            AddForeignKey("dbo.Jobs", "ScheduleID", "dbo.Schedules", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "ScheduleID", "dbo.Schedules");
            DropIndex("dbo.Jobs", new[] { "ScheduleID" });
            AlterColumn("dbo.Jobs", "ScheduleID", c => c.Int());
            RenameColumn(table: "dbo.Jobs", name: "ScheduleID", newName: "Schedule_Id");
            CreateIndex("dbo.Jobs", "Schedule_Id");
            AddForeignKey("dbo.Jobs", "Schedule_Id", "dbo.Schedules", "Id");
        }
    }
}
