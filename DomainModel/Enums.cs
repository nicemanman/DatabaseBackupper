using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Enums
    {
        public enum LoginTypesEnumeration { Windows,SQL };
        public enum CronExpressionType
        {
            EveryNMinutes,
            EveryNHours,
            EveryDayAt,
            EverySpecificDayAt,
        }

        [Flags]
        public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64,
        }
    }
}
