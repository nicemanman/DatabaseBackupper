using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakeTaskService : ITaskService
    {
        public List<TaskModel> GetAllTasks(bool service = false)
        {
            return new List<TaskModel>() 
            {
                new TaskModel()
                {
                    Id = 1,
                    AllDatabases = new List<string>()
                    {
                        "База данных 1","База данных 2","База данных 3","База данных 4"
                    },
                    Enabled = true,
                    Name = "Тестовая задача для бэкапа баз данных",
                    SelectedDatabases = new List<string>()
                    {
                        "База данных 1","База данных 2"
                    },
                    SelectedEmail = "ilya.falko2013@gmail.com",
                    SelectedPath = "Путь для бэкапа",
                    SelectedSchedule = new ScheduleModel()
                    {
                        Id = 1,
                        Name = "Каждый час"
                    },
                    SQLServer = "Текущий SQL сервер"
                }
            };
        }

        public Task RemoveTask(int id)
        {
            return Task.CompletedTask;
        }

        public Task SaveTask(TaskModel taskModel)
        {
            return Task.CompletedTask;
        }
    }
}
