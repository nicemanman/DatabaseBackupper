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
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainView>();
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var testEnv = Environment.GetEnvironmentVariable("TEST_ENV_DATABASEBACKUPPER", EnvironmentVariableTarget.User);
            if (testEnv == null)
            {
                Environment.SetEnvironmentVariable("TEST_ENV_DATABASEBACKUPPER", "1", EnvironmentVariableTarget.User);
                testEnv = "1";
            }
            if (testEnv.Equals("1")) 
            {
                containerRegistry.Register<IConnectionService, FakeConnectionService>();
            }
        }
    }
}
