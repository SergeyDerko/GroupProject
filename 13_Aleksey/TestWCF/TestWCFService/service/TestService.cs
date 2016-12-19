using System.ServiceModel;
using System.Threading;
using TestWCFCommon;

namespace TestWCFService.service
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    internal class TestService
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
                        var format = "Open";
                        Logger.Trace("Start_Thread", format);

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
