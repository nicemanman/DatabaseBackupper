﻿using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface ITaskService
    {
        event Action UpdateTasksList;
        Task SaveTask(TaskModel taskModel);
        List<TaskModel> GetAllTasks();
        Task RemoveTask(int id);
    }
}