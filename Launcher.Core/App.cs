using Launcher.Core.Services;
using Launcher.Core.Services.Fakes;
using Launcher.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;
using System;

namespace Launcher.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            Mvx.IoCProvider.RegisterType<IConnectionService, FakeConnectionService>();
            RegisterAppStart<AllConnectionsViewModel>();
        }
    }
}
