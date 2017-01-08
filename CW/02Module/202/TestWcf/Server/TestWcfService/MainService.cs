using System.ServiceProcess;
using ExchangeRatesServiceLib;
using PlitkaLib;
using SergeyDerkoLibrary;
using TestWcfLib;

namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        private readonly BaseService<Calc> _calcService = new BaseService<Calc>();
        private readonly BaseService<ScanPc> _scanPcService = new BaseService<ScanPc>();
        private readonly BaseService<ExchangeRates> _exchangeRates = new BaseService<ExchangeRates>();
        private readonly BaseService<Plitka> _plitka = new BaseService<Plitka>();

        public void StartSvc()
        {
            _calcService.Start();
            _scanPcService.Start();
            _exchangeRates.Start();
            _plitka.Start();
        }

        public void StopSvc()
        {
            _scanPcService.Stop();
            _calcService.Stop();
            _exchangeRates.Stop();
            _plitka.Stop();
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