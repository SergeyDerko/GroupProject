using System;

namespace _08_Zoo.modal.Birds
{
    internal class Penguin : Birds
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Birds;
        public new BirdsRace BirdsRace { get; private set; } = BirdsRace.Penguin;
        
        public override void Voice() => Console.WriteLine("PENGUIN say anything");
        public override void Fly() => Console.WriteLine("PENGUIN can't fly");
    }
}
