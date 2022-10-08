using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace EPED
{
    class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;

        }

        public string GetProviderString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ProviderName;

        }

        public void SaveConnectionString(string key,string value, string providerstr)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = providerstr;
            config.Save(ConfigurationSaveMode.Modified);
        }

    }



}
