using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class LoginModel
    {
        public string Servername { get; }
        public string Username   { get; }
        public string Password   { get; }
        public string LoginType  { get; }
    }
    
}
