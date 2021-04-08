using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Launcher.Services.Fakes;
using Prism.Unity;
using Prism.Regions;

namespace Launcher.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IContainerExtension container;

        public MainViewModel(IContainerExtension container)
        {
            this.container = container;
            
        }
    }
}