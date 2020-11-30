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
        public AppDbContext() : base("dbfile")
        {
            
        }
        
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<ScheduleModel> Schedules { get; set; }
    }
}
