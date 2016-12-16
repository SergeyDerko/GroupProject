using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFService
{
    class TestInstaller
    {
        [RunInstaller(true)]
        public class TestWcfInstaller : Installer
        {
            private readonly ServiceProcessInstaller _serviceProcessInstaller;
            private readonly ServiceInstaller _serviceInstaller;
            public TestWcfInstaller()
            {
                _serviceProcessInstaller = new ServiceProcessInstaller();
                _serviceInstaller = new ServiceInstaller();
                _serviceProcessInstaller.Account = ServiceAccount.NetworkService;
                _serviceInstaller.ServiceName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                _serviceInstaller.DisplayName = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                _serviceInstaller.Description = Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
                _serviceInstaller.StartType = ServiceStartMode.Automatic;
                Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
            }
        }
    }
}
