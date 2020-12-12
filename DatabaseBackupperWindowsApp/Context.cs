using DatabaseBackupperWindowsLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsApp
{
    public static class Context
    {
        public static BackupData backupData;
        public static BackupData loginData;
        public static BackupData scheduleData;
        public static BackupData taskData;
    }
}
