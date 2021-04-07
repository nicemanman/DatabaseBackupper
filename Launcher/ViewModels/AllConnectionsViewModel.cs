using Launcher.Models;
using Launcher.Services;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.ViewModels
{
    public class AllConnectionsViewModel : BindableBase
    {
        private readonly IConnectionService _connectionService;
        private readonly IRegionManager regionManager;
        private List<ConnectionModel> _connections;
        private List<ConnectionType> _connectionTypes;
        private Dictionary<string, List<string>> _test;

        public Dictionary<string, List<string>> TestDict
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        public List<ConnectionType> ConnectionTypes
        {
            get { return _connectionTypes; }
            set { SetProperty(ref _connectionTypes, value); }
        }

        public List<ConnectionModel> Connections
        {
            get { return _connections; }
            set { SetProperty(ref _connections, value); }
        }
        
        public AllConnectionsViewModel(IConnectionService connectionService)
        {
            _connectionService = connectionService;
            Initialize();
        }
        private string test;

        public string Test
        {
            get { return test; }
            set { SetProperty(ref test, value); }
        }

        protected Task Initialize()
        {
            ConnectionTypes = _connectionService.GetConnectionTypes().Result;
            Connections = _connectionService.GetConnections().Result;
            TestDict = new Dictionary<string, List<string>>()
            {
                { "1", new List<string>(){ "a","b","c" } },
                { "2", new List<string>(){ "d","e","f" } },
                { "3", new List<string>(){ "g","h","z" } },
            };
            return Task.CompletedTask;
        }
    }
}
