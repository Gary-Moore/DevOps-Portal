﻿using System;
using System.Configuration;

namespace DevOps.Portal.Infrastructure.Configuration
{
    public class ConfigurationWrapper : IConfiguration
    {
        public string TeamcityHost => GetAppSettingValue<string>(nameof(TeamcityHost));
        public string TeamcityPassword => GetAppSettingValue<string>(nameof(TeamcityPassword));
        public string TeamcityUsername => GetAppSettingValue<string>(nameof(TeamcityUsername));
        public string WorkingDirectory => GetAppSettingValue<string>(nameof(WorkingDirectory));

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
