using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class ConnectionManager
    {
        public string GetCurrentWindowsUser() 
        {
            return Environment.UserDomainName;
        }
    }
}
