using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface ILoginService
    {
        List<string> GetSqlServers();
        List<Enum> GetLoginTypes();

        Task<BackupModel> ConnectToDatabase(LoginModel model);
        
    }
}
