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
    public class LoginPresenterTests
    {
        private ILoginView _view;
        private IApplicationController _controller;
        [SetUp]
        public void SetUp()
        {
            _controller = Substitute.For<IApplicationController>();
            _view = Substitute.For<ILoginView>();
            var service = Substitute.For<ILoginService>();
            var presenter = new LoginPresenter(_controller, _view, service);
            presenter.Run();
        }

        [Test]
        public void Test() 
        {
            Assert.IsTrue(1 == 1);
        }
    }
}
