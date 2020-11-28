using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.DatabaseModels
{
    public class TaskModel
    {   
        public int TaskModelID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ServerName { get; set; }
        [Required]
        public string Path { get; set; }
        
        [Required]
        public string Databases { get; set; }
        [Required]
        public ScheduleModel schedule { get; set; }
    }
}
