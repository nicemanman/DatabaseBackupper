using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class BackupModel
    {
        public string PathToBackup { get; set; }
        public List<string> AllDatabases { get; set; } = new List<string>();
        public List<string> DatabasesToBackup { get; set; } = new List<string>();
        
    }
}

