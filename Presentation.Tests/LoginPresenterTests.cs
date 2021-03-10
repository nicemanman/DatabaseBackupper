using DomainModel;
using DomainModel.Models;
using DomainModel.Services;
using NSubstitute;
using NUnit.Framework;
using Presentation.Common;
using Presentation.Presenters;
using Presentation.Views;
using System;
using System.Collections.Generic;
using static DomainModel.Enums;

namespace Presentation.Tests
{
    [TestFixture]
    public class LoginPresenterTests
    {
        
        private ILoginView view;
        private ILoginService service;
        private LoginPresenter presenter;
        private IApplicationController controller;
        [SetUp]
        public void SetUp()
        {
            controller = Substitute.For<IApplicationController>();
            view = Substitute.For<ILoginView>();
            service = Substitute.For<ILoginService>();
        }

        /// <summary>
        /// Не найдено ни одного SQL сервера
        /// </summary>
        [Test]
        public void SqlNotFound()
        {
            service.GetSqlServers().Returns(new List<string>());
            presenter = new LoginPresenter(controller, view, service);
            presenter.Run();
            view.Received().SqlNotFoundFunc();
        }

        /// <summary>
        /// Найдены SQL инстансы
        /// </summary>
        [Test]
        public void SqlFound()
        {
            service.GetSqlServers().Returns(new List<string>() { "First", "Second", "Third" });
            presenter = new LoginPresenter(controller, view, service);
            presenter.Run();
            view.DidNotReceive().SqlNotFoundFunc();
        }
        /// <summary>
        /// Подключение неудачно
        /// </summary>
        [Test]
        public void ConnectionNotSuccess()
        {
            view.ServerName.Returns("FailServer");
            service
                .When(x => x.ConnectToSqlServer(Arg.Any<LoginModel>()))
                .Do(x => { throw new Exception(); });
            presenter = new LoginPresenter(controller, view, service);
            presenter.Run();
            view.Login += Raise.Event<Action>();
            view.Received().ShowError(Arg.Any<string>());
        }
        /// <summary>
        /// Тип аутентификации меняется
        /// </summary>
        [Test]
        public void ChangeLoginType() 
        {
            service.GetByName("MSSQL").Returns(LoginTypesEnumeration.SQL);
            service.GetByName("Windows").Returns(LoginTypesEnumeration.Windows);
            presenter = new LoginPresenter(controller, view, service);
            presenter.Run();
            view.LoginType.Returns("MSSQL");
            view.LoginTypeChanged += Raise.Event<Action>();
            view.Received().SetMSSQLAuth();
            view.LoginType.Returns("Windows");
            view.LoginTypeChanged += Raise.Event<Action>();
            view.Received().SetWindowsAuth();
        }
       
    }
}
