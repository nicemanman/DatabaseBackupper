using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakeEmailService : IEmailService
    {
        public List<string> GetRecentEmails()
        {
            return new List<string>() 
            {
                "Недавний email 1","Недавний email 2","Недавний email 3"
            };
        }

        public bool IsValidEmail(string email)
        {
            return true;
        }

        public void RemoveEmails()
        {
            return;
        }

        public Task SaveEmail(string email)
        {
            return Task.CompletedTask;
        }
    }
}
