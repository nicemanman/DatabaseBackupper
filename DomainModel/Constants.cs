using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Constants
    {
        public const int PathsCountRememberValue = 5;
        public enum SchedulePeriodics { Minutes, Hours, Weeks, Days };
        private static Dictionary<string, SchedulePeriodics> SchedulePeriodicsDict = new Dictionary<string, SchedulePeriodics>();
        static Constants() 
        {
            SchedulePeriodicsDict.Add("Минутная", SchedulePeriodics.Minutes);
            SchedulePeriodicsDict.Add("Часовая", SchedulePeriodics.Hours);
            SchedulePeriodicsDict.Add("Недельная", SchedulePeriodics.Weeks);
            SchedulePeriodicsDict.Add("Дневная", SchedulePeriodics.Days);
        }

        public static List<string> GetListOfSchedulePeriodics() 
        {
            return SchedulePeriodicsDict.Keys.ToList();
        }

        public static SchedulePeriodics GetItem(string periodic) 
        {
            return SchedulePeriodicsDict[periodic];
        }
        
    }
}
