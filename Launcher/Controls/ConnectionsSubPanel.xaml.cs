using Launcher.Models;
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

namespace Launcher.Controls
{
    public partial class ConnectionsSubPanel : UserControl
    {
        public string ConnectionTypeName
        {
            get { return (string)GetValue(ConnectionTypeNameProperty); }
            set { SetValue(ConnectionTypeNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ConnectionTypeName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ConnectionTypeNameProperty =
            DependencyProperty.Register("ConnectionTypeName", typeof(string), typeof(ConnectionsSubPanel));

        public ConnectionsSubPanel(List<ConnectionModel> connections, string connectionTypeName)
        {
            InitializeComponent();
            ConnectionTypeName = connectionTypeName;
            foreach (var item in connections)
            {
                var tile = new ConnectionTile(item);
                
                ConnectionsWrapPanel.Children.Add(tile);
            }
        }
    }
}
