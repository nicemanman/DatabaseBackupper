using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface ITaskService
    {
        
        Task SaveTask(TaskModel taskModel);
        List<TaskModel> GetAllTasks(bool service = false);
        Task RemoveTask(int id);
    }
}
