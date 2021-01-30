using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public class EmailService : IEmailService
    {
        IDatabaseController databaseController;
        public EmailService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
        }
        public  List<string> GetRecentEmails()
        {
            var emails = databaseController.emailRepository.GetAll().OrderByDescending(x => x.dateTime).Select(x => x.EmailString).ToList<string>();
            return emails;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveEmails()
        {
            throw new NotImplementedException();
        }

        public async Task SaveEmail(string emailToSave)
        {
            await RemoveAllBut_N_NewestEmails();
            var email = databaseController.emailRepository.Find(x => x.EmailString == emailToSave).FirstOrDefault();
            if (email == null)
            {
                databaseController.emailRepository.Add(new EMail() { EmailString = emailToSave, dateTime = DateTime.Now });
            }
            else
            {
                email.dateTime = DateTime.Now;
            }
            await databaseController.Complete();
        }
        private async Task RemoveAllBut_N_NewestEmails()
        {
            
            var count = databaseController.emailRepository.GetAll().Count();
            if (count > Constants.PathsCountRememberValue)
            {
                var theOldestPath = databaseController.emailRepository.GetAll().OrderBy(x => x.dateTime).FirstOrDefault();
                databaseController.emailRepository.Remove(theOldestPath);
                await databaseController.Complete();
            }
        }
    }
}
