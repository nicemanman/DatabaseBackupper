using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DatabaseBackupperWindowsService
{
    public partial class DatabaseBackupperService : ServiceBase
    {
        Timer timer = new Timer();
        Logger logger = LogManager.GetCurrentClassLogger();
        public DatabaseBackupperService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            logger.Info("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000; //number in milisecinds  
            timer.Enabled = true;
        }
        protected override void OnStop()
        {
            logger.Info("Service is stopped at " + DateTime.Now);
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            logger.Info("Service is recall at " + DateTime.Now);
        }
    }
}
