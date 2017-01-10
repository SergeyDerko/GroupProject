using System.ServiceProcess;

namespace TestService
{
    internal class MainService : ServiceBase
    {

        private readonly TestService _calcService = new TestService();
        private readonly TimeOfDayService _timeOfDayService = new TimeOfDayService();

        public void StartSvc()
        {
            _calcService.Start();
            _timeOfDayService.Start();
        }

        public void StopSvc()
        {
            _calcService.Stop();
            _timeOfDayService.Stop();
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