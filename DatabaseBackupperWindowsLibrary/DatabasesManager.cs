using DatabaseBackupperWindowsLibrary;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupper
{
    public class DatabasesManager
    {
        public AppDbContext context;
        public List<string> DatabasesList = new List<string>();
        public List<string> DatabasesToBackup = new List<string>();
        private List<string> SystemDatabases = new List<string>(){"master","msdb","model","resource","tempdb" };
        public string Path { get; private set; }
        public int Length { get => DatabasesList.Count; }
        private string ServerName { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private static string ConnectionString { get; set; }
       
        Logger logger = LogManager.GetCurrentClassLogger();

        public DatabasesManager(string serverName, string userName, string password)
        {
            ServerName = serverName;
            UserName = userName;
            Password = password;
            ConnectionString = $"Data Source={ServerName}; User ID={UserName}; Password={Password}; Integrated Security=True;";
        }

        public Task InitStorage() 
        {
            context = new AppDbContext();
            return Task.CompletedTask;
        }
        public string this[int index]
        {
            get => DatabasesList[index];
        }

        public async Task<List<string>> GetAllOfThem()
        {
            var list = new List<String>();
            logger.Info($"Connection string: \"{ConnectionString}\"");
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                await con.OpenAsync();
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

        

       
        public Task Backup(string database, string path, IProgress<string> progress) 
        {
            
            var dateNow = DateTime.Now.ToShortDateString();
            var timeNow = DateTime.Now.ToLongTimeString();
            path += "\\" + dateNow + "\\" + database;
            var databaseFileName = database + " " + timeNow.Replace(":",".");
            Directory.CreateDirectory(path);
            
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or empty", nameof(path));
            }
            if (string.IsNullOrEmpty(database))
            {
                throw new ArgumentException($"'{nameof(database)}' cannot be null or empty", nameof(database));
            }
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand($"BACKUP DATABASE [{database}] TO  DISK = '{path}\\{databaseFileName}.bak'", con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    progress.Report($"{database} - OK");
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    progress.Report($"{database} - Error");
                }
            }
            
            
            return Task.CompletedTask;
        }
    }
}
