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
    public class AllConnectionsViewModel : CustomBindableBase
    {
        private readonly IConnectionService _connectionService;
        private readonly IRegionManager regionManager;

        public AllConnectionsViewModel(IConnectionService connectionService, IRegionManager regionManager, IContainerExtension container) : base(regionManager, container)
        {
            _connectionService = connectionService;
            this.regionManager = regionManager;
            Test = "Доступные подключения";
        }
        private string _test;

        public string Test
        {
            get { return _test; }
            set
            {
                SetProperty(ref _test, value);
            }
        }
        protected override Task Initialize()
        {
            //загрузить подключения
            return base.Initialize();
        }
    }
}
