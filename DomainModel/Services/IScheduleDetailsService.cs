using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services
{
    public interface IScheduleService
    {
        List<string> GetListOfPeriodics();
        CronExpressionType GetCronTypeByName(string name);
        string GetNameByCronType(CronExpressionType type);
        List<string> GetListOfDays();
        DaysOfWeek GetDayTypeByName(string name);
        Task SaveCronExpression(ScheduleModel model);
        Task RemoveSchedule(int id);
        List<ScheduleModel> GetAllSchedules();
        List<string> GetAllSchedulesNames();
        List<string> GetNextValidTimesAfter(string name);
        Schedule ClientModelToDBModel(ScheduleModel model);
        ScheduleModel DBModelToClientModel(Schedule item);
    }
}
