using System;
using System.Threading;

namespace TestWCFService
{
    internal class TestService
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
                        ServiceUtils.Retarder(1, ref _stopFlag);
                    }
                } while (!ServiceUtils.Retarder(30, ref _stopFlag));
            });
            _thread.Start();
        }



        public void Stop()
        {
            _stopFlag = true;
        }
    }
}
