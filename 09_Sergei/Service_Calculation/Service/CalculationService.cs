using System.Threading;
using Service_Calculation.Modal;

namespace Service_Calculation.Service
{

    public class CalculationService
    {
        private volatile bool _stopFlag;
        private Thread _threadCalculation;
        private Thread _threadGenerator;
        private volatile bool _processingError;
        private readonly Separator _start = new Separator();

        public void Start()
        {
            var stopFlag = _stopFlag;
            _threadGenerator = new Thread(x =>
            {
                do
                {
                    _start.GenerateFTasks();
                } while (!SrvUtils.Retarder(10, ref stopFlag));
            });

            _threadCalculation = new Thread(x =>
            {
                do
                {
                  _start.Scan(_start.PathDir);
                } while (!SrvUtils.Retarder(20, ref stopFlag));
            });

            _threadGenerator.Start();
            _threadCalculation.Start();
        }
        

        

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}