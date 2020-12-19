using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.Managers;
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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DatabaseBackupperWindowsService
{
    public partial class DatabaseBackupperService : ServiceBase
    {
        
        Logger logger = LogManager.GetCurrentClassLogger();
        public DatabaseBackupperService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            Debugger.Launch();
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
                if (schedule.tasks.Count == 0) continue;
                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<BackupJob>()
                    .WithIdentity(schedule.ID.ToString(), "group1")
                    .Build();
                logger.Trace($"По расписанию {schedule.Cron} есть следующее количество задач - {schedule.tasks.Count}");
                job.JobDataMap["tasks"] = schedule.tasks;
                
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity(schedule.ID.ToString(), "group1")
                    .StartNow()
                    .WithCronSchedule(schedule.Cron)
                    .Build();
                jobs.Add(job, trigger);
            }
            foreach (var job in jobs)
            {
                Thread thread = new Thread(async (x) => { await scheduler.ScheduleJob(job.Key, job.Value); });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
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
