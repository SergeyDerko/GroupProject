using System;
using System.ServiceModel;
using System.Threading;

namespace TestService
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    class TimeOfDayService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;

        public void Start()
        {
            _thread = new Thread(x =>
                {
                    using (var host = new ServiceHost(typeof(DateToTimeOfDayConverter)))
                    {

                        host.Open();

                        Console.WriteLine("Сервер запущен");
                        Console.ReadKey();
                        do
                        {

                        } while (!SrvUtils.Retarder(30, ref _stopFlag));

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