using System;

namespace Common.modal
{
    class Amphibian:IAnimal
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public AmphibianRace AmphibianRace { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }
    internal enum AmphibianRace
    {
        Frog = 1,
        Toad = 2,
        Salamander = 3,
        Newt = 4
    }
}
