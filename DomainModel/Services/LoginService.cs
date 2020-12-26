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

namespace DomainModel.Services
{
    
    public class LoginService : ILoginService
    {
        public async Task<BackupModel> ConnectToDatabase(LoginModel model)
        {
            var SystemDatabases = new List<string>() { "master", "msdb", "model", "resource", "tempdb" };
            var list = new List<String>();
            var IntegratedSecurity = "False";
            if (model.LoginType == Enums.LoginTypesEnumeration.Windows)
                IntegratedSecurity = "True";
            var connectionString = $"Data Source={model.Servername}; User ID={model.Username}; Password={model.Password}; Integrated Security={IntegratedSecurity};";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    await con.OpenAsync();
                }
                catch (Exception ex) 
                {
                    return null;
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
                return backupModel;
            }
        }

        public List<Enum> GetLoginTypes()
        {
            return SelectList.Of<Enums.LoginTypesEnumeration>();
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
    }
}
