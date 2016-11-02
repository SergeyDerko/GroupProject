using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Seryan
{
    class Unit
    {
        /// <summary>
        /// Замедляет работу основного потока на указанное количество секунд.
        /// </summary>
        /// <param name="seconds">Количество секунд задержки</param>
        /// <param name="stop">ссылка на ключ остановки службы</param>
        public static bool Retarder(int seconds, ref bool stop)
        {
            for (int i = 0; !stop && i < seconds * 1000 / Galya.TimeScanStopParam; i++)
            {
                Thread.Sleep(Galya.TimeScanStopParam);
            }
            return stop;
        }
    }
}
