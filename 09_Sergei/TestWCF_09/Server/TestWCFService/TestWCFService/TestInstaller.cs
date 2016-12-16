using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;

namespace TestWCFService
{
    public class TestInstaller
    {
        [RunInstaller(true)]
        public class TestWcfInstaller : Installer
        {
            public TestWcfInstaller()
            {
                var serviceProcessInstaller = new ServiceProcessInstaller();
                var serviceInstaller = new ServiceInstaller();
                serviceProcessInstaller.Account = ServiceAccount.NetworkService;
                serviceInstaller.ServiceName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                serviceInstaller.DisplayName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                serviceInstaller.Description = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                serviceInstaller.StartType = ServiceStartMode.Automatic;
                Installers.AddRange(new Installer[] { serviceProcessInstaller, serviceInstaller });
            }
        }
    }
}
