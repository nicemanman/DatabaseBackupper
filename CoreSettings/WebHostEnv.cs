using System;

namespace CoreSettings
{
    public static class WebHostEnv
    {
        private static string LocalBackupServerUrlVariable = "LocalDatabaseBackupperServerUrl";
        private static string DefaultLocalBackupServerUrl = "http://127.0.0.1:5000";
        /// <summary>
        /// Ip:port локального сервера бэкапов
        /// </summary>
        public static string IpAddress
        {
            get
            {
                return EnvVariablesManager.GetVariableOrSetToDefault(LocalBackupServerUrlVariable, DefaultLocalBackupServerUrl);
            }
            set 
            {
                Environment.SetEnvironmentVariable(LocalBackupServerUrlVariable, value, EnvironmentVariableTarget.User);
            }
        }
    }
}
