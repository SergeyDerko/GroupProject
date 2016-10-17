using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plitochnik
{
    class Stena
    {
        public int Pshirina;
        public int Pvisota;
        public int Sshirina;
        public int Svisota;

        public Stena(int ps, int pv, int ss, int sv)
        {
            Pshirina = ps;
            Pvisota = pv;
            Sshirina = ss;
            Svisota = sv;
        }

        public int SposhPlitka()
        {
            return Pshirina*Pvisota;
        }

        public int SposhStena()
        {
            return Sshirina*Svisota;
        }

        public int Kolplit()
        {
            return SposhStena()/SposhPlitka();
        }
    }
}
