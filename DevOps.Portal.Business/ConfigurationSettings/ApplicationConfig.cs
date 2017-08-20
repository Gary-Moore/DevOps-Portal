using DevOps.Portal.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Business.ConfigurationSettings
{
    public class OctopusConfiguration
    {
        public string ApiKey => GetConfigValue<string>("ApiKey");

        public string OctopusEndpointUrl => GetConfigValue<string>("OctopusEndpointUrl");

        private T GetConfigValue<T>(string keyName)
        {
            var appSetting = ConfigurationManager.AppSettings[keyName];

            if (string.IsNullOrEmpty(appSetting))
            {
                throw new AppSettingNotFoundException(string.Format("{0} appSetting has not been set", appSetting));
            }

            var coverter = TypeDescriptor.GetConverter(typeof(T));
            return (T)coverter.ConvertFromInvariantString(appSetting);
        }
    }
}
