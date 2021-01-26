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
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public CronExpressionType CronExpressionType { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }
        public List<string> SelectedDays { get; set; }
        public string CronExpression { get; set; }
    }
}
