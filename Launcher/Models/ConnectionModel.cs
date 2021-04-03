using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Models
{
    public class ConnectionModel
    {
        public ConnectionType ConnectionType { get; set; }
        public string Name { get; set; } = "Test";
        public string UserName { get; set; } = "Root";
        public string Address { get; set; } = "127.0.0.1:3306";
    }
}
