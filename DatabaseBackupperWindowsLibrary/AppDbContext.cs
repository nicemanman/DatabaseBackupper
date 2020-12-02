using DatabaseBackupperWindowsLibrary.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("name=sqlite")
        {
            
        }
        
        public DbSet<Job> Tasks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
