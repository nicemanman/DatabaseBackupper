﻿using DomainModel;
using DomainModel.Models;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainModel.Enums;

namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _service;
        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service) : base(controller, view)
        {
            _service = service;
            var loginTypes = service.GetLoginTypes();
            var sqlServers = service.GetSqlServers();
            View.LoginTypes = loginTypes;
            View.SqlServers = sqlServers;
            View.Login += async () => await Login(View.ServerName, View.LoginType, View.Username, View.Password);
            View.LoginTypeChanged += () => LoginTypeChanged(View.LoginType);
        }

        private void LoginTypeChanged(string loginType)
        {
            var enumItem = _service.GetByName(loginType);
            if (enumItem.Equals(LoginTypesEnumeration.SQL)) View.SetMSSQLAuth();
            else if (enumItem.Equals(LoginTypesEnumeration.Windows)) View.SetWindowsAuth();
        }

        public async Task Login(string serverName, string loginType, string userName, string password) 
        {
            using (new LongOperation(View))
            {
                
                try { 
                    var loginModel = new LoginModel() { Servername = serverName, Username = userName, Password = password, LoginType = loginType };
                    var backupModel = await _service.ConnectToSqlServer(loginModel);
                    Controller.Run<BackupPresenter, BackupModel>(backupModel);
                }
                catch(Exception ex)
                {
                    View.ShowError(ex.Message);
                    return;
                }
            }
                View.Close();
        }
    }
}
