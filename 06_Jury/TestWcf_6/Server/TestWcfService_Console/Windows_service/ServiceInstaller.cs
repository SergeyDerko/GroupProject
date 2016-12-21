using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;

namespace TestWcfService_Console.Windows_service
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
            _serviceInstaller.Description = "TestWcfService_Console - отображение обращения к серверу в консоли";
            _serviceInstaller.StartType = ServiceStartMode.Manual;

            Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
        }
    }
}
