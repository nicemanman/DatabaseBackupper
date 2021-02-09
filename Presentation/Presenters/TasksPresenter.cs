using DomainModel.Models;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class TasksPresenter : BasePresenter<ITasksView>
    {
        private readonly ITaskService taskService;
        private readonly IBackupService backupService;
        private readonly List<TaskModel> tasks;
        public TasksPresenter(IApplicationController controller, ITasksView view, ITaskService taskService, IBackupService backupService) : base(controller, view)
        {
            this.taskService = taskService;
            tasks = taskService.GetAllTasks();
            View.Tasks = tasks;
            View.RemoveTask += async (id) => await View_RemoveTask(id);
            View.OpenTask += View_OpenTask;
            View.Reload += View_Reload;
            View.CreateNewJobAction += View_CreateNewTaskAction;
            View.Show();
            this.backupService = backupService;
        }

        private void View_CreateNewTaskAction()
        {
            var model = new TaskModel()
            {
                AllDatabases = backupService.GetAllDatabases(),
                SelectedDatabases = new List<string>(),
                Name = "Создать новую задачу",
                SQLServer = backupService.GetCurrentSQLServerInstanceName()
            };
            Controller.Run<TaskDetailsPresenter, TaskModel>(model);
        }

        private void View_Reload()
        {
            View.Tasks = taskService.GetAllTasks();
        }

        private void View_OpenTask(int obj)
        {
            
            var model = taskService.GetAllTasks().Where(x => x.Id == obj).FirstOrDefault();
            Controller.Run<TaskDetailsPresenter, TaskModel>(model);
        }

        private async Task View_RemoveTask(int id)
        {
            await taskService.RemoveTask(id);
        }
        
    }
}
