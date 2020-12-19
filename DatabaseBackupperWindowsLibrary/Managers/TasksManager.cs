using DatabaseBackupperWindowsLibrary.DatabaseModels;
using DatabaseBackupperWindowsLibrary.ViewModels;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.Managers
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
            BuildTasksQueue();
        }
        public int Count() 
        {
            using (context = new AppDbContext()) 
            {
                var result = context.Tasks.Count();
                return result;
            }
        }
        public List<TaskData> GetAllOfThem() 
        {
            using (context = new AppDbContext()) 
            {
                
                var taskModels = context.Tasks.Include("Schedule").ToList();
                List<TaskData> tasks = new List<TaskData>();
                foreach (var item in taskModels)
                {
                    var task = new TaskData()
                    {
                        ID = item.Id,
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
                        ScheduleID = item.schedule.Id,
                        Schedule = new ScheduleData() 
                        {
                            ID = item.schedule.Id,
                            Description = item.schedule.Name,
                            Cron = item.schedule.Cron
                        }
                    };
                    tasks.Add(task);
                }
                return tasks;
            }
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
            using (context = new AppDbContext()) 
            {
                var find = context.Tasks.Find(task.ID);
                var scheduleRow = context.Schedules.Find(task.ScheduleID);
                var taskModel = new Job()
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
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex) 
                {
                    throw ex;
                }
            }
            
        }
        public TaskData GetTask(int id)
        {
            using (context = new AppDbContext()) 
            { 
                var item = context.Tasks.Include("Schedule").Where(x => x.Id == id).FirstOrDefault();
                DatabasesManager manager = new DatabasesManager(item.ServerName,"","");
                var task = new TaskData()
                {
                    ID = item.Id,
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
                    ScheduleID = item.schedule.Id,
                    Schedule = new ScheduleData()
                    {
                        ID = item.schedule.Id,
                        Description = item.schedule.Name,
                        Cron = item.schedule.Cron
                    }
                };
                return task;
            }
        }
        public void DeleteTask(int id)
        {
            using (context = new AppDbContext()) 
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
}
