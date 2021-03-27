using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakeLoginService : ILoginService
    {
        public Task<BackupModel> ConnectToSqlServer(LoginModel model)
        {
            throw new NotImplementedException();
        }

        public Enums.LoginTypesEnumeration GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<string> GetLoginTypes()
        {
            throw new NotImplementedException();
        }

        public List<string> GetSqlServers()
        {
            throw new NotImplementedException();
        }
    }
}
