using System.ServiceProcess;
<<<<<<< HEAD
=======
using FirstServise;

>>>>>>> 77945f625ef2bd4de286189ff6a3c9c533f35888
namespace Part1_exam_srv
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