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
    
    public abstract class CustomBindableBase : BindableBase, INavigationAware
    {
        private readonly IRegionManager regionManager;
        protected IContainerExtension _container;
        public CustomBindableBase(IRegionManager regionManager, IContainerExtension container)
        {
            this.regionManager = regionManager;
            _container = container;
        }
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //условия перехода на разные view для каждого будут разные
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {}

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //при переходе на view необходимо загрузить в него информацию
            //сейчас она будет блокировать UI Thread, надо будет с этим разобраться
            //поменять состояние на Ожидание
            Initialize().Wait();
            //поменять состояние на Нормальное
        }

        protected virtual Task Initialize() 
        {
            return Task.CompletedTask;
        }
        
    }
}
