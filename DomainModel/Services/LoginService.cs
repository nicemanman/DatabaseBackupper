using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.GoogleClient;
using DomainModel.Components.ReadableEnumeration;
using DomainModel.Models;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services
{

    public class LoginService : ILoginService
    {
        private IDatabaseController databaseController;
        
        private List<string> LoginTypesNames = new List<string>() { "Аутентификация Windows","Аутентификация сервера MS SQL" };
        private ReadableEnumeration<LoginTypesEnumeration> loginTypesReadableList;
        public LoginService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
            loginTypesReadableList = new ReadableEnumeration<LoginTypesEnumeration>(LoginTypesNames); 
        }

        public async Task<BackupModel> ConnectToSqlServer(LoginModel model)
        {
            var SystemDatabases = new List<string>() { "master", "msdb", "model", "resource", "tempdb" };
            var list = new List<String>();
            var IntegratedSecurity = "False";
            if (loginTypesReadableList.GetEnumItem(model.LoginType) == LoginTypesEnumeration.Windows)
                IntegratedSecurity = "True";
            var connectionString = $"Data Source={model.Servername}; User ID={model.Username}; Password={model.Password}; Integrated Security={IntegratedSecurity};";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    await con.OpenAsync();
                    SetSqlServerConnection(connectionString, model);
                    //await Task.Run(() => databaseController.Initialize());
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
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
                var backupModel = new BackupModel();
                backupModel.AllDatabases = list;
                Context.backupModel = backupModel;
                return backupModel;
            }
        }

        private void SetSqlServerConnection(string connectionString, LoginModel model) 
        {
            Context.SetDBConnectionString(connectionString);
            Context.SetServerInstance(model.Servername);
        }
        public List<string> GetLoginTypes()
        {
            return loginTypesReadableList.GetReadableList();
        }

        public List<string> GetSqlServers()
        {
            
            string ServerName = Environment.MachineName;
            List<string> list = new List<string>();
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        list.Add(ServerName + "\\" + instanceName);
                    }
                }
            }
            return list;
        }

        public LoginTypesEnumeration GetByName(string name)
        {
            return loginTypesReadableList.GetEnumItem(name);
        }

        
    }
}
