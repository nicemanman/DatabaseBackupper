using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Models
{
    public class ScheduleDetailsModel
    {
        public string Name;
        public CronExpressionType cronExpressionType;
        public int minutes;
        public int hours;
        public List<string> selectedDays;
    }
}
