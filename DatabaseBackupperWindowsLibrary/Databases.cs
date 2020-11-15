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
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var name = dr[0].ToString();
                            if (!SystemDatabases.Contains(name))
                                list.Add(dr[0].ToString());
                        }
                    }
                }
                return list;
            }
        }

        public void SetSettings(List<string> databasesToBackup, string path) 
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or empty", nameof(path));
            }

            DatabasesToBackup = databasesToBackup ?? throw new ArgumentNullException(nameof(databasesToBackup));
            Path = path;
        }

       
        public int Backup() 
        {
            var result = 0;
            foreach (var database in DatabasesToBackup)
            {
                string connectionString = $"Data Source={ServerName}; User ID={UserName}; Password={Password}; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand($"BACKUP DATABASE [{database}] TO  DISK = '{Path}\\{database}{Guid.NewGuid().ToString()}.bak'", con))
                    {
                        con.Open();
                        result += cmd.ExecuteNonQuery();
                    }
                }
            }
            return result;
        }
    }
}
