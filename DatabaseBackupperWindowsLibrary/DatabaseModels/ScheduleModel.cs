using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.DatabaseModels
{
    public class ScheduleModel
    {
        public int ScheduleModelID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cron { get; set; }
        public List<TaskModel> tasks { get; set; }
    }
}
