using System;
using System.ServiceProcess;
using System.Threading;

namespace _08_AscII_vo
{
    internal class MainService : ServiceBase
    {
        private readonly TestService _testService = new TestService();

        public void StartSvc()
        {
            _testService.Start();
        }

        public void StopSvc()
        {
            _testService.Stop();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            StartSvc();
        }

        protected override void OnStop()
        {
            base.OnStop();
            StopSvc();
        }
    }

    class TestService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;

        public void Start()
        {
            _thread = new Thread(x =>
            {
                do
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        Console.WriteLine($"TestService: {i}");
                        SrvUtils.Retarder(1, ref _stopFlag);
                    }
                } while (!SrvUtils.Retarder(30, ref _stopFlag));
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }

    public static class SrvUtils
    {
        /// <summary>
        /// Замедляет работу основного потока на указанное количество секунд.
        /// </summary>
        /// <param name="seconds">Количество секунд задержки</param>
        /// <param name="stop">ссылка на ключ остановки службы</param>
        public static bool Retarder(int seconds, ref bool stop)
        {
            for (int i = 0; !stop && i < seconds*1000/Constants.TimeScanStopParam; i++)
            {
                Thread.Sleep(Constants.TimeScanStopParam);
            }
            return stop;
        }
    }

    public static class Constants
    {
        /// <summary>
        /// Интервал проверки флага завершения работы службы.
        /// </summary>
        public static int TimeScanStopParam = 500;
    }
}