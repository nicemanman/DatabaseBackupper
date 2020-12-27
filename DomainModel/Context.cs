using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public static class Context
    {
        private static string DatabaseConnectionString { get; set; } = "";
        public static void SetDBConnectionString(string connectionString) 
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
                DatabaseConnectionString = connectionString;
        }
        public static string GetDBConnectionString()
        {
            return DatabaseConnectionString;
        }
        public static void RemoveDatabaseConnectionString() 
        {
            DatabaseConnectionString = "";
        }
    }
}
