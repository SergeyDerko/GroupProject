using System.Threading;

namespace _14_CalculationService
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    internal class CalculationService
    {
        private volatile bool _stopFlag;
        private Thread _thread;

        public void Start()
        {
            _thread = new Thread(x =>
            {
                var stopFlag = _stopFlag;
                do
                {
                  Scan.StartCalculation();
                } while (!SrvUtils.Retarder(1, ref stopFlag));
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}