using Launcher.Core.Models;
using Launcher.Core.Services;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Core.ViewModels
{
    public class AllConnectionsViewModel : MvxViewModel
    {
        private List<ConnectionModel> _connections;
        private IConnectionService _connectionService;
        private readonly IMvxNavigationService _navigationService;

        public AllConnectionsViewModel(IConnectionService connectionService, IMvxNavigationService navigationService)
        {
            _connectionService = connectionService;
            _navigationService = navigationService;
        }

        public List<ConnectionModel> Connections
        {
            get { return _connections; }
            set { SetProperty(ref _connections, value); }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            Connections = _connectionService.GetConnections().Result;
        }
    }
}
