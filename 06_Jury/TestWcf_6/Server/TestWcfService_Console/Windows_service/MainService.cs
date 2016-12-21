using System.ServiceProcess;

namespace TestWcfService_Console.Windows_service
{
    internal class MainService : ServiceBase
    {

        private readonly TestWcfService _testWcfService = new TestWcfService();

        public void StartSvc()
        {
            _testWcfService.Start();
        }

        public void StopSvc()
        {
            _testWcfService.Stop();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            StartSvc();
        }

        protected override void OnStop()
        {
            base.OnStop();
            StopSvc();
        }
    }
}
