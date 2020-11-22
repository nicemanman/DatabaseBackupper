using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.Models
{
    public class TaskData
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public LoginData LoginData { get; set; }
        public BackupData BackupData { get; set; }
        public string CronJob { get; set; }
    }
}
