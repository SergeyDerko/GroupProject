using System.ServiceProcess;
using TestWcfLib;
using TimeOfDayConvertWcfLib;

namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        //private readonly BaseService<ScanPc> _scanPcService = new BaseService<ScanPc>();
        private readonly BaseService<Calc> _calcService = new BaseService<Calc>();
        private  readonly  BaseService<TimeOfDayConvert> _timeOfDayService =  new BaseService<TimeOfDayConvert>();

        public void StartSvc()
        {
            //_scanPcService.Start();
            _timeOfDayService.Start();
            _calcService.Start();
        }

        public void StopSvc()
        {
            //_scanPcService.Stop();
            _timeOfDayService.Stop();
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