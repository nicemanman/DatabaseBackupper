using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface IEmailService
    {
        List<string> GetRecentEmails();
        Task SaveEmail(string email);
        void RemoveEmails();
        bool IsValidEmail(string email);
    }
}
