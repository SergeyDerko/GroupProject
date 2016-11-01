using System;

namespace _08_Zoo.modal.Mammals
{
    internal class Panda : Mammals
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Mammals;
        public new MammalsRace MammalsRace { get; private set; } = MammalsRace.Panda;
        public override void Voice() => Console.WriteLine("PANDA say anything");
        public override void Run() => Console.WriteLine("PANDA run slowly");


    }
}
