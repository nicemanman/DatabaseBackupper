using Launcher.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.ViewModels
{
    public class AllConnectionsViewModel
    {
        private ObservableCollection<ConnectionType> _connectionTypes = new ObservableCollection<ConnectionType>();//их надо получать из базы данных
        private ObservableCollection<ConnectionModel> _connections = new ObservableCollection<ConnectionModel>();
        public AllConnectionsViewModel()
        {
            var MySQLConnectionType = new ConnectionType() { ConnectionTypeName = "MySQL", ConnectionTypeId = 1 };
            var MSSQLConnectionType = new ConnectionType() { ConnectionTypeName = "MSSQL", ConnectionTypeId = 2 };
            var PostgresqlConnectionType = new ConnectionType() { ConnectionTypeName = "PostgreSQL", ConnectionTypeId = 3 };
            ConnectionTypes.Add(MySQLConnectionType);
            ConnectionTypes.Add(MSSQLConnectionType);
            ConnectionTypes.Add(PostgresqlConnectionType);
            Connections.Add(new ConnectionModel() 
            {
                ConnectionType = MySQLConnectionType,
                Name = "Тестовое подключение",
                UserName = "Root",
                Address = "127.0.0.1:3306"
            });
        }
        public ObservableCollection<ConnectionModel> Connections
        {
            get { return _connections; }
            set { _connections = value; }
        }

        public ObservableCollection<ConnectionType> ConnectionTypes
        {
            get { return _connectionTypes; }
            set { _connectionTypes = value; }
        }
    }
}
