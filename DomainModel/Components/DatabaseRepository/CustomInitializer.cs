using DomainModel.Migrations;
using System.Data.Entity;

namespace DomainModel.Components.DatabaseRepository
{
    public class CustomInitializer : IDatabaseInitializer<AppDbContext>
    {
        public void InitializeDatabase(AppDbContext context)
        {
            
            if (!context.Database.Exists())
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
            }
            else
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
            }
        }

       
    }
}