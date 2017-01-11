using System.Collections.Generic;
using SergeyDerkoLibrary.MyLibrary;

namespace SergeyDerkoLibrary
{
    public class ScanPc : IScanPc
    {
        public Dictionary<string, string> Info()
        {
            var list = new Dictionary<string, string>
            {
                {"Hdd", Hdd.HddInfo()},
                {"Cpu", Cpu.CpuInfo()},
                {"Memory", Memory.MemoryInfo()},
                {"Video", Video.VideoInfo()}
            };
            return list;
        }
    }
}
