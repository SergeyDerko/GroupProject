namespace _08_Zoo.modal
{
    internal interface IBirds
    {
        BirdsRace BirdsRace { get; }
    }
     
    
    internal enum BirdsRace
    {
        Raven = 1,
        Dove = 2,
        Falcon = 3,
        Penguin = 4,
        Woodpecker = 5,
    }
}
