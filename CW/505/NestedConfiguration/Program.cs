//http://code.dblock.org/2009/02/18/nesting-multiple-configurationelement-types-in-a-configurationelementcollection.html

using System;
using System.Configuration;

namespace AppConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExeConfigurationFileMap map = new ExeConfigurationFileMap();
                map.ExeConfigFilename = "AppConfiguration.exe.config";
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                CollectionSection config = (CollectionSection)configuration.Sections[typeof(CollectionSection).Name];
                Console.WriteLine("Nested configurations: {0}", config.Collection.Count);
                foreach (Proxy proxy in config.Collection)
                {
                    Console.WriteLine("Type: {0}", proxy.Parent.GetType());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
