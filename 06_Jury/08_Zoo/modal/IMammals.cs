namespace _08_Zoo.modal
{
    internal interface IMammals
    {
        MammalsRace MammalsRace { get; }
    }
     
    
    internal enum MammalsRace
    {
        Wolf = 1,
        Bear = 2,
        Monkey = 3,
        Panda = 4,
        Leopard = 5,
      
    }
}
