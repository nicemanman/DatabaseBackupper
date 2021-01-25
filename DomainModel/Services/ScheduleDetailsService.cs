﻿using DomainModel.Components.CronBox;
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

        public List<ScheduleDetailsModel> GetAllSchedules()
        {
            var result = databaseController.scheduleRepository.GetAll().ToList();
            List<ScheduleDetailsModel> clientList = new List<ScheduleDetailsModel>();
            foreach (var item in result)
            {
                ScheduleDetailsModel model = new ScheduleDetailsModel()
                {
                    CronExpressionType = (CronExpressionType)item.CronTypeExpressionId,
                    Id = item.Id,
                    Name = item.Name,
                    Hours = item.Hours,
                    Minutes = item.Minutes,
                    SelectedDays = GetSpecificDaysList(item.Days)
                };
                
                clientList.Add(model);
            }
            return clientList;
        }

        public void RemoveSchedule(int id)
        {
            var model = databaseController.scheduleRepository.Get(id);
            if (model == null) 
            {
                throw new Exception("Расписание не найдено, попробуйте обновить список, возможно, оно уже было удалено");
            }
            databaseController.scheduleRepository.Remove(model);
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
            try
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
                    CronTypeExpressionId = (int)model.CronExpressionType
                };

                databaseController.scheduleRepository.Add(dbModel);
                databaseController.Complete();
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
    }
}