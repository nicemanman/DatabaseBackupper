
using Launcher.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher.Views
{
    /// <summary>
    /// Interaction logic for AllConnections.xaml
    /// In the case of WPF, this is only the default behavior when using region navigation and IDialogService. 
    /// If you are using view injection, your view will need to opt-in.
    /// </summary>

    public partial class AllConnectionsView : UserControl
    {
        public AllConnectionsView()
        {
            InitializeComponent();
            var panel = new ConnectionsPanel();

        }
    }
}
