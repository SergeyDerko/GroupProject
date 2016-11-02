using System.ServiceProcess;

namespace _14_CalculationService
{
    internal class MainService : ServiceBase
    {

        private readonly CalculationService _calculationService = new CalculationService();

        public void StartSvc()
        {
            _calculationService.Start();
        }

        public void StopSvc()
        {
            _calculationService.Stop();
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