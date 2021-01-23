using DomainModel.Components.CronBox;
using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.ReadableEnumeration;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;
using Quartz;
using DomainModel.Components.DatabaseRepository.DatabaseModels;

namespace DomainModel.Services
{
    public class ScheduleDetailsService : IScheduleDetailsService
    {
        private IDatabaseController databaseController;

        List<string> cronExpressionTypes;
        ReadableEnumeration<CronExpressionType> cronExpressionTypesReadable;

        List<string> daysReadable;
        ReadableEnumeration<DaysOfWeek> daysOfWeekReadable;
        public ScheduleDetailsService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
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

        public ScheduleDetailsModel GetCronExpression(int id)
        {
            throw new NotImplementedException();
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

        public void SaveCronExpression(ScheduleDetailsModel model)
        {
            string expression = "";
            var daysFlags = GetSetOfValuesAsFlags(model.selectedDays);
            switch (model.cronExpressionType)
            {
                case CronExpressionType.EveryNMinutes:
                    expression = CronExpressionManager.EveryNMinutes(model.minutes);
                    break;
                case CronExpressionType.EveryNHours:
                    expression = CronExpressionManager.EveryNHours(model.hours);
                    break;
                case CronExpressionType.EveryDayAt:
                    expression = CronExpressionManager.EveryDayAt(model.hours, model.minutes);
                    break;
                case CronExpressionType.EverySpecificDayAt:
                    expression = CronExpressionManager.EverySpecificWeekDayAt(model.hours, model.minutes, daysFlags);
                    break;
            }
            try
            {
                CronExpression.ValidateExpression(expression);
            }
            catch (Exception ex) 
            {
                throw new Exception("Внутренняя ошибка при формировании cron выражения!");
            }
            var days = CronConverter.ToCronRepresentation(daysFlags);
            Schedule dbModel = new Schedule()
            {
                Name = model.Name,
                Cron = expression,
                Minutes = model.minutes.ToString(),
                Hours = model.hours.ToString(),
                Days = days
            };

            databaseController.scheduleRepository.Add(dbModel);
            databaseController.Complete();
        }

        private DaysOfWeek GetSetOfValuesAsFlags(List<string> selectedReadableValues)
        {

            DaysOfWeek enumItem = default(DaysOfWeek);
            int index = 0;
            foreach (string item in selectedReadableValues)
            {
                DaysOfWeek enumFound = daysOfWeekReadable.GetEnumItem(item);
                if (index == 0)
                {
                    enumItem = enumFound;
                }
                else
                {
                    enumItem = enumItem | enumFound;
                }
                index++;
            }
            return enumItem;


        }
    }
}
