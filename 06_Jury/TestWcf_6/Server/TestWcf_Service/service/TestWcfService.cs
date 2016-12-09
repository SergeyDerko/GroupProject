using System.Threading;

namespace TestWcf_Service.service
{
    /// <summary>
    /// Основной код сервиса для формирования задач в ис-про
    /// </summary>
    internal class TestWcfService
    {
        private volatile bool _stopFlag;
        private Thread _thread;

        public void Start()
        {
            _thread = new Thread(x =>
            {
                var stopFlag = _stopFlag;
                do
                {
                    //Generator.Generate(); // старт

                } while (!SrvUtils.Retarder(5, ref stopFlag));
            });
            _thread.Start();
            //Process.Start(Generator.FolderForFiles); // открыть папку с файлами
        }

        public void Stop()
        {
            _stopFlag = true;
        }
    }
}
