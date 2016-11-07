using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace SR
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;

        public Installer1()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();


            processInstaller.Account = ServiceAccount.LocalSystem;// тип учетной записи
            serviceInstaller.StartType = ServiceStartMode.Manual;// запуск вручную
            serviceInstaller.ServiceName = "MY_SR";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
