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
    public class TasksPresenterTests
    {
        public ITaskService taskService;
        public IBackupService backupService;
        public ITasksView view;
        public TasksPresenter presenter;
        public IApplicationController controller;
        [SetUp]
        public void SetUp()
        {
            taskService = Substitute.For<ITaskService>();
            view = Substitute.For<ITasksView>();
            controller = Substitute.For<IApplicationController>();
            presenter = new TasksPresenter(controller, view, taskService, backupService);
        }
    }
}
