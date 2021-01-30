namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableWithEmails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EMails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailString = c.String(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EMails");
        }
    }
}
