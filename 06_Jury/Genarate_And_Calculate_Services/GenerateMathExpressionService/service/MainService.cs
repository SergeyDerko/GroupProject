using System.ServiceProcess;

namespace GenerateMathExpressionService.service
{
    internal class MainService : ServiceBase
    {

        private readonly GenerateService _generateService = new GenerateService();

        public void StartSvc()
        {
            _generateService.Start();
        }

        public void StopSvc()
        {
            _generateService.Stop();
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
