using System;

namespace _08_Zoo.modal.Birds
{
    internal class Raven : Birds
    {
        public new TypeAnimal Type { get; private set;  } = TypeAnimal.Birds;
        public new BirdsRace BirdsRace { get; private set; } = BirdsRace.Raven;

        public override void Voice() => Console.WriteLine("RAVEN say anything");
        
        public override void Fly() => Console.WriteLine("RAVEN can fly");
       
    }
}
