using System.ServiceProcess;
using ExchangeRatesServiceLib;
using PlitkaLib;
using SergeyDerkoLibrary;
using TestWcfLib;
using TimeOfDayConvertWcfLib;
using CurrencyConvertWcfLib;

namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        private readonly BaseService<Calc> _calcService = new BaseService<Calc>();
        private  readonly  BaseService<TimeOfDayConvert> _timeOfDayService =  new BaseService<TimeOfDayConvert>();
        private readonly BaseService<ScanPc> _scanPcService = new BaseService<ScanPc>();
        private readonly BaseService<ExchangeRates> _exchangeRates = new BaseService<ExchangeRates>();
        private readonly BaseService<Plitka> _plitka = new BaseService<Plitka>();
        private readonly BaseService<CurrencyConvert> _currencyConvert = new BaseService<CurrencyConvert>();
		
        public void StartSvc()
        {
            _timeOfDayService.Start();
            _scanPcService.Start();
            _calcService.Start();
            _exchangeRates.Start();
            _plitka.Start();
            _currencyConvert.Start();
        }

        public void StopSvc()
        {
            _timeOfDayService.Stop();
            _scanPcService.Stop();
            _calcService.Stop();
            _exchangeRates.Stop();
            _plitka.Stop();
            _currencyConvert.Stop();
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