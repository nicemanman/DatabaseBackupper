using Launcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Services
{
    public interface IConnectionService
    {
        Task<List<ConnectionModel>> GetConnections();
    }
}
