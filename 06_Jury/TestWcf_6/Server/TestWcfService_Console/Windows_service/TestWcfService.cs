using System.ServiceModel;
using System.Threading;
using Common;
using TestWcfLib;


namespace TestWcfService_Console.Windows_service
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    internal class TestWcfService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        public void Start()
        {
            _thread = new Thread(x =>
            {
                using (var host = new ServiceHost(typeof(Calc)))
                {
                    host.Open();
                    do
                    {

                    } while (!SrvUtils.Retarder(5, ref _stopFlag));
                    host.Close();
                }
            });
            _thread.Start();
            Logger.Write(Level.Info, "Сервер запущен!");
        }

        public void Stop()
        {
           _stopFlag = true;
            Logger.Write(Level.Info, "Сервер остановлен!");
        }
    }
}
