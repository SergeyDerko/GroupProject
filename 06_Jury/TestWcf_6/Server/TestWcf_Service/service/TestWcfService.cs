using System;
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
        //private volatile bool _stopFlag;
        //private Thread _thread;
        private ServiceHost _host = null;
        public void Start()
        {
            if (_host == null)
            {
                _host = new ServiceHost(typeof(Calc));
                _host.Open();
            }
                

            //_thread = new Thread(x =>
            //{
            //    var stopFlag = _stopFlag;
            //    do
            //    {
            //        //Generator.Generate(); // старт

            //    } while (!SrvUtils.Retarder(5, ref stopFlag));
            //});
            //_thread.Start();
            //Process.Start(Generator.FolderForFiles); // открыть папку с файлами
        }

        public void Stop()
        {
            _host?.Close();

            //_stopFlag = true;
        }
    }
}
