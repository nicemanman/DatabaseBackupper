using DatabaseBackupperWindowsLibrary.Models;
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
        private List<TaskData> tasks = new List<TaskData>();
        private Logger logger = LogManager.GetCurrentClassLogger();
        public TaskData this[int index] 
        {
            get => tasks[index];
        }
        public TasksManager()
        {
            BuildTasksQueue();
        }
        public int Count() 
        {
            return tasks.Count();
        }
        public List<TaskData> GetAllOfThem() 
        {
            return tasks;
        }
        public void BuildTasksQueue() 
        {

            if (File.Exists(@"TaskData.json"))
                using (StreamReader file = File.OpenText(@"TaskData.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    tasks = (List<TaskData>)serializer.Deserialize(file, typeof(List<TaskData>));
                }
            
        }
        
        public void AddTask(TaskData task) 
        {
            var find = tasks.FindIndex(x => x.ID == task.ID);
            if (find == -1)
            {
                tasks.Add(task);
            }
            else 
            {
                tasks.RemoveAt(find);
                tasks.Add(task);
            }
            using (StreamWriter file = File.CreateText(@"TaskData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, tasks);
                logger.Info($"Успешно записали данные в файл TaskData.json");
            }
        }
        public TaskData GetTask(Guid guid)
        {
            var index = tasks.FindIndex(x => x.ID == guid);
            return tasks[index];
        }
        public void DeleteTask(Guid guid)
        {
            var index = tasks.FindIndex(x => x.ID == guid);
            if (index == -1) 
            {
                return;
            }
            tasks.RemoveAt(index);
            using (StreamWriter file = File.CreateText(@"TaskData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, tasks);
                logger.Info($"Успешно записали данные в файл LoginData.json");
            }
        }
    }
}
