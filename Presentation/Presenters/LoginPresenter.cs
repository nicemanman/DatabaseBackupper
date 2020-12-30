using DomainModel;
using DomainModel.Models;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public async Task Login(string serverName, Enums.LoginTypesEnumeration loginType, string userName, string password) 
        {
            using (new LongOperation(View))
            {
                var loginModel = new LoginModel() { Servername = serverName, Username = userName, Password = password, LoginType = loginType };
                var backupModel = await _service.ConnectToSqlServer(loginModel);
                if (backupModel == null)
                {
                    View.ShowError("Ошибка подключения:(");
                    return;
                }
                Controller.Run<BackupPresenter, BackupModel>(backupModel);
            }
                View.Close();
        }
    }
}
