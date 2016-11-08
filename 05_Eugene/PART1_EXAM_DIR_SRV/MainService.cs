﻿
using System.ServiceProcess;

namespace PART1_EXAM_DIR_SRV
{
    internal class MainService : ServiceBase
    {

        private readonly TestService _testService = new TestService();

        public void StartSvc()
        {
            _testService.Start();
        }

        public void StopSvc()
        {
            _testService.Stop();
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
    