using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public enum LoginTypesEnumeration { Windows, SQL };
    public class LoginService : ILoginService
    {
        public List<Enum> GetLoginTypes()
        {
            return SelectList.Of<LoginTypesEnumeration>();
        }

        public List<string> GetSqlServers(bool localOnly)
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
