using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Threading;
using Common;
using TestWcf;

namespace TestWcf_Service.service
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
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}
