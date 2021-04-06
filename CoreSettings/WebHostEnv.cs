using System;

namespace CoreSettings
{
    public static class WebHostEnv
    {
        private static string LocalBackupServerUrlVariable = "LocalDatabaseBackupperServerUrl";
        private static string DefaultLocalBackupServerUrl = "http://127.0.0.1:5000";
        public static string IpAddress
        {
            get
            {
                return EnvVariablesManager.GetVariableOrSetToDefault(LocalBackupServerUrlVariable, DefaultLocalBackupServerUrl);
            }
        }
    }
}
