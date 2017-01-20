
using ReadLoger.ServiceReference;

namespace TestWcfSite.Models.SergeyDerkoModels
{
    public class ReadLogModel
    {
        public string AddClass()
        {
             ReadLogClient read = new ReadLogClient();
             ReadLog readLogVcf = read.ReadServiseLog();
             string infoLog = readLogVcf.ReadLogInServise;
             return infoLog;
        }
        
        
    }
}