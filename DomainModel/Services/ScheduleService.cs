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
    public class ScheduleService : IScheduleService
    {
        private IDatabaseController databaseController;
        private int validDateTimesAfterNowCount =7;
        List<string> cronExpressionTypes;
        ReadableEnumeration<CronExpressionType> cronExpressionTypesReadable;

        List<string> daysReadable;
        ReadableEnumeration<DaysOfWeek> daysOfWeekReadable;
        public ScheduleService(IDatabaseController databaseController)
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
        public List<string> GetAllSchedulesNames() 
        {
            var result = databaseController.scheduleRepository.GetAll().ToList();
            List<string> clientList = new List<string>();
            foreach (var item in result)
            {
                clientList.Add(item.Name);
            }
            return clientList;
        }
        public List<string> GetNextValidTimesAfter(string name) 
        {
            var allSchedules = GetAllSchedules();
            var cron = allSchedules.Where(x => x.Name == name).FirstOrDefault()?.CronExpression ?? "";
            CronExpression expression = new CronExpression(cron);
            var nextFire = expression.GetTimeAfter(DateTime.Now);
            List<string> nextDateTimes = new List<string>();
            for (int i = 0; i < validDateTimesAfterNowCount; i++)
            {
                if (nextFire.HasValue)
                {
                    nextFire = expression.GetNextValidTimeAfter(nextFire.Value).Value.ToLocalTime();
                    nextDateTimes.Add(nextFire.Value.ToString("G"));
                }
            }
            return nextDateTimes;
        }
        public List<ScheduleModel> GetAllSchedules()
        {
            var result = databaseController.scheduleRepository.GetAll().ToList();
            List<ScheduleModel> clientList = new List<ScheduleModel>();
            foreach (var item in result)
            {
                
                ScheduleModel model = DBModelToClientModel(item);
                
                clientList.Add(model);
            }
            return clientList;
        }

        public async Task RemoveSchedule(int id)
        {
            var model = databaseController.scheduleRepository.Get(id);
            if (model == null) 
            {
                throw new Exception("Расписание не найдено, попробуйте обновить список, возможно, оно уже было удалено");
            }
            databaseController.scheduleRepository.Remove(model);
            await databaseController.CompleteAsync();
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

        public async Task SaveCronExpression(ScheduleModel model)
        {
            try
            {
                Schedule dbModel = ClientModelToDBModel(model);
                var findItem = databaseController.scheduleRepository.Get(model.Id);
                if (findItem == null)
                    databaseController.scheduleRepository.Add(dbModel);
                else 
                {
                    findItem.Name = dbModel.Name;
                    findItem.Cron = dbModel.Cron;
                    findItem.Minutes = dbModel.Minutes;
                    findItem.Hours = dbModel.Hours;
                    findItem.Days = dbModel.Days;
                    findItem.CronTypeExpressionId = dbModel.CronTypeExpressionId;
                    findItem.Id = model.Id;
                }
                await databaseController.CompleteAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
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
        /// <summary>
        /// "MON,TUE,WED,THU,FRI,SAT,SUN" -> "Понедельник", "Вторник"...
        /// </summary>
        /// <param name="days">"MON,TUE,WED,THU,FRI,SAT,SUN"</param>
        /// <returns></returns>
        private List<string> GetSpecificDaysList(string days) 
        {
            if (string.IsNullOrWhiteSpace(days)) return new List<string>();
            List<string> specificDays = days.Split(',').ToList();
            List<string> representationDays = new List<string>();
            foreach (var item in specificDays)
            {
                representationDays.Add(GetSpecificDayRepresentation(item));
            }
            return representationDays;
        }
        private string GetSpecificDayRepresentation(string day) 
        {
            switch (day)
            {
                case "MON":
                    return daysReadable[0];
                case "TUE":
                    return daysReadable[1];
                case "WED":
                    return daysReadable[2];
                case "THU":
                    return daysReadable[3];
                case "FRI":
                    return daysReadable[4];
                case "SAT":
                    return daysReadable[5];
                case "SUN":
                    return daysReadable[6];
                default:
                    throw new ArgumentException();
            }
        }

        public string GetNameByCronType(CronExpressionType type)
        {
            return cronExpressionTypesReadable.GetEnumItemName(type);
        }

        public ScheduleModel DBModelToClientModel(Schedule item)
        {
            try
            {
                CronExpression expression = new CronExpression(item?.Cron);
                var nextFire = expression.GetTimeAfter(DateTime.Now);
                List<string> nextDateTimes = new List<string>();
                for (int i = 0; i < validDateTimesAfterNowCount; i++)
                {
                    if (nextFire.HasValue)
                    {
                        nextFire = expression.GetNextValidTimeAfter(nextFire.Value).Value.ToLocalTime();
                        nextDateTimes.Add(nextFire.Value.ToString("G"));
                    }
                }
                ScheduleModel model = new ScheduleModel()
                {
                    CronExpressionType = (CronExpressionType)item.CronTypeExpressionId,
                    Id = item.Id,
                    Name = item.Name,
                    Hours = item.Hours,
                    Minutes = item.Minutes,
                    SelectedDays = GetSpecificDaysList(item.Days),
                    CronExpression = item.Cron,
                    NextFireTimes = nextDateTimes
                };
                return model;
            }
            catch (Exception ex) 
            {
                return new ScheduleModel();
            }
            
        }
        public Schedule ClientModelToDBModel(ScheduleModel model)
        {
            string expression = "";
            string messages = "";
            if (string.IsNullOrEmpty(model.Name))
                messages += "Не задано название расписания!\n";
            var daysFlags = GetSetOfValuesAsFlags(model.SelectedDays);
            switch (model.CronExpressionType)
            {
                case CronExpressionType.EveryNMinutes:
                    if (model.Minutes == 0 || model.Minutes == 60)
                        throw new Exception("Укажите верное количество минут от 1 до 59!");
                    if (!string.IsNullOrWhiteSpace(messages))
                        throw new Exception(messages);
                    expression = CronExpressionManager.EveryNMinutes(model.Minutes);
                    break;
                case CronExpressionType.EveryNHours:
                    if (model.Hours == 0 || model.Hours == 24)
                        messages += "Укажите верное количество часов от 1 до 23!";
                    if (!string.IsNullOrWhiteSpace(messages))
                        throw new Exception(messages);
                    expression = CronExpressionManager.EveryNHours(model.Hours);
                    break;
                case CronExpressionType.EveryDayAt:
                    if (model.Minutes == 0 || model.Minutes == 60)
                        messages += "Укажите верное количество минут от 1 до 59!\n";
                    if (model.Hours == 0 || model.Hours == 24)
                        messages += "Укажите верное количество часов от 1 до 23!\n";
                    if (!string.IsNullOrWhiteSpace(messages))
                        throw new Exception(messages);
                    expression = CronExpressionManager.EveryDayAt(model.Hours, model.Minutes);
                    break;
                case CronExpressionType.EverySpecificDayAt:
                    if (model.Minutes == 0)
                        messages += "Укажите верное количество минут от 1 до 59!\n";
                    if (model.Hours == 0)
                        messages += "Укажите верное количество часов от 1 до 23!\n";
                    if (daysFlags == default(DaysOfWeek))
                        messages += "Выберите хотя бы один день!\n";
                    if (!string.IsNullOrWhiteSpace(messages))
                        throw new Exception(messages);

                    expression = CronExpressionManager.EverySpecificWeekDayAt(model.Hours, model.Minutes, daysFlags);
                    break;
            }
            try
            {
                CronExpression.ValidateExpression(expression);
            }
            catch (Exception ex)
            {
                throw new Exception($"Внутренняя ошибка при сохранении расписания!\n{ex.Message}");
            }
            var days = CronConverter.ToCronRepresentation(daysFlags);

            Schedule dbModel = new Schedule()
            {
                Name = model.Name,
                Cron = expression,
                Minutes = model.Minutes,
                Hours = model.Hours,
                Days = days,
                CronTypeExpressionId = (int)model.CronExpressionType,
                Id = model.Id
            };
            return dbModel;
        }
    }
}
