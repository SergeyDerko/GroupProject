using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.modal
{
    class Mammals: IAnimal
    {
        MammalsRace MammalsRace { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public TypeAnimal Type { get; set; }
        public Sex Sex { get; set; }
    }

    internal enum MammalsRace
    {
        Wolf,
        Bear

    }

}
