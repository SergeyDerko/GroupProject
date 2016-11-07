using System;
using System.Configuration;
using Common;

namespace AppConfiguration
{
    public class Config : Singleton<Config>
    {
        private Config()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap();
            var assemblyName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            map.ExeConfigFilename = $"{assemblyName}.exe.config";
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(map,
                ConfigurationUserLevel.None);
            CollectionSection = (CollectionSection) configuration.Sections[typeof(CollectionSection).Name];
        }

        public CollectionSection CollectionSection { get; set; }
    }
}