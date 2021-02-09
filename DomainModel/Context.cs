using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public static class Context
    {
        private static string ServerInstanceName { get; set; } = "";
        private static string DatabaseConnectionString { get; set; } = "";
        public static BackupModel backupModel { get; set; }
        public static void SetDBConnectionString(string connectionString) 
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
                DatabaseConnectionString = connectionString;
        }
        public static void SetServerInstance(string serverInstance)
        {
            if (!string.IsNullOrWhiteSpace(serverInstance))
                ServerInstanceName = serverInstance;
        }
        public static string GetDBConnectionString()
        {
            return DatabaseConnectionString;
        }
        public static string GetServerInstanceName()
        {
            return ServerInstanceName;
        }
        public static void RemoveDatabaseConnectionString() 
        {
            DatabaseConnectionString = "";
        }
        public static void RemoveServerInstanceName()
        {
            ServerInstanceName = "";
        }
    }
}
