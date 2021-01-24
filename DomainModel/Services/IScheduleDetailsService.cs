using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services
{
    public interface IScheduleDetailsService
    {
        List<string> GetListOfPeriodics();
        CronExpressionType GetCronTypeByName(string name);

        List<string> GetListOfDays();
        DaysOfWeek GetDayTypeByName(string name);
        void SaveCronExpression(ScheduleDetailsModel model);
        void RemoveSchedule(int id);
        List<ScheduleDetailsModel> GetAllSchedules();
    }
}
