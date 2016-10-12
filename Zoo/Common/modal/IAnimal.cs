namespace Common.modal
{
    internal interface IAnimal
    {
        int Id { get; set; }
        TypeAnimal Type { get; set; }
        string Nickname { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
       
    }
    
    internal enum TypeAnimal
    {
        Mammals = 1,
        Birds = 2,
        Reptiles = 3,
        Fish = 4,
        Amphibians = 5,
     }
    internal enum Sex
    {
        None = 0,
        Male = 1,
        Female = 2,
    }
}