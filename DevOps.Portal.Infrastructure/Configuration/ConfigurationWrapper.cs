using System;
using System.Configuration;

namespace DevOps.Portal.Infrastructure.Configuration
{
    public class ConfigurationWrapper : IConfiguration
    {
        public string TeamcityHost => GetAppSettingValue<string>(nameof(TeamcityHost));
        public string TeamcityPassword => GetAppSettingValue<string>(nameof(TeamcityPassword));
        public string TeamcityUsername => GetAppSettingValue<string>(nameof(TeamcityUsername));
        public string WorkingDirectory => GetAppSettingValue<string>(nameof(WorkingDirectory));
        public string DownloadDirectory => GetAppSettingValue<string>(nameof(DownloadDirectory));
        public string StorageUriEndpoint => GetAppSettingValue<string>(nameof(StorageUriEndpoint));
        public string StorageAccountKey => GetAppSettingValue<string>(nameof(StorageAccountKey));
        public string GitLabUrl => GetAppSettingValue<string>(nameof(GitLabUrl));
        public string GitLabPrivateToken => GetAppSettingValue<string>(nameof(GitLabPrivateToken));
        public string OctopusApiKey => GetAppSettingValue<string>(nameof(OctopusApiKey));
        public string OctopusServerUrl => GetAppSettingValue<string>(nameof(OctopusServerUrl));
        public string AzureClientId => GetAppSettingValue<string>(nameof(AzureClientId));
        public string AzureClientSecret => GetAppSettingValue<string>(nameof(AzureClientSecret));
        public string AzureTenantId => GetAppSettingValue<string>(nameof(AzureTenantId));

        private static T GetAppSettingValue<T>(string key) where T : IConvertible
        {
            var setting = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(setting))
            {
                throw new ConfigurationErrorsException($"App Setting {key} not set in configuration");
            }

            return (T)Convert.ChangeType(setting, typeof(T));
        }
    }
}
