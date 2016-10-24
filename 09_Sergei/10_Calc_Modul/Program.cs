using System;
using System.Threading;

namespace _10_Calc_Modul
{
    internal class Program
    {
        private static void Main( /*string[] args*/)
        {
            Start();
        }
        #region Start
        private static void Start()
        {
            do
            {
                var s = new ScanDirectory();
                s.Scan(s.PathDir);
                Thread.Sleep(20000);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        #endregion
    }
}
