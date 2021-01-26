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
    public class SchedulesPresenter : BasePresenter<ISchedulesView>
    {
        private readonly IScheduleService service;
        private List<ScheduleDetailsModel> scheduleModels;
        public SchedulesPresenter(IApplicationController controller, ISchedulesView view, IScheduleService service) : base(controller, view)
        {
            this.service = service;
            scheduleModels = service.GetAllSchedules();
            View.Schedules = scheduleModels;
            View.Reload += View_Reload;
            View.RemoveSchedule += async (id) => await View_RemoveSchedule(id);
            View.OpenSchedule += View_OpenSchedule;
            View.CreateNewScheduleAction += View_CreateNewScheduleAction;
        }

        private void View_CreateNewScheduleAction()
        {
            Controller.Run<ScheduleDetailsPresenter, ScheduleDetailsModel>(new ScheduleDetailsModel());
        }

        private void View_OpenSchedule(int obj)
        {
            var model = scheduleModels.Where(x => x.Id == obj).FirstOrDefault();
            Controller.Run<ScheduleDetailsPresenter, ScheduleDetailsModel>(model);
        }

        private async Task View_RemoveSchedule(int id)
        {
            await service.RemoveSchedule(id);
        }

        private void View_Reload()
        {
            scheduleModels = service.GetAllSchedules();
            View.Schedules = scheduleModels;
        }
    }
}
