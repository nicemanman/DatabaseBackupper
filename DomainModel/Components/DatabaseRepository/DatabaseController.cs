﻿using System;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public class DatabaseController : IDatabaseController
    {
        private AppDbContext context;
        public IJobRepository jobRepository { get; set; }
        public IScheduleRepository scheduleRepository { get; set; }
        public IPathRepository pathRepository { get; set; }
        public IEmailRepository emailRepository { get; set; }
        public DatabaseController()
        {
            context = new AppDbContext();
            
            jobRepository = new JobRepository(context);
            scheduleRepository = new ScheduleRepository(context);
            pathRepository = new PathRepository(context);
            emailRepository = new EMailRepository(context);
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }

        
        public void Initialize()
        {
            context.Database.Initialize(false);
        }
    }
}
