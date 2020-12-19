using DatabaseBackupperWindowsLibrary.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.DatabaseModels
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("name=dbfile")
        {
            Database.CreateIfNotExists();
            Database.Initialize(false);
        }
        
        public DbSet<Job> Tasks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
