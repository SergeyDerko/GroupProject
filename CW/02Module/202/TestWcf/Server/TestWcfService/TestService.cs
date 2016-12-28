using System;
using System.ServiceModel;
using System.Threading;
using TestWcfLib;

namespace TestWcfService
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    class TestService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;

        public void Start()
        {
            _thread = new Thread(x =>
            {
                var host = new ServiceHost(typeof(Calc));
                host.Open();

                do
                {

                } while (!SrvUtils.Retarder(30, ref _stopFlag));

                host.Close();
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}