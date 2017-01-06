using System.ServiceProcess;
using ExchangeRatesServiceLib;
using SergeyDerkoLibrary;
using TestWcfLib;

namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        private readonly BaseService<Calc> _calcService = new BaseService<Calc>();
        private readonly BaseService<ScanPc> _scanPcService = new BaseService<ScanPc>();
        private readonly BaseService<ExchangeRates> _exchangeRates = new BaseService<ExchangeRates>();

        public void StartSvc()
        {
            _calcService.Start();
            _scanPcService.Start();
            _exchangeRates.Start();
        }

        public void StopSvc()
        {
            _scanPcService.Stop();
            _calcService.Stop();
            _exchangeRates.Stop();
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