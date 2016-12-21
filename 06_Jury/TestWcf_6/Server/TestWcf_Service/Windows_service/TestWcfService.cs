using System.ServiceModel;
using System.ServiceProcess;
using System.Threading;
using Common;
using TestWcfLib;

namespace TestWcf_Service.Windows_service
{
    internal class TestWcfService : ServiceBase
    {
        private Thread _thread;
        private volatile bool _stopFlag;
        private ServiceHost _host;

        protected override void OnStart(string[] args)
        {
            _stopFlag = true;
            _thread = new Thread(x =>
            {
                using (_host = new ServiceHost(typeof(Calc)))
                {
                    _host.Open();
                    do
                    {
                    } while (_stopFlag);
                    
                }
            });
            _thread.Start();
            Logger.Write(Level.Info, "Сервер запущен!");
        }

        protected override void OnStop()
        {
            _stopFlag = false;
            Logger.Write(Level.Info, "Сервер остановлен!");
            _host.Close();
            
            
        }
    }
}
