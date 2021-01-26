using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace Presentation.Views
{
    public interface IScheduleDetailsView : IView
    {
        string Caption { get; set; }
        int Minutes { get; set; }
        int Hours { get; set; }
        List<string> days { get; set; }
        List<string> selectedDays { get; set; }
        List<string> SchedulePeriodics { set; }
        string SelectedPeriodic { get; set; }
        void ShowError(string text);
        /// <summary>
        /// Установить интерфейс определенной периодичности
        /// </summary>
        /// <param name="type"></param>
        void SetSchedule(CronExpressionType type);
        /// <summary>
        /// Получить выбранное расписание с формы
        /// </summary>
        /// <returns></returns>
        string GetSchedule();
        int Id { get; set; }
        event Action OnPeriodicChanged;
        event Action SaveButtonPressed;
    }
}
