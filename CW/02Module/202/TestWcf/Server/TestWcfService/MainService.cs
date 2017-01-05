using System.ServiceProcess;
using TestWcfLib;

namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        //private readonly ScanPcService<ScanPc> _scanPcService = new ScanPcService<ScanPc>();
        private readonly CalcService<Calc> _calcService = new CalcService<Calc>();

        public void StartSvc()
        {
            //_scanPcService.Start();
            _calcService.Start();
        }

        public void StopSvc()
        {
            //_scanPcService.Stop();
            _calcService.Stop();
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