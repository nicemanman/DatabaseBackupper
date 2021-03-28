using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakePathService : IPathService
    {
        public async Task<List<string>> GetBackupPaths()
        {
            await Task.Delay(10);
            return new List<string>() { "Путь для бэкапа 1", "Путь для бэкапа 2" };
        }

        public void RemoveBackupPaths()
        {
            return;
        }

        public Task SaveBackupPath(string backupPath)
        {
            return Task.CompletedTask;
        }
    }
}
