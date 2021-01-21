using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    /// <summary>
    /// Модель, отражающая, какие данные ввел пользователь в окне подключения
    /// </summary>
    public class LoginModel
    {
        public string Servername { get; set; }
        public string Username   { get; set; }
        public string Password   { get; set; }
        public string LoginType  { get; set; }
    }
    
}
