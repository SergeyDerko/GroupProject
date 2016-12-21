using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;

namespace TestWCFService
{

    [RunInstaller(true)]
    public class TestWcfInstaller : Installer
    {
        private readonly ServiceProcessInstaller serviceProcessInstaller;
        private readonly ServiceInstaller serviceInstaller;
        public TestWcfInstaller()
        {
            serviceProcessInstaller = new ServiceProcessInstaller();
            serviceInstaller = new ServiceInstaller();
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.ServiceName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            serviceInstaller.DisplayName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            serviceInstaller.Description = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            Installers.AddRange(new Installer[] { serviceProcessInstaller, serviceInstaller });
        }
    }

}
