using System;

namespace _08_Zoo.modal.Mammals
{
    internal class Monkey : Mammals
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Mammals;
        public new MammalsRace MammalsRace { get; private set; } = MammalsRace.Monkey;
        public override void Voice() => Console.WriteLine("MONKEY say anything");
        public override void Run() => Console.WriteLine("MONKEY run slowly");


    }
}
