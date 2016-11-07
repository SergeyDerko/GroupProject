
using System;
using System.Threading;

namespace Service_Calculation
{
    internal class CalculationService
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
                    for (int i = 0; i < 10000; i++)
                    {
                        start.Scan(new Separator().PathDir);
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
}