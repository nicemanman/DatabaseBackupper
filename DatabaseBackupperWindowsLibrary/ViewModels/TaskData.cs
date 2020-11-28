using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.ViewModels
{
    public class TaskData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public LoginData LoginData { get; set; }
        public BackupData BackupData { get; set; }
        public int ScheduleID { get; set; } = 0;
        public ScheduleData Schedule { get; set; }
    }
}
