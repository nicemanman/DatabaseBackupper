using Launcher.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Launcher.Controls
{
    /// <summary>
    /// Interaction logic for ConnectionsPanel.xaml
    /// </summary>
    public partial class ConnectionsPanel : UserControl
    {


        public string Test
        {
            get { return (string)GetValue(tProperty); }
            set { SetValue(tProperty, value); }
        }

        // Using a DependencyProperty as the backing store for t.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tProperty =
            DependencyProperty.Register("t", typeof(string), typeof(ConnectionsPanel));


        public List<ConnectionModel> AllConnections
        {
            get { return (List<ConnectionModel>)GetValue(AllConnectionsProperty); }
            set { SetValue(AllConnectionsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllConnectionsProperty =
            DependencyProperty.Register("AllConnections", typeof(List<ConnectionModel>), typeof(ConnectionsPanel), new PropertyMetadata(new List<ConnectionModel>()));


        public ConnectionsPanel()
        {
            InitializeComponent();
            var groupOfConnections = AllConnections.GroupBy(x => x.ConnectionType.ConnectionTypeName);
            foreach (var group in groupOfConnections)
            {
                var connectionType = group.Key;
                var connectionsByType = new List<ConnectionModel>();
                foreach (var con in group)
                {
                    connectionsByType.Add(con);
                }
                SubPanels.Children.Add(new ConnectionsSubPanel(connectionsByType, connectionType));
            }
        }
    }
}
