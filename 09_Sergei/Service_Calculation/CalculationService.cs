using System.Threading;

namespace Service_Calculation
{
    public class CalculationService
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
                    var start = new Separator();
                    start.Scan(start.PathDir);
                } while (!SrvUtils.Retarder(1, ref _stopFlag));
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}