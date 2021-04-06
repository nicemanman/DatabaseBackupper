using Bogus;
using Launcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Services.Fakes
{
    public class FakeConnectionService : IConnectionService
    {
        private List<ConnectionType> connectionTypes = new List<ConnectionType>()
        {
            new ConnectionType() { ConnectionTypeId = Guid.NewGuid(),ConnectionTypeName = "MySQL" },
            new ConnectionType() { ConnectionTypeId = Guid.NewGuid(),ConnectionTypeName = "MSSQL" },
            new ConnectionType() { ConnectionTypeId = Guid.NewGuid(),ConnectionTypeName = "PostgreSQL" },
            new ConnectionType() { ConnectionTypeId = Guid.NewGuid(),ConnectionTypeName = "Oracle" }
        };
        public Task<List<ConnectionModel>> GetConnections()
        {
            int connectionNameIndex = 0;
            
            var random = new Random();
            var faker = new Faker<ConnectionModel>()
                .RuleFor(e => e.Title, (f, e) => { connectionNameIndex++; return e.Title + " " + connectionNameIndex.ToString(); })//Тестовое подключение 
                .RuleFor(e => e.ConnectionType, (f, e) => connectionTypes[random.Next(connectionTypes.Count)])
                .RuleFor(e => e.UserName, (f, e) => f.Person.UserName)
                .RuleFor(e => e.Address, (f, e) => f.Internet.Ip())
                .RuleFor(e=>e.ConnectionId, (f,e)=> Guid.NewGuid());
            var connections = faker.Generate(50);
            return Task.FromResult(connections);
        }
        public Task<List<ConnectionType>> GetConnectionTypes() 
        {
            return Task.FromResult(connectionTypes);
        }
    }
}
