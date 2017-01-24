using System.ServiceProcess;
using ExchangeRatesServiceLib;
using PlitkaLib;
using SergeyDerkoLibrary;
using TestWcfLib;
using TimeOfDayConvertWcfLib;
using CurrencyConvertWcfLib;
using CurrencyRateServiceLibrary;
using ServicesViewerLib;
using TestWcfCommon;
using MeteoTempServiceLib;
using TemperatureServiceLib;


namespace TestWcfService
{
    internal class MainService : ServiceBase
    {
        private readonly BaseService<Calc> _calcService = new BaseService<Calc>();
        private readonly BaseService<TimeOfDayConvert> _timeOfDayService =  new BaseService<TimeOfDayConvert>();
        private readonly BaseService<ScanPc> _scanPcService = new BaseService<ScanPc>();
        private readonly BaseService<ReadLog> _readLogService = new BaseService<ReadLog>();
        private readonly BaseService<ExchangeRates> _exchangeRates = new BaseService<ExchangeRates>();
        private readonly BaseService<CurrencyRate> _currencyRate = new BaseService<CurrencyRate>();
        private readonly BaseService<Plitka> _plitka = new BaseService<Plitka>();
        private readonly BaseService<CurrencyConvert> _currencyConvert = new BaseService<CurrencyConvert>();
        private readonly BaseService<ServicesViewer> _servicesViewer = new BaseService<ServicesViewer>();
        private readonly BaseService<MeteoTemp> _meteoTempService = new BaseService<MeteoTemp>();
        private readonly BaseService<Temperature> _temperature = new BaseService<Temperature>();

        public void StartSvc()
        {
            Logger.Enter();
            _timeOfDayService.Start();
            _scanPcService.Start();
            _readLogService.Start();
            _calcService.Start();
            _exchangeRates.Start();
           _currencyRate.Start();
            _plitka.Start();
            _currencyConvert.Start();
            _servicesViewer.Start();
            _meteoTempService.Start();
            _temperature.Start();
            Logger.Leave();
        }

        public void StopSvc()
        {
            Logger.Enter();
            _timeOfDayService.Stop();
            _scanPcService.Stop();
            _readLogService.Stop();
            _calcService.Stop();
            _exchangeRates.Stop();
            _currencyRate.Stop();
            _plitka.Stop();
            _currencyConvert.Stop();
            _servicesViewer.Stop();
            _meteoTempService.Stop();
            _temperature.Stop();
            Logger.Leave();
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