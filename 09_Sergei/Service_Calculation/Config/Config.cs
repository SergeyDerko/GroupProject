using System.Configuration;
using System.IO;

namespace Service_Calculation.Config
{
    public class Config : ConfigurationSection
    {
        private static Config _instance;
        
        public static Config Get => _instance ?? (_instance = ConfigurationManager.GetSection("serviceConfig") as Config);

        [ConfigurationProperty("log", IsRequired = false)]
        public LogElement Log => (LogElement)this["log"];
    }

    public class LogElement : ConfigurationElement
    {
        [ConfigurationProperty("dir", DefaultValue = "Log", IsRequired = false)]
        public string Dir
        {
            get
            {
                var ret = (string)this["dir"] ?? string.Empty;
                if (!Path.IsPathRooted(ret))
                {
                    var name = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    if (name != null) ret = Path.Combine(name, "Log");
                }
                return ret;
            }
        }

        [ConfigurationProperty("level", DefaultValue = Level.Trace, IsRequired = false)]
        public Level Level => (Level)this["level"];

        [ConfigurationProperty("prefix", DefaultValue = "", IsRequired = false)]
        public string Prefix
        {
            get
            {
                var hostName = System.Net.Dns.GetHostName();
                return (string)this["prefix"] == null ? hostName : (string)this["prefix"] + "_" + hostName;
            }
        }
    }
}
