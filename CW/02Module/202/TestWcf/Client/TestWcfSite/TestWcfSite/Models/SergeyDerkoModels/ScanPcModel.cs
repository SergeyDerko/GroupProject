using System.Collections.Generic;
using SergeyDerkoLibrary.ScanPcReference;

namespace TestWcfSite.Models.SergeyDerkoModels
{
    public class ScanPcModel
    {
        static readonly ScanPcClient ScanPc = new ScanPcClient();
        static readonly Dictionary<string, string> Scan = ScanPc.Info();
        public string Hdd = Scan["Hdd"];
        public string Cpu = Scan["Cpu"];
        public string Memory = Scan["Memory"];
        public string Video = Scan["Video"];
    }
}