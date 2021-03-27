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
            throw new NotImplementedException();
        }

        public Task RemoveTask(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveTask(TaskModel taskModel)
        {
            throw new NotImplementedException();
        }
    }
}
