using DomainModel.Components.ReadableEnumeration;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace DomainModel.Services.FakeServices
{
    public class FakeLoginService : ILoginService
    {
        private List<string> LoginTypesNames = new List<string>() { "Аутентификация Windows", "Аутентификация сервера MS SQL" };
        private ReadableEnumeration<LoginTypesEnumeration> loginTypesReadableList;
        public FakeLoginService()
        {
            loginTypesReadableList = new ReadableEnumeration<LoginTypesEnumeration>(LoginTypesNames);
        }
        public async Task<BackupModel> ConnectToSqlServer(LoginModel model)
        {
            await Task.Delay(10);
            return new BackupModel()
            {
                AllDatabases = new List<string>() { "База данных 1", "База данных 2", "База данных 3", "База данных 4" }
            };
        }

        public Enums.LoginTypesEnumeration GetByName(string name)
        {
            return loginTypesReadableList.GetEnumItem(name);
        }

        public List<string> GetLoginTypes()
        {
            return loginTypesReadableList.GetReadableList();
        }

        public List<string> GetSqlServers()
        {
            return new List<string>() { "Сервер 1", "Сервер 2" };
        }
    }
}
