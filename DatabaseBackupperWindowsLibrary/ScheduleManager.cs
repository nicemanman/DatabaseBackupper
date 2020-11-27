using DatabaseBackupperWindowsLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class ScheduleManager
    {
        public List<ScheduleData> GetAllOfThem() 
        {
            List<ScheduleData> schedules = new List<ScheduleData>();
            if (File.Exists(@"ScheduleData.json"))
                using (StreamReader file = File.OpenText(@"ScheduleData.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    schedules = (List<ScheduleData>)serializer.Deserialize(file, typeof(List<ScheduleData>));
                }
            return schedules;
        }
    }
}
