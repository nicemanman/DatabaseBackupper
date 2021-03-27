using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface IPathService
    {
        Task<List<string>> GetBackupPaths();
        Task SaveBackupPath(string backupPath);
        void RemoveBackupPaths();
        

    }
}
