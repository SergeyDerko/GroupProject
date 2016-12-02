using System.Threading;
using CalcMathExpressionService.modal;

namespace CalcMathExpressionService.service
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
                    Scan.StartCalculation(); // старт

                } while (!SrvUtils.Retarder(5, ref stopFlag));
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}
