using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWcf_Service.service
{
    internal class MainService : ServiceBase
    {

        private readonly TestWcfService _testWcfService = new TestWcfService();

        public void StartSvc()
        {
            _testWcfService.Start();
        }

        public void StopSvc()
        {
            _testWcfService.Stop();
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
