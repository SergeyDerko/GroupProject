using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.modal
{
    class Birds: IAnimal
    {
        BirdsRace Birdsrace { get; set; }
        public string Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }

        private enum BirdsRace
        {
           Raven,
           Dove,
           Falcon
        }
    }
}
