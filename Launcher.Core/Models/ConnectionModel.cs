using System;
using System.Collections.Generic;
using System.Text;

namespace Launcher.Core.Models
{
    public class ConnectionModel
    {
        public ConnectionType ConnectionType { get; set; }
        public string Name { get; set; } = "Тестовое подключение";
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
