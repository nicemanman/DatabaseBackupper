using DomainModel.Components.DatabaseRepository.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public class AppDbContext : DbContext
    {
        static AppDbContext() 
        {
            Database.SetInitializer<AppDbContext>(new CreateDatabaseIfNotExists<AppDbContext>());
        }
        public AppDbContext() : base("name=dbfile")
        {
            
        }

        public DbSet<Job> Tasks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<BackupPath> Paths { get; set; }
    }
}
