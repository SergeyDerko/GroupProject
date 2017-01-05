using System.ServiceModel;
using System.Threading;

namespace TestWcfService
{
    class BaseService<T>
    {
        private volatile bool _stopFlag;
        private Thread _thread;
        private volatile bool _processingError;

        public void Start()
        {
            _thread = new Thread(x =>
            {
                var host = new ServiceHost(typeof(T));
                host.Open();

                do
                {

                } while (!SrvUtils.Retarder(30, ref _stopFlag));

                host.Close();
            });
            _thread.Start();
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}