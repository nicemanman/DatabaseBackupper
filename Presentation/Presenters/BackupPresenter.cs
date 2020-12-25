using DomainModel.Models;
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
        public BackupPresenter(IApplicationController controller, IBackupView view) : base(controller, view)
        {
        }

        public override void Run(BackupModel argument)
        {
            model = argument;
            View.AllDatabases = model.AllDatabases;
            View.Show();
        }
    }
}
