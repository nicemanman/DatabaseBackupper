using DomainModel.Components.ReadableEnumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services
{
    public class ScheduleDetailsService : IScheduleDetailsService
    {
        
        List<string> cronExpressionTypes;
        ReadableEnumeration<CronExpressionType> cronExpressionTypesReadable;

        List<string> daysReadable;
        ReadableEnumeration<DaysOfWeek> daysOfWeekReadable;
        public ScheduleDetailsService()
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
    }
}
