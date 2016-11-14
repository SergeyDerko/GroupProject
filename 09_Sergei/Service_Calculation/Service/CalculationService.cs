
using System.IO;
using System.Threading;
using Service_Calculation.Modal;

namespace Service_Calculation.Service
{

    public class CalculationService
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;
        private readonly Separator _start = new Separator();

        public void Start()
        {
            
            var stopFlag = _stopFlag;
            _thread = new Thread(x =>
            {
                do
                {
                  _start.Scan(_start.PathDir);
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