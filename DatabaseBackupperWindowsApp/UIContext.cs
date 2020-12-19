using DatabaseBackupperWindowsLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsApp
{
    public static class UIContext
    {
        public static BackupData currentBackupData;
        public static LoginData currentLoginData;
        public static ScheduleData scheduleData;
        public static TaskData taskData;
    }
}
