using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Components.ReadableEnumeration;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services.FakeServices
{
    public class FakeScheduleService : IScheduleService
    {
        
        List<string> cronExpressionTypes;
        ReadableEnumeration<CronExpressionType> cronExpressionTypesReadable;

        List<string> daysReadable;
        ReadableEnumeration<DaysOfWeek> daysOfWeekReadable;
        public FakeScheduleService()
        {
            cronExpressionTypes = new List<string>()
            {
                "Минутная периодичность",
                "Часовая периодичность",
                "Каждый день",
                "В определенные дни"
            };
            cronExpressionTypesReadable = new ReadableEnumeration<CronExpressionType>(cronExpressionTypes);

            daysReadable = new List<string>()
            {
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
                "Воскресенье"
            };
            daysOfWeekReadable = new ReadableEnumeration<DaysOfWeek>(daysReadable);
        }
        public Schedule ClientModelToDBModel(ScheduleModel model)
        {
            return null;
        }

        public ScheduleModel DBModelToClientModel(Schedule item)
        {
            return null;
        }

        public List<ScheduleModel> GetAllSchedules()
        {
            return new List<ScheduleModel>() 
            {
                new ScheduleModel()
                {
                    Id = 1,
                    Name = "Каждый час",
                    CronExpression = "0 * * * *",
                    CronExpressionType = CronExpressionType.EveryNHours,
                    Hours = 0,
                    Minutes = 0,
                    SelectedDays = new List<string>(),
                    NextFireTimes = new List<string>()
                    {
                        "Следующее время выполнения"
                    }
                },
                new ScheduleModel()
                {
                    Id = 2,
                    Name = "Каждые 2 часа",
                    CronExpression = "0 */2 * * *",
                    CronExpressionType = CronExpressionType.EveryNHours,
                    Hours = 0,
                    Minutes = 0,
                    SelectedDays = new List<string>(),
                    NextFireTimes = new List<string>()
                    {
                        "Следующее время выполнения"
                    }
                },
                new ScheduleModel()
                {
                    Id = 3,
                    Name = "Каждые 3 часа",
                    CronExpression = "0 */3 * * *",
                    CronExpressionType = CronExpressionType.EveryNHours,
                    Hours = 0,
                    Minutes = 0,
                    SelectedDays = new List<string>(),
                    NextFireTimes = new List<string>()
                    {
                        "Следующее время выполнения"
                    }
                },
            };
        }

        public List<string> GetAllSchedulesNames()
        {
            return new List<string>()
            {
                "Каждый час","Каждые 2 часа","Каждые 3 часа"
            };
        }

        public CronExpressionType GetCronTypeByName(string name)
        {
            return cronExpressionTypesReadable.GetEnumItem(name);
        }

        public DaysOfWeek GetDayTypeByName(string name)
        {
            return daysOfWeekReadable.GetEnumItem(name);
        }

        public List<string> GetListOfDays()
        {
            return daysOfWeekReadable.GetReadableList();
        }

        public List<string> GetListOfPeriodics()
        {

            return cronExpressionTypesReadable.GetReadableList();
        }

        public string GetNameByCronType(CronExpressionType type)
        {
            return cronExpressionTypesReadable.GetEnumItemName(type);
        }

        public List<string> GetNextValidTimesAfter(string name)
        {
            return new List<string>() { "Первое время выполнения задачи", "Второе время выполнения задачи" };
        }

        public Task RemoveSchedule(int id)
        {
            return Task.CompletedTask;
        }

        public Task SaveCronExpression(ScheduleModel model)
        {
            return Task.CompletedTask;
        }
    }
}
