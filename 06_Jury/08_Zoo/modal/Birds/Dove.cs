using System;

namespace _08_Zoo.modal.Birds
{
    internal class Dove : Birds
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Birds;
        public new BirdsRace BirdsRace { get; private set; } = BirdsRace.Dove;

        public override void Voice() => Console.WriteLine("DOVE say anything");

        public override void Fly() => Console.WriteLine("DOVE can fly");
      
    }
}
