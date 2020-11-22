using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary.Models
{
    public class BackupData
    {
        public string Path { get; set; }
        public List<string> AllDatabases { get; set; }
        public List<string> DatabasesToBackup { get; set; }
    }
}
