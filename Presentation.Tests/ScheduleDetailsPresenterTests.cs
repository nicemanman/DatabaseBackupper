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
    public class ScheduleDetailsPresenterTests
    {
        public IScheduleService service;
        public IScheduleDetailsView view;
        public ScheduleDetailsPresenter presenter;
        public IApplicationController controller;
        [SetUp]
        public void SetUp() 
        {
            service = Substitute.For<IScheduleService>();
            view = Substitute.For<IScheduleDetailsView>();
            controller = Substitute.For<IApplicationController>();
            presenter = new ScheduleDetailsPresenter(controller, view, service);
        }
    }
}
