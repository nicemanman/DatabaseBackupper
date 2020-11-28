namespace DatabaseBackupperWindowsLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScheduleModels",
                c => new
                    {
                        ScheduleModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cron = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleModelID);
            
            CreateTable(
                "dbo.TaskModels",
                c => new
                    {
                        TaskModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ServerName = c.String(nullable: false),
                        Path = c.String(nullable: false),
                        Databases = c.String(nullable: false),
                        schedule_ScheduleModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TaskModelID)
                .ForeignKey("dbo.ScheduleModels", t => t.schedule_ScheduleModelID, cascadeDelete: true)
                .Index(t => t.schedule_ScheduleModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskModels", "schedule_ScheduleModelID", "dbo.ScheduleModels");
            DropIndex("dbo.TaskModels", new[] { "schedule_ScheduleModelID" });
            DropTable("dbo.TaskModels");
            DropTable("dbo.ScheduleModels");
        }
    }
}
