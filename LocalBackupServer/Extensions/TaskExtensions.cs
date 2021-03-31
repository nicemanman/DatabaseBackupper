using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackupServerTray.Extensions
{
    public static class TaskExtensions
    {
        public static async void RunInBackgroundSafely(this Task task, Action<Exception> onException = null) 
        {
            try
            {
                //т.к. у нас нет UI thread
                await task.ConfigureAwait(false);
            }
            catch (Exception ex) when (!(onException is null))
            {
                onException(ex);
            }
        }
    }
}
