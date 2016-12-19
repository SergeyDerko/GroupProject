using System.ServiceProcess;


namespace TestWCFService.service
{
    internal class MainService : ServiceBase
    {
        private readonly TestService _testWcfService = new TestService();

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
