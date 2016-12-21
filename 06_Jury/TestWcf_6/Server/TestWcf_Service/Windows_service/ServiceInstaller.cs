using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;

namespace TestWcf_Service.Windows_service
{
    [RunInstaller(true)]
    public class ServiceInstaller : Installer
    {
        private readonly ServiceProcessInstaller _serviceProcessInstaller;
        private readonly System.ServiceProcess.ServiceInstaller _serviceInstaller;

        public ServiceInstaller()
        {
            _serviceProcessInstaller = new ServiceProcessInstaller();
            _serviceInstaller = new System.ServiceProcess.ServiceInstaller();

            _serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

            _serviceInstaller.ServiceName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.DisplayName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.Description = "TestWcf_Service";
            _serviceInstaller.StartType = ServiceStartMode.Automatic;

            Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
        }
    }
}
