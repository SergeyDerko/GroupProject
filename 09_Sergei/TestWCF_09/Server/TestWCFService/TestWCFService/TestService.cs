using System;
using System.ServiceModel;
using TestWCFLib;

namespace TestWCFService
{
    public class TestService
    {
      //  private volatile bool _processingError;
        private ServiceHost _host;

        public void Start()
        {
            if(_host == null)
            _host = new ServiceHost(typeof(Calc));
            _host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadKey();
            _host.Close();
        }



        public void Stop()
        {
            _host?.Close();
        }
    }
}
