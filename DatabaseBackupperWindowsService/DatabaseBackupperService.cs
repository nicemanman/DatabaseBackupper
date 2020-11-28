using DatabaseBackupperWindowsLibrary;
using NLog;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DatabaseBackupperWindowsService
{
    public partial class DatabaseBackupperService : ServiceBase
    {
        Timer timer = new Timer();
        Logger logger = LogManager.GetCurrentClassLogger();
        public DatabaseBackupperService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            logger.Info("Service is started at " + DateTime.Now);
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = Task.Run(async () => await factory.GetScheduler()).Result;

            // and start it off
            Task.Run(async () => await scheduler.Start()).Wait();
            Dictionary<IJobDetail, ITrigger> jobs = new Dictionary<IJobDetail, ITrigger>();
            ScheduleManager manager = new ScheduleManager();
            var schedules = manager.GetAllOfThem();
            foreach (var schedule in schedules)
            {
                var data = new Dictionary<string, object>();
                data.Add("tasks", schedule.tasks);
                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<BackupJob>()
                    .WithIdentity(schedule.ID.ToString(), "group1")
                    .Build();

                job.JobDataMap["tasks"] = schedule.tasks;
                // Trigger the job to run now, and then repeat every 10 seconds
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity(schedule.ID.ToString(), "group1")
                    .StartNow()
                    .WithCronSchedule(schedule.Cron)
                    .Build();
                jobs.Add(job, trigger);
            }
            foreach (var job in jobs)
            {
                Task.Run(async () => await scheduler.ScheduleJob(job.Key, job.Value)).Wait();
            }
            
        }
        protected override void OnStop()
        {
            logger.Info("Service is stopped at " + DateTime.Now);
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            logger.Info("Service is recall at " + DateTime.Now);
        }
    }
}
