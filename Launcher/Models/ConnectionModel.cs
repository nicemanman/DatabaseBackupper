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
        public Guid ConnectionId { get; set; }
        public string Title { get; set; } = "ТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТТ";
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
