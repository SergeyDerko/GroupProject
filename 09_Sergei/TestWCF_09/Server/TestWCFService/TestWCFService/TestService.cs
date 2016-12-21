using System;
using System.ServiceModel;
using System.Threading;
using TestWCFLib;

namespace TestWCFService
{
    public class TestService
    {
      //  private volatile bool _processingError;
        private bool _stopFlag;
        private Thread _thread;
        public void Start()
        {
            _thread = new Thread(x =>
            {
                using (var host = new ServiceHost(typeof(Calc)))
                {
                    host.Open();
                    Console.Title = "Server";
                    Console.WriteLine("Сервер запушен!");
                    while ((!ServiceUtils.Retarder(5, ref _stopFlag)));
                    host.Close();
                }
                    Console.ReadKey();
            });
            
        }
        
        public void Stop()
        {
            _stopFlag = false;
        }
    }
}
