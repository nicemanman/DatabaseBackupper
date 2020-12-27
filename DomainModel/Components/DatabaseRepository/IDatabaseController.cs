using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public interface IDatabaseController
    {
        IJobRepository jobRepository { get; set; }
        IScheduleRepository scheduleRepository { get; set; }
        Task Complete();
        void Initialize();
    }
}
