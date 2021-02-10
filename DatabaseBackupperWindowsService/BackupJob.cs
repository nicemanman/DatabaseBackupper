
using NLog;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Services;
using DomainModel.Models;
using System.Net.Mail;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace DatabaseBackupperWindowsService
{
    public class BackupJob : IJob
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public Task Execute(IJobExecutionContext context)
        {
            var tasks = (List<TaskModel>)context.JobDetail.JobDataMap["tasks"];
            var backupService = (BackupService)context.JobDetail.JobDataMap["backupService"];


            foreach (var task in tasks)
            {
                var progress = new Progress<string>(status =>
                {
                    logger.Info(status);
                    task.BackupResult += status + "\n";
                });
                BackupModel model = new BackupModel()
                {
                    PathToBackup = task.SelectedPath,
                    DatabasesToBackup = task.SelectedDatabases
                };

                backupService.BackupDatabases(model, progress, null, task.SQLServer).Wait();

            }
            SendEmailNotifications(tasks);
            return Task.CompletedTask;
        }

        public void SendEmailNotifications(List<TaskModel> tasks)
        {
            var tasksByEmail = tasks.Where(x => x.NotifyAboutFinish).GroupBy(x => x.SelectedEmail);

            foreach (var taskGroup in tasksByEmail)
            {
                Credentials credentials;
                string dir = System.IO.Path.GetDirectoryName(
                            System.Reflection.Assembly.GetExecutingAssembly().Location);
                using (StreamReader file = File.OpenText(dir+"\\NotifyEmailCredentials.json"))
                {
                    credentials = JsonConvert.DeserializeObject<Credentials>(file.ReadToEnd());
                }
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress(credentials.email, "Бэкап баз данных");
                // кому отправляем
                MailAddress to = new MailAddress(taskGroup.Key);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Результат бэкапа баз данных";
                foreach (var task in taskGroup)
                {
                    // текст письма
                    m.Body += task.BackupResult + "\n";
                }

                // письмо представляет код html
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(credentials.email, credentials.password);
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
        }
    }
    public class Credentials 
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
