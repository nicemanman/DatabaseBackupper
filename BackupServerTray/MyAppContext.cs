using System.Windows.Forms;

namespace BackupServerTray
{
    internal class MyAppContext : ApplicationContext
    {
        private NotifyIcon _notifyIcon;
        public MyAppContext()
        {
            _notifyIcon = new NotifyIcon()
            {
                ContextMenu = new ContextMenu(new[] 
                {
                    new MenuItem() 
                    {
                        Text = "Выйти"
                    } 
                }),
                Visible = true
            };
        }
    }
}