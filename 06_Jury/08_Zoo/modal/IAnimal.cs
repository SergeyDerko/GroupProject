using System;

namespace _08_Zoo.modal
{
    internal interface IAnimal
    {
        int Id { get; }
        TypeAnimal Type { get; }
        string Nickname { get; }
        DateTime Birthday { get; }
        Sex Sex { get; }
        void Voice();
    }

    internal enum TypeAnimal
    {
        Mammals = 1,
        Birds = 2,
    }

    public enum Sex
    {
        None = 0,
        Male = 1,
        Female = 2,
    }
}
