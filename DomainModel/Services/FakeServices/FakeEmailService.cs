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
            throw new NotImplementedException();
        }

        public bool IsValidEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmails()
        {
            throw new NotImplementedException();
        }

        public Task SaveEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
