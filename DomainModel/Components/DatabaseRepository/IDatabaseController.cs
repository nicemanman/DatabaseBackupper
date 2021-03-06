﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public interface IDatabaseController
    {
        IJobRepository jobRepository { get; set; }
        IScheduleRepository scheduleRepository { get; set; }
        IPathRepository pathRepository { get; set; }
        IEmailRepository emailRepository { get; set; }

        Task CompleteAsync();
        void Initialize();
    }
}
