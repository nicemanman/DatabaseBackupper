using DomainModel.Components.DatabaseRepository;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public class TaskService : ITaskService
    {
        public event Action UpdateTasksList;
        private readonly IDatabaseController databaseController;

        public TaskService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
        }

        public async Task SaveTask(TaskModel model)
        {
            
        }
    }
}
