namespace Common.modal
{
    class Mammals: IAnimal
    {
        public MammalsRace MammalsRace { get; set; }
        public string Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
    }
    internal enum MammalsRace
    {
        Wolf = 1,
        Bear = 2,
        Elephant = 3,
        Monkey = 4,
        Lion = 5,
        Rabbit =6,
        Panda = 7,
        Leopard = 8,
        Fox = 9,
        Hedgehogs =10,
        Tiger = 11
    }

}
