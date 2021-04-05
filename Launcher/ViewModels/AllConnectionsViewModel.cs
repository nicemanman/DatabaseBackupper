using Launcher.Services;
using Prism.Mvvm;
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

        public AllConnectionsViewModel(IConnectionService connectionService)
        {
            _connectionService = connectionService;
            Test = "Test";
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
        
    }
}
