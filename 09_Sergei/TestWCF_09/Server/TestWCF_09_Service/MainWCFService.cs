

using System.ServiceProcess;

namespace TestWCF_09_Service
{
    class MainWCFService : ServiceBase
    {
        private readonly TestWCFService _testService = new TestWCFService();

        public void StartSvc()
        {
            _testService.Start();
        }

        public void StopSvc()
        {
            _testService.Stop();
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
