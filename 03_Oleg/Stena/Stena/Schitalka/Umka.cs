using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stena.Schitalka
{
    class Umka
    {
        public int ShirinaStena;
        public int VisotaStena;
        public int ShirinaPlitka;
        public int VisotaPlitka;

        public Umka(int SS, int VS, int SP, int VP)
        {
            ShirinaStena = SS;
            VisotaStena = VS;
            ShirinaPlitka = SP;
            VisotaPlitka = VP;
        }

        public int PloshaSteny()
        {
            return ShirinaStena*VisotaStena;
        }

        public int PloshaPlitki()
        {
            return ShirinaPlitka*VisotaPlitka;
        }

        public int Kolichestvo()
        {
            return PloshaSteny()/PloshaPlitki();
        } 
    }
}
