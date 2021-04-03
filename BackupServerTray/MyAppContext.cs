using BackupServer;
using BackupServerTray.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BackupServerTray
{
    internal class MyAppContext : ApplicationContext
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly IHost _webHost;
        public MyAppContext()
        {
            //запускаем веб сервер
            _webHost = Host.CreateDefaultBuilder().ConfigureWebHostDefaults((x)=> 
            {
                x.UseStartup<Startup>();
                
            }).Build();

            _webHost.Start();
            

            var exitMenuItem = new ToolStripMenuItem("Выйти", null, onClick:OnExitClick);
            
            Stream iconStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BackupServerTray.server.ico");
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
                Text = ""
            };

        }


        private void OnExitClick(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            _webHost.Dispose();
            Application.Exit();
        }

    }
}