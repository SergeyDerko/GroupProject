using System.Collections.Generic;
using SergeyDerkoLibrary.MyLibrary;
using TestWcfCommon;

namespace SergeyDerkoLibrary
{
    public class ScanPc : IScanPc
    {
        public Dictionary<string, string> Info()
        {
            Logger.Enter();
            var list = new Dictionary<string, string>
            {
                {"Hdd", Hdd.HddInfo()},
                {"Cpu", Cpu.CpuInfo()},
                {"Memory", Memory.MemoryInfo()},
                {"Video", Video.VideoInfo()}
            };
            
            Logger.Info(Hdd.HddInfo().Replace("<br />", "\n"));
            Logger.Info(Cpu.CpuInfo().Replace("<br />", "\n"));
            Logger.Info(Memory.MemoryInfo().Replace("<br />", "\n"));
            Logger.Info(Video.VideoInfo().Replace("<br />", "\n"));
            Logger.Leave("Выход из метода ScanPc.Info()");
            return list;
        }
    }
}
