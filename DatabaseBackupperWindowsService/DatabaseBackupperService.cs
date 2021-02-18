using DomainModel;
using DomainModel.Services;
using NLog;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DatabaseBackupperWindowsService
{
    public partial class DatabaseBackupperService : ServiceBase
    {
        
        Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IScheduleService scheduleService;
        public readonly ITaskService taskService;
        public readonly IBackupService backupService;
        public DatabaseBackupperService(IScheduleService scheduleService, ITaskService taskService, IBackupService backupService)
        {
            InitializeComponent();
            this.scheduleService = scheduleService;
            this.taskService = taskService;
            this.backupService = backupService;
        }
        protected override void OnStart(string[] args)
        {
            //Debugger.Launch();
            logger.Info("Service is started at " + DateTime.Now);
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = Task.Run(async () => await factory.GetScheduler()).Result;
            ReloadTasks(scheduler);
            scheduler.Start();
        }
        public void ReloadTasks(IScheduler scheduler)
        {
            Dictionary<IJobDetail, ITrigger> jobs = new Dictionary<IJobDetail, ITrigger>();
            //будут получены все задачи, не только в рамках одного конкретного сервера
            var tasks = taskService.GetAllTasks(service: true);
            var schedules = scheduleService.GetAllSchedules();
            foreach (var schedule in schedules)
            {
                var tasksBySchedule = tasks.Where(x => x.SelectedSchedule.Id == schedule.Id && x.Enabled == true).ToList();
                if (tasksBySchedule.Count == 0) continue;
                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<BackupJob>()
                    .WithIdentity(schedule.Id.ToString(), "group1")
                    .Build();
                logger.Trace($"По расписанию {schedule.CronExpression} есть следующее количество задач - {tasksBySchedule.Count}");
                job.JobDataMap["tasks"] = tasksBySchedule;
                job.JobDataMap["backupService"] = backupService;
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity(schedule.Id.ToString(), "group1")
                    .StartNow()
                    .WithCronSchedule(schedule.CronExpression)
                    .Build();
                jobs.Add(job, trigger);
            }

            foreach (var job in jobs)
            {
                scheduler.ScheduleJob(job.Key, job.Value);
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
