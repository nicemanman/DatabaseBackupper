using BackupServer;
using BackupServerTray.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using System;
using System.Diagnostics;
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
        private string LocalBackupServerUrlVariable = "LocalDatabaseBackupperServerUrl";
        private string DefaultLocalBackupServerUrl = "http://127.0.0.1:5000";
        private string BackupServerUrl;
        private readonly NLog.Logger logger;
        public MyAppContext()
        {
            logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("init main function");
                //запускаем веб сервер
                BackupServerUrl = Environment.GetEnvironmentVariable(LocalBackupServerUrlVariable, EnvironmentVariableTarget.User);
                if (BackupServerUrl == null)
                {
                    Environment.SetEnvironmentVariable(LocalBackupServerUrlVariable, DefaultLocalBackupServerUrl, EnvironmentVariableTarget.User);
                    BackupServerUrl = DefaultLocalBackupServerUrl;
                }
                _webHost = Host.CreateDefaultBuilder()
                    .ConfigureLogging(logging => 
                    {
                        logging.ClearProviders();
                        logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                    })
                    .UseNLog()
                    .ConfigureWebHostDefaults((x) =>
                    {
                        x.UseStartup<Startup>();
                        x.UseUrls(BackupServerUrl);
                    })
                    .Build();

                _webHost.Start();

                var settingsMenuItem = new ToolStripMenuItem("Настройки", null, onClick: OnSettingsClick);
                var exitMenuItem = new ToolStripMenuItem("Выйти", null, onClick: OnExitClick);

                Stream iconStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BackupServerTray.server.ico");
                Icon icon;
                using (iconStream)
                {
                    icon = new Icon(iconStream);
                }
                var menu = new ContextMenuStrip();
                menu.Items.Add(settingsMenuItem);
                menu.Items.Add(exitMenuItem);
                _notifyIcon = new NotifyIcon()
                {
                    Visible = true,
                    Icon = icon,
                    ContextMenuStrip = menu,
                    Text = BackupServerUrl
                };
                _notifyIcon.BalloonTipText = $"Сервер бэкапов в работе - {BackupServerUrl}";
                _notifyIcon.BalloonTipTitle = "DatabaseBackupper";
                _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                _notifyIcon.ShowBalloonTip(2000);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        private void OnSettingsClick(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = BackupServerUrl;
                myProcess.Start();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            _webHost.Dispose();
            Application.Exit();
        }

        private void HandleException(Exception ex)
        {
            logger.Error(ex);
        }
    }
}