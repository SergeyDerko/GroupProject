namespace Common.modal
{
    class Fish:IAnimal
    {
        public FishRace FishRace { get; set; }
        public string Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
    }
    internal enum FishRace
    {
        Shark = 1,
        Skate = 2,
        Piranha = 3,
        Pike = 4,
        Cartfish = 5,
        Dolphin = 6
    }
}
