using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services
{
    public interface ILoginService
    {
        List<string> GetSqlServers();
        List<string> GetLoginTypes();
        Task<BackupModel> ConnectToSqlServer(LoginModel model);
        LoginTypesEnumeration GetByName(string name);
    }
}
