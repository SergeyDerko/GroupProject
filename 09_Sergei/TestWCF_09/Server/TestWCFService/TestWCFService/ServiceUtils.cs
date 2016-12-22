using System.Threading;

namespace TestWCFService
{
    public class ServiceUtils
    {
        public static bool Retarder(int seconds, ref bool stop)
        {
            for (var i = 0; !stop && i < seconds * 1000 / TestConstants.TimeScanStopParam; i++)
            {
                Thread.Sleep(TestConstants.TimeScanStopParam);
            }
            return stop;
        }
    }
}
