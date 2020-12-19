using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsLibrary
{
    public class DefaultEnums
    {
        public enum ConnectionTypes 
        {
            SQLServer,
            Windows
        }
    }

    public class Constants 
    {
        public static string DatabaseCreationPath = "C:\\Data";
    }
}
