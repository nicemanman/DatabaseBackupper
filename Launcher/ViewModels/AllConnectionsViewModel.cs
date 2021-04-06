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
            Test = "Test";
            return Task.CompletedTask;
        }
    }
}
