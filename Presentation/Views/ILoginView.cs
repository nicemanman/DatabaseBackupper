using DomainModel.Services;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        List<string> SqlServers{ get; set; }
        string ServerName { get; }
        List<Enum> LoginTypes { get; set; }
        LoginTypesEnumeration LoginType { get; }
        string Username { get; }
        string Password { get; }
        event Action Login;
        
    }
}
