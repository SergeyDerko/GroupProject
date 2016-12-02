using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;


namespace CalcMathExpressionService.service
{
    [RunInstaller(true)]
    public class SrvInstaller : Installer
    {
        private readonly ServiceProcessInstaller _serviceProcessInstaller;
        private readonly ServiceInstaller _serviceInstaller;

        public SrvInstaller()
        {
            _serviceProcessInstaller = new ServiceProcessInstaller();
            _serviceInstaller = new ServiceInstaller();

            _serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

            _serviceInstaller.ServiceName = "Part1_exam_srv_" + Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.DisplayName = "Part1_exam_srv_" + Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase);
            _serviceInstaller.Description = "Часть 1. Основы C#. Cервис - Калькулятор арифметических выражений считанных с файла";
            _serviceInstaller.StartType = ServiceStartMode.Automatic;

            Installers.AddRange(new Installer[] { _serviceProcessInstaller, _serviceInstaller });
        }
    }
}
