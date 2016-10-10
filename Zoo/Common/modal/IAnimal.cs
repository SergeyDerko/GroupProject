namespace Common.modal
{
    internal interface IAnimal
    {
        string Name { get; set; }
        TypeAnimal Type { get; set; }
        Sex Sex { get; set; }

    }

    internal enum TypeAnimal
    {
        Birds,
        Mammals,
        Reptiles
    }
    internal enum Sex
    {
        Male,
        Female,
        It
    }

}