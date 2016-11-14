using System.ServiceProcess;

namespace Service_Calculation.Service
{
    public class MainService : ServiceBase
    {

        private readonly
        CalculationService _calcservice = new CalculationService();

        public  void StartSvc()
        {
            _calcservice.Start();
        }

        public void StopSvc()
        {
            _calcservice.Stop();
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
