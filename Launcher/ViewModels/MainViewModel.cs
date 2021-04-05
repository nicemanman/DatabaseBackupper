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

namespace Launcher.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private BindableBase _currentViewModel;
        
        public ObservableCollection<BindableBase> ViewModels { get; set; } = new ObservableCollection<BindableBase>();
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }
        public MainViewModel()
        {
            CurrentViewModel = new AllConnectionsViewModel(new FakeConnectionService());
        }
    }
}
