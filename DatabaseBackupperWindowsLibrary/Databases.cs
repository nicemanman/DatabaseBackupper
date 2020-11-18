using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupper
{
    public class Databases
    {
        private List<string> DatabasesList = new List<string>();
        private List<string> DatabasesToBackup = new List<string>();
        private List<string> SystemDatabases = new List<string>(){"master","msdb","model","resource","tempdb" };
        public string Path { get; private set; }
        public int Length { get => DatabasesList.Count; }
        private string ServerName { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        Logger logger = LogManager.GetCurrentClassLogger();

        public Databases(string serverName, string userName, string password)
        {
            ServerName = serverName;
            UserName = userName;
            Password = password;
            DatabasesList = GetAllOfThem();
        }

        public string this[int index]
        {
            get => DatabasesList[index];
        }

 

        private List<string> GetAllOfThem()
        {
            var list = new List<String>();
            string connectionString = $"Data Source={ServerName}; User ID={UserName}; Password={Password}; Integrated Security=True;";
            logger.Info($"Connection string: \"{connectionString}\"");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                logger.Info("Подключение открыто.");
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    logger.Info(cmd.CommandText);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var name = dr[0].ToString();
                            if (!SystemDatabases.Contains(name))
                                list.Add(dr[0].ToString());
                            logger.Info(name);
                        }
                    }
                    logger.Info("Подключение закрыто.");
                }
                
                return list;
            }
        }

        

       
        public Task Backup(string database, string path) 
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or empty", nameof(path));
            }
            if (string.IsNullOrEmpty(database))
            {
                throw new ArgumentException($"'{nameof(database)}' cannot be null or empty", nameof(database));
            }
            var result = 0;
            string connectionString = $"Data Source={ServerName}; User ID={UserName}; Password={Password}; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"BACKUP DATABASE [{database}] TO  DISK = '{path}\\{database}{DateTime.Now.ToString().Replace(":",".")}.bak'", con))
                {
                    result += cmd.ExecuteNonQuery();
                }
            }
            return Task.CompletedTask;
        }
    }
}
