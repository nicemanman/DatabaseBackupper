using DatabaseBackupperWindowsLibrary.ViewModels;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using DatabaseBackupperWindowsLibrary.DatabaseModels;

namespace DatabaseBackupperWindowsLibrary
{
    public class ScheduleManager
    {   
        private AppDbContext context;
        private Logger logger = LogManager.GetCurrentClassLogger();
        public List<ScheduleData> GetAllOfThem() 
        {
            using (context = new AppDbContext()) 
            {
                context.Schedules.Load();
                var schedules = context.Schedules.Include("tasks");
                var scheduleDataList = new List<ScheduleData>();
                foreach (var item in schedules)
                {
                    var tasks = new List<int>();
                    foreach (var task in item.tasks)
                    {
                        tasks.Add(task.Id);
                    }
                    var schedule = new ScheduleData()
                    {
                        ID = item.Id,
                        Cron = item.Cron,
                        Description = item.Name,
                        tasks = tasks
                    };
                    scheduleDataList.Add(schedule);
                }
                return scheduleDataList;
            }
            
        }

        public ScheduleData GetSchedule(int id) 
        {
            using (context = new AppDbContext())
            {
                var item = context.Schedules.Include("tasks").Where(x => x.Id == id).FirstOrDefault();
                var tasks = new List<int>();
                foreach (var task in item.tasks)
                {
                    tasks.Add(task.Id);
                }
                var schedule = new ScheduleData()
                {
                    ID = item.Id,
                    Cron = item.Cron,
                    Description = item.Name,
                    tasks = tasks
                };
                return schedule;
            }
            
        }
        public async Task AddSchedule(ScheduleData schedule) 
        {
            using (context = new AppDbContext()) 
            {
                var scheduleModel = new Schedule()
                {
                    Name = schedule.Description,
                    Cron = schedule.Cron
                };
                context.Schedules.Add(scheduleModel);
                await context.SaveChangesAsync();
            }    
        }
        public bool ValidateCronExpression(string cron) 
        {
            try
            {
                CronExpression.ValidateExpression(cron);
            }
            catch (Exception ex) 
            {
                logger.Error(ex);
                return false;
            }

            return true;
        }
    }
}
