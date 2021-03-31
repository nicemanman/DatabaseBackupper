using BackupServer;
using BackupServerTray.Extensions;
using Microsoft.AspNetCore.Hosting;
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
                x.UseStartup<Startup>().ConfigureServices(ConfigureServices);
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
                Text = "127.0.0.1:5001"
            };

        }

        private void ConfigureServices(IServiceCollection services)
        {
            
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            //TODO: Первый способ останоки веб сервера верный, но он пока не работает. Разобраться почему.
            //var lifetime = _webHost.Services.GetService<IHostApplicationLifetime>();
            //lifetime.StopApplication();
            //_webHost.StopAsync().RunInBackgroundSafely(HandleException);
            //bad way
            _webHost.Dispose();
            Application.Exit();
        }

        private void HandleException(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}