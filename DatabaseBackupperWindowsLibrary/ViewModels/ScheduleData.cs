using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.ViewModels
{
    public class ScheduleData
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Cron { get; set; }
        public List<int> tasks { get; set; }
    }
}
