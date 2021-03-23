using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
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
        
        private readonly IDatabaseController databaseController;
        private readonly IScheduleService scheduleService;
        private List<ScheduleModel> schedules;
        public TaskService(IDatabaseController databaseController, IScheduleService scheduleService)
        {
            this.databaseController = databaseController;
            this.scheduleService = scheduleService;
            schedules = scheduleService.GetAllSchedules();
        }

        public async Task SaveTask(TaskModel model)
        {
            
            var JobModel = ClientModelToDBModel(model);
            var findItem = databaseController.jobRepository.Get(model.Id);
            if (findItem == null)
                databaseController.jobRepository.Add(JobModel);
            else 
            {
                findItem.ScheduleID = JobModel.ScheduleID;
                findItem.ServerName = JobModel.ServerName;
                findItem.Databases = string.Join(",", model.SelectedDatabases);
                findItem.EmailToNotify = model.SelectedEmail;
                findItem.Path = model.SelectedPath;
                findItem.NotifyAboutFinish = model.NotifyAboutFinish;
                findItem.IsEnabled = model.Enabled;
                findItem.Name = model.Name;

            }
            await databaseController.CompleteAsync();
            WindowsServiceEvents.TaskSaved();
        }

        private TaskModel DBModelToClientModel(Job job) 
        {
            var clientModel = new TaskModel()
            {
                Id = job.Id,
                AllDatabases = Context.backupModel?.AllDatabases ?? new List<string>(),
                Enabled = job.IsEnabled,
                Name = job.Name,
                NotifyAboutFinish = job.NotifyAboutFinish,
                SelectedDatabases = job.Databases.Split(',').ToList<string>(),
                SelectedEmail = job.EmailToNotify,
                SelectedPath = job.Path,
                SQLServer = job.ServerName,
                SelectedSchedule = scheduleService.GetAllSchedules().Where(x => x.Id == job.ScheduleID).FirstOrDefault()
            };
            return clientModel;
        }
        private Job ClientModelToDBModel(TaskModel model)
        {
            var JobModel = new Job()
            {
                ServerName = model.SQLServer,
                Databases = string.Join(",", model.SelectedDatabases),
                EmailToNotify = model.SelectedEmail,
                Path = model.SelectedPath,
                NotifyAboutFinish = model.NotifyAboutFinish,
                IsEnabled = model.Enabled,
                Name = model.Name,
                ScheduleID = model.SelectedSchedule.Id
            };
            
            return JobModel;
        }

        public List<TaskModel> GetAllTasks(bool service = false)
        {
            List<Job> result;
            if (service)
                result = databaseController.jobRepository.GetAll().ToList();
            else
                result = databaseController.jobRepository.GetAll().Where(x=>x.ServerName == Context.GetServerInstanceName()).ToList();
            
            List<TaskModel> clientList = new List<TaskModel>();
            foreach (var item in result)
            {
                
                var model = DBModelToClientModel(item);
                clientList.Add(model);
            }
            return clientList;
        }
        public async Task RemoveTask(int id)
        {
            var model = databaseController.jobRepository.Get(id);
            if (model == null)
            {
                throw new Exception("Задача не найдена, попробуйте обновить список, возможно, она уже была удалена");
            }
            databaseController.jobRepository.Remove(model);
            await databaseController.CompleteAsync();
        }
    }
}
