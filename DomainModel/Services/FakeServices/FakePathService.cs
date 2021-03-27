using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakePathService : IPathService
    {
        public Task<List<string>> GetBackupPaths()
        {
            throw new NotImplementedException();
        }

        public void RemoveBackupPaths()
        {
            throw new NotImplementedException();
        }

        public Task SaveBackupPath(string backupPath)
        {
            throw new NotImplementedException();
        }
    }
}
