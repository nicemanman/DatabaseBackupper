using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakeScheduleService : IScheduleService
    {
        public Schedule ClientModelToDBModel(ScheduleModel model)
        {
            throw new NotImplementedException();
        }

        public ScheduleModel DBModelToClientModel(Schedule item)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleModel> GetAllSchedules()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllSchedulesNames()
        {
            throw new NotImplementedException();
        }

        public Enums.CronExpressionType GetCronTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public Enums.DaysOfWeek GetDayTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<string> GetListOfDays()
        {
            throw new NotImplementedException();
        }

        public List<string> GetListOfPeriodics()
        {
            throw new NotImplementedException();
        }

        public string GetNameByCronType(Enums.CronExpressionType type)
        {
            throw new NotImplementedException();
        }

        public List<string> GetNextValidTimesAfter(string name)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSchedule(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveCronExpression(ScheduleModel model)
        {
            throw new NotImplementedException();
        }
    }
}
