using System;

namespace _08_Zoo.modal.Birds
{
    internal class Falcon : Birds
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Birds;
        public new BirdsRace BirdsRace { get; private set; } = BirdsRace.Falcon;


        public override void Voice() => Console.WriteLine("FALCON say anything");

        public override void Fly() => Console.WriteLine("FALCON can fly");
    }
}
