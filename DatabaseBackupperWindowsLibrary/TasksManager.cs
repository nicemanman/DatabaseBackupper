using DatabaseBackupper;
using DatabaseBackupperWindowsLibrary.DatabaseModels;
using DatabaseBackupperWindowsLibrary.ViewModels;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class TasksManager
    {
        private AppDbContext context;
        //private List<TaskData> tasks = new List<TaskData>();
        private Logger logger = LogManager.GetCurrentClassLogger();
        //public TaskData this[int index] 
        //{
        //    get => tasks[index];
        //}
        public TasksManager()
        {
            context = new AppDbContext();
            BuildTasksQueue();
        }
        public int Count() 
        {
            var result = context.Tasks.Count();
            return result;
            //return tasks?.Count() ?? 0;
        }
        public List<TaskData> GetAllOfThem() 
        {
            var taskModels = context.Tasks.Include("Schedule").ToList();
            List<TaskData> tasks = new List<TaskData>();
            foreach (var item in taskModels)
            {
                var task = new TaskData()
                {
                    ID = item.TaskModelID,
                    Name = item.Name,
                    BackupData = new BackupData()
                    {
                        DatabasesToBackup = item.Databases.Split(';').ToList<string>(),
                        Path = item.Path
                    },
                    LoginData = new LoginData() 
                    {
                        ServerName = item.ServerName
                    },
                    ScheduleID = item.schedule.ScheduleModelID,
                    Schedule = new ScheduleData() 
                    {
                        ID = item.schedule.ScheduleModelID,
                        Description = item.schedule.Name,
                        Cron = item.schedule.Cron
                    }
                };
                tasks.Add(task);
            }
            return tasks;
        }
        public void BuildTasksQueue() 
        {
            //if (File.Exists(@"TaskData.json"))
            //    using (StreamReader file = File.OpenText(@"TaskData.json"))
            //    {
            //        var source = file.ReadToEnd();
            //        if (source.Length == 0) return;
            //        JsonSerializer serializer = new JsonSerializer();
            //        tasks = (List<TaskData>)serializer.Deserialize(file, typeof(List<TaskData>));
            //    }
        }
        
        public void AddTask(TaskData task) 
        {
            var find = context.Tasks.Find(task.ID);
            var scheduleRow = context.Schedules.Find(task.ScheduleID);
            var taskModel = new TaskModel()
            {
                Name = task.Name,
                Databases = string.Join(";", task.BackupData.DatabasesToBackup),
                Path = task.BackupData.Path,
                ServerName = task.LoginData.ServerName,
                schedule = scheduleRow
            };
            if (find == null)
            {
                context.Tasks.Add(taskModel);
            }
            else
            {
                find.Name = taskModel.Name;
                find.Databases = taskModel.Databases;
                find.Path = taskModel.Path;
                find.schedule = taskModel.schedule;
                find.ServerName = taskModel.ServerName;
            }
            context.SaveChanges();
        }
        public TaskData GetTask(int id)
        {
            
            var item = context.Tasks.Include("Schedule").Where(x => x.TaskModelID == id).FirstOrDefault();
            DatabasesManager manager = new DatabasesManager(item.ServerName,"","");
            var task = new TaskData()
            {
                ID = item.TaskModelID,
                Name = item.Name,
                BackupData = new BackupData()
                {
                    AllDatabases = manager.DatabasesList,
                    DatabasesToBackup = item.Databases.Split(';').ToList<string>(),
                    Path = item.Path
                },
                LoginData = new LoginData()
                {
                    ServerName = item.ServerName
                },
                ScheduleID = item.schedule.ScheduleModelID,
                Schedule = new ScheduleData()
                {
                    ID = item.schedule.ScheduleModelID,
                    Description = item.schedule.Name,
                    Cron = item.schedule.Cron
                }
            };
            return task;
        }
        public void DeleteTask(int id)
        {
            var task = context.Tasks.Find(id);
            if (task != null) 
            {
                context.Tasks.Remove(task);
                context.SaveChanges();
            }
        }
    }
}
