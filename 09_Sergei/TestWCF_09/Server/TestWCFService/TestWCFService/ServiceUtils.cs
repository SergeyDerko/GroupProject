using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWCFService
{
    class ServiceUtils
    {
        public static bool Retarder(int seconds, ref bool stop)
        {
            for (int i = 0; !stop && i < seconds * 1000 / Constants.TimeScanStopParam; i++)
            {
                Thread.Sleep(Constants.TimeScanStopParam);
            }
            return stop;
        }
    }
}
