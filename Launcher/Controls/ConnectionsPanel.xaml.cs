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

        public static readonly DependencyProperty tProperty =
            DependencyProperty.Register("Test", typeof(string), typeof(ConnectionsPanel), new PropertyMetadata(""));


        public List<ConnectionModel> AllConnections
        {
            get { return (List<ConnectionModel>)GetValue(AllConnectionsProperty); }
            set { SetValue(AllConnectionsProperty, value); }
        }

        public static readonly DependencyProperty AllConnectionsProperty =
            DependencyProperty.Register("AllConnections", typeof(List<ConnectionModel>), typeof(ConnectionsPanel), new PropertyMetadata(new List<ConnectionModel>()));


        public ConnectionsPanel()
        {
            InitializeComponent();
        }

        public override void EndInit()
        {
            var groupOfConnections = AllConnections.OrderBy(x=>x.ConnectionType.ConnectionTypeId).GroupBy(x => x.ConnectionType.ConnectionTypeName);
            foreach (var group in groupOfConnections)
            {
                var connectionType = group.Key;
                var connectionsByType = new List<ConnectionModel>();
                foreach (var con in group)
                {
                    connectionsByType.Add(con);
                }
                var subpanel = new ConnectionsSubPanel(connectionsByType, connectionType);
                subpanel.Padding = new Thickness(0, 40, 0, 0);
                SubPanels.Children.Add(subpanel);
            }
            base.EndInit();
        }
    }
}
