using Launcher.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Core.Services
{
    public interface IConnectionService
    {
        Task<List<ConnectionModel>> GetConnections();
    }
}
