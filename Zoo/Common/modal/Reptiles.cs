using System;

namespace Common.modal
{
    class Reptiles:IAnimal
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public ReptilesRace ReptilesRace { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }
    internal enum ReptilesRace
    {
        Snake = 1,
        Turtle = 2,
        Crocodile = 3,
        Alligator = 4,
        Lizard = 5
    }

}
