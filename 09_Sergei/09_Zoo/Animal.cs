
namespace _09_Zoo
{
    internal interface IAnimal
    {
        string Name { get; set; }
        int Id { get;  set; }
    }

    internal enum Type
    {
        Amhibians,
        Birds,  
        Reptiles,
        Mammals
    }

    enum Kind
    {
        male,
        female,

    }
       
    
}