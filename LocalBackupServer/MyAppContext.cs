using Microsoft.Extensions.Hosting;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LocalBackupServer
{
    internal class MyAppContext : ApplicationContext
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly IHost _webHost;
        public MyAppContext()
        {
            var exitMenuItem = new ToolStripMenuItem("Выйти", null, onClick:OnExitClick);
            var settingsMenuItem = new ToolStripMenuItem("на", null, onClick:OnExitClick);
            
            Stream iconStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LocalBackupServer.server.ico");
            Icon icon;
            using (iconStream)
            {
                icon = new Icon(iconStream);
            }
            var menu = new ContextMenuStrip();
            menu.Items.Add(exitMenuItem);
            _notifyIcon = new NotifyIcon()
            {
                Visible = true,
                Icon = icon,
                ContextMenuStrip = menu,
                Text = "127.0.0.1:5001"
            };
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}