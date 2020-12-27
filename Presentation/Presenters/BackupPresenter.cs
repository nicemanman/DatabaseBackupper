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
    public class BackupPresenter : BasePresenter<IBackupView, BackupModel>
    {
        private BackupModel model;
        private readonly IBackupService backupService;
        public BackupPresenter(IApplicationController controller, IBackupView view, IBackupService backupService) : base(controller, view)
        {
            this.backupService = backupService;
        }

        public override void Run(BackupModel argument)
        {
            model = argument;
            View.AllDatabases = model.AllDatabases;
            View.Show();
            View.Logout += View_Logout;
        }

        private void View_Logout()
        {
            backupService.BackupDatabases(null);
            Controller.Run<LoginPresenter>();
            View.Close();
        }
    }
}
