using DomainModel.Components.DatabaseRepository.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    /// <summary>
    /// Определяет методы, специфичные для работы с расписаниями
    /// </summary>
    public interface IScheduleRepository : IGenericRepository<Schedule>
    {
    }
}
