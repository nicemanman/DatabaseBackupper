using Bogus;
using Launcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Core.Services.Fakes
{
    internal class FakeConnectionService : IConnectionService
    {
        public Task<List<ConnectionModel>> GetConnections()
        {
            int connectionNameIndex = 0;
            var connectionTypes = new List<ConnectionType>() 
            {
                new ConnectionType() { ConnectionTypeId = 1,ConnectionTypeName = "MySQL" },
                new ConnectionType() { ConnectionTypeId = 2,ConnectionTypeName = "MSSQL" },
                new ConnectionType() { ConnectionTypeId = 3,ConnectionTypeName = "PostgreSQL" },
                new ConnectionType() { ConnectionTypeId = 3,ConnectionTypeName = "Oracle" }
            };
            var random = new Random();
            var faker = new Faker<ConnectionModel>()
                .RuleFor(e => e.Name, (f, e) => { connectionNameIndex++; return e.Name + " " + connectionNameIndex.ToString(); })//Тестовое подключение 
                .RuleFor(e => e.ConnectionType, (f, e) => connectionTypes[random.Next(connectionTypes.Count)])
                .RuleFor(e=>e.UserName, (f,e) => f.Person.UserName)
                .RuleFor(e=>e.Address, (f,e)=>f.Internet.Ip());
            var connections = faker.Generate(50);
            return Task.FromResult(connections);
        }
    }
}
