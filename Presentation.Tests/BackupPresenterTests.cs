using DomainModel.Models;
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
    public class BackupPresenterTests
    {
        public IBackupView view;
        public IBackupService backupService;
        public IApplicationController controller;
        public IPathService pathService;
        public BackupPresenter presenter;

        [SetUp]
        public void SetUp() 
        {
            view = Substitute.For<IBackupView>();
            backupService = Substitute.For<IBackupService>();
            pathService = Substitute.For<IPathService>();
            controller = Substitute.For<IApplicationController>();
            presenter = new BackupPresenter(controller, view, backupService, pathService);
        }

        [Test]
        [TestCase("hfjfjf")]
        [TestCase("")]
        [TestCase("F:\\NotExistFolder")]
        public void NotValidPath(string path) 
        {
            view.PathToBackup.Returns(path);
            presenter.Run(new BackupModel());
            view.Backup += Raise.Event<Action>();
            view.Received().ShowError(Arg.Any<string>());
        }
       
        [Test]
        public void NoSelectedDatabase() 
        {
            view.DatabasesToBackup.Returns(new List<string>());
            presenter.Run(new BackupModel());
            view.Backup += Raise.Event<Action>();
            view.Received().ShowError(Arg.Any<string>());
        }

        [Test]
        public void BackupStartedSuccessful() 
        {
            
        }

        [Test]
        public void OpenImplementedWindow() 
        {
            
        }

        [Test]
        public void OpenNotImplementedWindow() 
        {
            
        }
    }
}
