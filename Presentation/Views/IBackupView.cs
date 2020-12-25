using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface IBackupView : IView
    {
        string PathToBackup { get; set; }
        List<string> AllDatabases { get; set; }
        List<string> DatabasesToBackup { get; set; }
    }
}
