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
            var sqlServers = service.GetSqlServers(true);
            View.LoginTypes = loginTypes;
            View.SqlServers = sqlServers;
            View.Login += async () => await Login(View.ServerName, View.LoginType, View.Username, View.Password);
        }

        public async Task Login(string serverName, LoginTypesEnumeration loginType, string userName, string password) 
        {
            View.Wait();
            await Task.Delay(10000);
            View.StopWaiting();
        }
    }
}
