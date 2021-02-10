using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> AllDatabases { get; set; }
        public List<string> SelectedDatabases { get; set; }
        public string SQLServer { get; set; }
        public string SelectedPath { get; set; }
        public ScheduleModel SelectedSchedule { get; set; }
        public bool NotifyAboutFinish { get; set; }
        public string SelectedEmail { get; set; }
        public bool Enabled { get; set; }
        public string BackupResult { get; set; }
    }
}
