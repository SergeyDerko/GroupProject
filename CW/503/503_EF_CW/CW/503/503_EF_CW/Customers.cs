namespace _503_EF_CW
{
    public partial class Customers
    {
        public override string ToString()
        {
            return $"{nameof(IdCustomer)}: {IdCustomer}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(City)}: {City}, {nameof(Age)}: {Age}, {nameof(BirthDate)}: {BirthDate}";
        }
    }
}