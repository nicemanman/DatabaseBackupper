using DomainModel.Services;
using NSubstitute;
using NUnit.Framework;
using Presentation.Common;
using Presentation.Presenters;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Tests
{
    [TestFixture]
    public class TaskDetailsPresenterTests
    {
        public ITaskService taskService;
        public IScheduleService scheduleService;
        public IPathService pathService;
        public IEmailService emailService;
        public ITaskDetailsView view;
        public TaskDetailsPresenter presenter;
        public IApplicationController controller;
        [SetUp]
        public void SetUp()
        {
            taskService = Substitute.For<ITaskService>();
            pathService = Substitute.For<IPathService>();
            scheduleService = Substitute.For<IScheduleService>();
            emailService = Substitute.For<IEmailService>();
            view = Substitute.For<ITaskDetailsView>();
            controller = Substitute.For<IApplicationController>();
            presenter = new TaskDetailsPresenter(controller, view, scheduleService, pathService, emailService, taskService);
        }
    }
}
