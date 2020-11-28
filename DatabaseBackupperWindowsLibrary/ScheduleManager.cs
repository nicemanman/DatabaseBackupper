using DatabaseBackupperWindowsLibrary.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class ScheduleManager
    {   
        private AppDbContext context;
        public ScheduleManager()
        {
            context = new AppDbContext();
        }
        public List<ScheduleData> GetAllOfThem() 
        {
            var schedules = context.Schedules.Include("tasks");
            var scheduleDataList = new List<ScheduleData>();
            foreach (var item in schedules)
            {
                var tasks = new List<int>();
                foreach (var task in item.tasks)
                {
                    tasks.Add(task.TaskModelID);
                }
                var schedule = new ScheduleData()
                {
                    ID = item.ScheduleModelID,
                    Cron = item.Cron,
                    Description = item.Name,
                    tasks = tasks
                };
                scheduleDataList.Add(schedule);
            }
            return scheduleDataList;
        }

        public ScheduleData GetSchedule(int id) 
        {
            var item = context.Schedules.Include("tasks").Where(x=>x.ScheduleModelID == id).FirstOrDefault();
            var tasks = new List<int>();
            foreach (var task in item.tasks)
            {
                tasks.Add(task.TaskModelID);
            }
            var schedule = new ScheduleData()
            {
                ID = item.ScheduleModelID,
                Cron = item.Cron,
                Description = item.Name,
                tasks = tasks
            };
            return schedule;
        }
    }
}
