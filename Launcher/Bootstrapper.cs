using Launcher.Services;
using Launcher.Services.Fakes;
using Launcher.Views;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Launcher
{
    public class Bootstrapper : PrismBootstrapper
    {
        private bool _isTestEnv = true;
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainView>();
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            if (_isTestEnv) 
            {
                containerRegistry.Register<IConnectionService, FakeConnectionService>();
            }
        }
    }
}
