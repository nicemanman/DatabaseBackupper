namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackupPaths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PathString = c.String(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cron = c.String(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Hours = c.Int(nullable: false),
                        Days = c.String(nullable: false),
                        CronTypeExpressionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ServerName = c.String(nullable: false),
                        Path = c.String(nullable: false),
                        Databases = c.String(nullable: false),
                        schedule_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.schedule_Id, cascadeDelete: true)
                .Index(t => t.schedule_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Jobs", new[] { "schedule_Id" });
            DropTable("dbo.Jobs");
            DropTable("dbo.Schedules");
            DropTable("dbo.BackupPaths");
        }
    }
}
