﻿using DomainModel.Components.DatabaseRepository;
using DomainModel.Services;
using Presentation.Views;
using System.Windows.Forms;

namespace Presentation.Common
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer _container;
        private static ApplicationController instance;

        /// <summary>
        /// Получить контейнер с зависимостями
        /// </summary>
        public static ApplicationController Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new ApplicationController(LightInjectContainer.Instance);
                instance
                .RegisterService<ILoginService, LoginService>()
                .RegisterService<IBackupService, BackupService>()
                .RegisterService<IScheduleService, ScheduleService>()
                .RegisterService<IPathService, PathService>()
                .RegisterService<IEmailService, EmailService>()
                .RegisterService<ITaskService, TaskService>()
                .RegisterInstance(new ApplicationContext())
                .RegisterInstance<IDatabaseController>(new DatabaseController());
                return instance;
            }
        }
        public static IContainer ContainerInstance 
        {
            get => Instance._container;
        }
        private ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView 
            where TView : IView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        public IApplicationController RegisterInstance<TInstance>(TInstance instance)
        {
            _container.RegisterInstance(instance);
            return this;
        }

        
        public IApplicationController RegisterService<TModel, TImplementation>()
            where TImplementation : class, TModel
        {
            _container.Register<TModel, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();
            //Просто получаем презентер и раним его
            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument>(TArgument argumnent) where TPresenter : class, IPresenter<TArgument>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argumnent);
        }
    }
}